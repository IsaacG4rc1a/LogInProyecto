﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.BL
{
	public class DatosDeInicio : CreateDatabaseIfNotExists<ContextoBD>
	{
		protected override void Seed(ContextoBD context)
		{
			//////////////////////////// Datos de inicio Usuarios/////////////////////

			var Usuario = new Usuarios();

			Usuario.Id = 1;
			Usuario.Usuario = "admin";
			Usuario.Contrasenia = "123";
			Usuario.TipoUsuario = "Administrador";

			context.tbUsuarios.Add(Usuario);

			//////////////////////////// Datos de inicio Estado civil/////////////////////
			var Ec = new EstadoCivil();
			Ec.Descripcion = "Solter@";
			context.tbEstadoCivil.Add(Ec);

			var Ec1 = new EstadoCivil();
			Ec1.Descripcion = "Casad@";
			context.tbEstadoCivil.Add(Ec1);

			var Ec2 = new EstadoCivil();
			Ec2.Descripcion = "Divorciado@";
			context.tbEstadoCivil.Add(Ec2);

			var Ec3 = new EstadoCivil();
			Ec3.Descripcion = "Viud@";
			context.tbEstadoCivil.Add(Ec3);

			var Ec4 = new EstadoCivil();
			Ec4.Descripcion = "Unión libre";
			context.tbEstadoCivil.Add(Ec4);

			///////////////////////////////////////////Datos de inicio - Asignaturas///////////////////////////////////
			//var Asig = new AsignaturasLista();

			//Asig.Descripcion = "Espaniol General";
			//Asig.Cupo = 20;
			//context.tbAsignaturas.Add(Asig);

			//var Asig2 = new AsignaturasLista();

			//Asig2.Descripcion = "Redaccion General";
			//Asig2.Cupo = 20;
			//context.tbAsignaturas.Add(Asig2);

			//var Asig3 = new AsignaturasLista();

			//Asig3.Descripcion = "Filosofia";
			//Asig3.Cupo = 20;
			//context.tbAsignaturas.Add(Asig3);


			//var Asig4 = new AsignaturasLista();

			//Asig4.Descripcion = "Historia de Honduras";
			//Asig4.Cupo = 20;
			//context.tbAsignaturas.Add(Asig4);

			///////////////////////////////////////////Datos de inicio - Docentes/////////////////////////////////////
			var Facultad = new Facultades();

			Facultad.Descripcion = "Ingeniería";
			context.tbFacultades.Add(Facultad);

			var Facultad2 = new Facultades();

			Facultad2.Descripcion = "Odontología";
			context.tbFacultades.Add(Facultad2);

			var Facultad3 = new Facultades();

			Facultad3.Descripcion = "Humanidades y Artes";
			context.tbFacultades.Add(Facultad3);

			var Facultad4 = new Facultades();

			Facultad4.Descripcion = "Ciencias Espaciales";
			context.tbFacultades.Add(Facultad4);

			var Facultad5 = new Facultades();

			Facultad5.Descripcion = "Ciencias Económicas, Administrativas y Contables";
			context.tbFacultades.Add(Facultad5);

			///////////////////////////////////////// Listado de alumnos cvs ///////////////////////////////////////////
			var archivo = "../../../AlumnosListado.csv";

			using (var reader = new StreamReader(archivo))
			{
				reader.ReadLine(); //Lea fila encabezado

				while (!reader.EndOfStream)
				{
					var linea = reader.ReadLine();
					var valores = linea.Split(',');

					var AlumnoNuevo = new AlumnosLista();

					AlumnoNuevo.Nombres = valores[0].ToString();
					AlumnoNuevo.Apellidos = valores[1].ToString();
					AlumnoNuevo.Sexo = valores[2].ToString();
					AlumnoNuevo.EstadoCivil = Ec;
					AlumnoNuevo.Telefono = valores[5].ToString();
					AlumnoNuevo.Direccion = valores[4].ToString();
					//AlumnoNuevo.Foto = .Parse(valores[6].ToString());
					AlumnoNuevo.Activo = bool.Parse(valores[7].ToString());

					context.tbAlumnos.Add(AlumnoNuevo);
				}
			}

			base.Seed(context);
		}

	}
}
