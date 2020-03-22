using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.BL
{
	public class AsignaturasBL
	{
		ContextoBD _contexto;//declarando la instancia de tipo global para poder usarla en todos los metodos
		public BindingList<AsignaturasLista> ListaAsignaturas { get; set; }

		public AsignaturasBL()
		{
			_contexto = new ContextoBD();
		}

		public BindingList<AsignaturasLista> ObtenerAsignaturas()
		{
			_contexto.tbAsignaturas.Load();
			ListaAsignaturas = _contexto.tbAsignaturas.Local.ToBindingList();
			return ListaAsignaturas;
		}

		//METODO PARA AGREGAR 
		public Resultado Guardar(AsignaturasLista Asignatura)
		{
			var resultado = Validar(Asignatura);
			if (resultado.Exitoso == false)
			{
				return resultado;
			}
			_contexto.SaveChanges();
			resultado.Exitoso = true;
			return resultado;
		}

		public void AgregarMatricula()
		{
			var NuevaAsignatura = new AsignaturasLista();
			ListaAsignaturas.Add(NuevaAsignatura);
		}

		//METODO PARA ELIMINAR registro guardado
		public bool Eliminar(int id)
		{
			foreach (var item in ListaAsignaturas)
			{
				if (item.Id == id)
				{
					ListaAsignaturas.Remove(item);
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

		public Resultado Validar(AsignaturasLista Asignatura)
		{
			var res = new Resultado();
			if (Asignatura == null)
			{
				res.Mensaje = "Agregue una Asignatura válida.";
				res.Exitoso = false;

				return res;
			}
			res.Exitoso = true;
			return res;
		}
	}
}
