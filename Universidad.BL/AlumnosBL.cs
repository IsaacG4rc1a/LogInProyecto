using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.BL
{
	public class AlumnosBL
	{
        ContextoBD _contexto;//declarando la instancia de tipo global para poder usarla en todos los metodos
		public BindingList<AlumnosLista> ListaAlumno { get; set; }

		public AlumnosBL()
		{
            _contexto = new ContextoBD();//Const.
			ListaAlumno = new BindingList<AlumnosLista>();//Instancia de lista alumnos
			
		}

		public BindingList<AlumnosLista> ObtenerAlumnos()
		{
            _contexto.tbAlumnos.Load();


            ListaAlumno = _contexto.tbAlumnos.Local.ToBindingList();
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
            _contexto.SaveChanges();
			resultado.Exitoso = true;
			return resultado;
		}

		public void AgregarAlumnos()
		{
			var NuevoAlumno = new AlumnosLista();
			ListaAlumno.Add(NuevoAlumno);
		}

		//METODO PARA ELIMINAR registro guardado
		public bool Eliminar(int id)
		{
			foreach (var item in ListaAlumno)
			{
				if (item.Id == id)
				{
					ListaAlumno.Remove(item);
					_contexto.SaveChanges();
					return true;
				}
			}
			return false;
		}

		public void CancelarCambios()//Cancela el nuevo registro creado
		{
			foreach (var item in _contexto.ChangeTracker.Entries())
			{
				item.State = EntityState.Unchanged;
				item.Reload();
			}
		}

		public Resultado Validar(AlumnosLista ALumnos)
		{
			var res = new Resultado();
			res.Exitoso = true;

			if (ALumnos == null)
			{
				res.Mensaje = "Agregue un ALumno válido.";
				res.Exitoso = false;

				return res;
			}

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
			if (Convert.ToBoolean(ALumnos.EstadoCivilId) == false)
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
