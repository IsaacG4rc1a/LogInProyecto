using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.BL
{
	public class AlumnosBL
	{
		public BindingList<AlumnosLista> ListaAlumno { get; set; }
		public AlumnosBL()
		{
			ListaAlumno = new BindingList<AlumnosLista>();
			var Alumno = new AlumnosLista();

			Alumno.Id = 1;
			Alumno.Nombres = "Juan Ariel";
			Alumno.Apellidos = "Morales Cruz";
			Alumno.Direccion = "San Pedro Sula, Cortés";
			Alumno.Sexo = "M";
			Alumno.EstadoCivil = "S";
			Alumno.Telefono = "+504-9832-4543";

			var Alumno2 = new AlumnosLista();

			Alumno2.Id = 2;
			Alumno2.Nombres = "Maria Carolina";
			Alumno2.Apellidos = "Sanchez Cruz";
			Alumno2.Direccion = "San Pedro Sula, Cortés";
			Alumno2.Sexo = "F";
			Alumno2.EstadoCivil = "C";
			Alumno2.Telefono = "+504-9322-4543";

			ListaAlumno.Add(Alumno);
			ListaAlumno.Add(Alumno2);
		}

		public BindingList<AlumnosLista> ObtenerAlumnos()
		{
			return ListaAlumno;
		}

		//METODO PARA AGREGAR 
		public Resultado Guardar(AlumnosLista Alumno)
		{
			var resultado = Validar(Alumno);

			if (resultado.Exitoso == false)
			{
				return resultado;
			}
			if (Alumno.Id == 0)
			{
				Alumno.Id = ListaAlumno.Max(item => item.Id) + 1;
			}
			resultado.Exitoso = true;
			return resultado;
		}

		public void AgregarAlumnos()
		{
			var NuevoAlumno = new AlumnosLista();
			ListaAlumno.Add(NuevoAlumno);
		}

		//METODO PARA ELIMINAR
		public bool Eliminar(int id)
		{
			foreach (var item in ListaAlumno)
			{
				if (item.Id == id)
				{
					ListaAlumno.Remove(item);
					return true;
				}
			}
			return false;
		}

		public Resultado Validar(AlumnosLista ALumnos)
		{
			var res = new Resultado();
			res.Exitoso = true;

			if (string.IsNullOrEmpty(ALumnos.Nombres) == true)
			{
				res.Mensaje = "Ingrese un Nombre";
				res.Exitoso = false;
				return res;
			}
			if (string.IsNullOrEmpty(ALumnos.Apellidos) == true)
			{
				res.Mensaje = "Ingrese un Apellido";
				res.Exitoso = false;
				return res;
			}
			if(string.IsNullOrEmpty(ALumnos.Sexo) == true)
			{
				res.Mensaje = "Ingrese el Sexo";
				res.Exitoso = false;
				return res;
			}
			if (string.IsNullOrEmpty(ALumnos.EstadoCivil) == true)
			{
				res.Mensaje = "Ingrese el Estado civil";
				res.Exitoso = false;
				return res;
			}
			if (string.IsNullOrEmpty(ALumnos.Telefono) == true)
			{
				res.Mensaje = "Ingrese el Número de teléfono";
				res.Exitoso = false;
				return res;
			}
			if (string.IsNullOrEmpty(ALumnos.Direccion) == true)
			{
				res.Mensaje = "Ingrese el Sexo";
				res.Exitoso = false;
				return res;
			}
			return res;
		}
	}
	public class Resultado
	{
		public bool Exitoso { get; set; }
		public String Mensaje { get; set; }
	}
}
