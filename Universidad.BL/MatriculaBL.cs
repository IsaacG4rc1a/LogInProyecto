using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Entity;

namespace Universidad.BL
{
	public class MatriculaBL
	{
		ContextoBD _contexto;//declarando la instancia de tipo global para poder usarla en todos los metodos
		public BindingList<MatriculaAsignaturas> ListaMatricula { get; set; }

		public MatriculaBL()
		{
			_contexto = new ContextoBD();
		}

		//public BindingList<MatriculaAsignaturas> ObtenerMatriculas(string Busqueda)
		//{
		//	_contexto.tbMatricula.Include("MatriculaDetalle").Load();

		//	var query = _contexto.tbMatricula.Include("Alumno")
		//			.Where(p => p.Alumno.Nombres
		//				.Contains(Busqueda.ToLower()) == true)
		//					.ToList();

		//	ListaMatricula = _contexto.tbMatricula.Local.ToBindingList();

		//	return ListaMatricula;
		//}

		public BindingList<MatriculaAsignaturas> ObtenerMatricula()
		{
			_contexto.tbMatricula.Include("MatriculaDetalle").Load();
			ListaMatricula = _contexto.tbMatricula.Local.ToBindingList();
			return ListaMatricula;
		}

		//METODO PARA AGREGAR 
		public Resultado Guardar(MatriculaAsignaturas Matricula)
		{
			var resultado = Validar(Matricula);
			if (resultado.Exitoso == false)
			{
				return resultado;
			}

			CalcularCupo(Matricula);

			_contexto.SaveChanges();
			resultado.Mensaje = "Guardado con exito.";
			return resultado;
		}

		private void CalcularCupo(MatriculaAsignaturas matricula)
		{
			foreach (var detalle in matricula.MatriculaDetalle)
			{
				var Matricula = _contexto.tbAsignaturas.Find(detalle.AsignaturaId);
				if (Matricula != null)
				{
					if (matricula.Activo == true)
					{
						Matricula.Cupo = Matricula.Cupo - 1;
					}
					else
					{
						Matricula.Cupo = Matricula.Cupo + 1;
					}
				}
			}
		}

		public void AgregarMatricula()
		{
			var NuevaMatricula = new MatriculaAsignaturas();
			ListaMatricula.Add(NuevaMatricula);
		}

		////METODO PARA ELIMINAR registro guardado
		//public bool Eliminar(int id)
		//{
		//	foreach (var item in ListaMatricula)
		//	{
		//		if (item.Id == id)
		//		{
		//			ListaMatricula.Remove(item);
		//			_contexto.SaveChanges();
		//			return true;
		//		}
		//	}
		//	return false;
		//}

		public bool AnularMatricula(int id)
		{
			foreach (var Matricu in ListaMatricula)
			{
				if (Matricu.Id == id)
				{
					Matricu.Activo = false;
					CalcularCupo(Matricu);
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

		public Resultado Validar(MatriculaAsignaturas Matricula)
		{
			var res = new Resultado();
			res.Exitoso = true;
			if (Matricula == null)
			{
				res.Mensaje = "Agregue una matricula para guardarla.";
				res.Exitoso = false;

				return res;
			}

			if (Matricula.Id != 0 && Matricula.Activo == true)
			{
				res.Mensaje = "La matricula ya fue emitida y no se pueden hacer cambios en ella.";
				res.Exitoso = false;
			}

			if (Matricula.Activo == false)
			{
				res.Mensaje = "La matricula está anulada y no se pueden realizar cambios en ella.";
				res.Exitoso = false;
			}
			if (Matricula.AlumnoId == 0)
			{
				res.Mensaje = "Seleccione un Alumno.";
				res.Exitoso = false;
			}
			if (Matricula.MatriculaDetalle.Count == 0)
			{
				res.Mensaje = "Agregue asignaturas a la matricula.";
				res.Exitoso = false;
			}

			foreach (var detalle in Matricula.MatriculaDetalle)
			{
				if (detalle.AsignaturaId == 0)
				{
					res.Mensaje = "Seleccione una asignatura válida.";
					res.Exitoso = false;
				}
				if (detalle.DocenteId == 0)
				{
					res.Mensaje = "Seleccione un docente válido.";
					res.Exitoso = false;
				}
				if (detalle.HoraInicio == "")
				{
					res.Mensaje = "Ingrese una hora de inicio.";
					res.Exitoso = false;
				}
				if (detalle.HoraFinaliza == "")
				{
					res.Mensaje = "Ingrese una hora final.";
					res.Exitoso = false;
				}
			}
			
			return res;
		}

		//Agregar matriculaDetalle
		public void AgregarMatriculaDetalle(MatriculaAsignaturas Matricula)
		{
			if (Matricula != null)
			{
				var nuevaMatDetalle = new MatriculaAsignaturasDetalle();
				Matricula.MatriculaDetalle.Add(nuevaMatDetalle);
			}
		}

		public void RemoverMatriculaDetalle(MatriculaAsignaturas Matricula, MatriculaAsignaturasDetalle MatDetalle)
		{
			if (Matricula != null && MatDetalle != null)
			{
				Matricula.MatriculaDetalle.Remove(MatDetalle);
			}
		}
	}


	public class MatriculaAsignaturas
	{
		public int Id { get; set; }
		public DateTime Fecha { get; set; }
		public int AlumnoId { get; set; }
		public AlumnosLista Alumno { get; set; }
		public BindingList<MatriculaAsignaturasDetalle> MatriculaDetalle { get; set; }
		public bool Activo { get; set; }

		public MatriculaAsignaturas()
		{
			Activo = true;
			Fecha = DateTime.Now;
			MatriculaDetalle = new BindingList<MatriculaAsignaturasDetalle>();
		}
	}

	public class MatriculaAsignaturasDetalle
	{
		public int Id { get; set; }
		public int AsignaturaId { get; set; }
		public AsignaturasLista Asigantura { get; set; }
		public int DocenteId { get; set; }
		public DocentesLista Docentes { get; set; }
		public string HoraInicio { get; set; }
		public string HoraFinaliza { get; set; }
	}


	//CLASE PARA DATOS DE INICIO
	public class AsignaturasLista
	{
		public int Id { get; set; }
		public string Descripcion { get; set; }
		public int Cupo { get; set; }
	}

	public class DocentesLista
	{
		public int Id { get; set; }
		public string Nombres { get; set; }
	}
}
