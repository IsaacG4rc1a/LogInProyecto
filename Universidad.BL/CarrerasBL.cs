using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.BL
{
	public class CarrerasBL
	{
		ContextoBD _contexto;

		public BindingList<Carrera> ListaCarrerra { get; set; }
		public BindingList<Facultades> ListaFacultades { get; set; }

		public CarrerasBL()
		{
			_contexto = new ContextoBD();
		}

		public BindingList<Carrera> ObtenerCarreras()
		{
			_contexto.tbCarreras.Load();
			ListaCarrerra = _contexto.tbCarreras.Local.ToBindingList();
			return ListaCarrerra;
		}

		//Obtine el listado de FACULTADES
		public BindingList<Facultades> Obtenerfacultades()
		{
			_contexto.tbFacultades.Load();
			ListaFacultades = _contexto.tbFacultades.Local.ToBindingList();
			return ListaFacultades;
		}

		public Resultado Validar(Carrera Carr)
		{
			var res = new Resultado();
			if (Carr == null)
			{
				res.Mensaje = "Agregue una Carrera válida.";
				res.Exitoso = false;

				return res;
			}
			if (string.IsNullOrEmpty(Carr.Descripcion) == true)
			{
				res.Mensaje = "Ingrese una descripción";
				res.Exitoso = false;
				return res;
			}
			if (string.IsNullOrEmpty(Convert.ToString(Carr.FacultadId)) == true)
			{
				res.Mensaje = "Seleccione una facultad";
				res.Exitoso = false;
				return res;
			}
			res.Exitoso = true;
			return res;
		}

		//Metodo Guardar
		public Resultado Guardar(Carrera carr)
		{
			var result = Validar(carr);
			if (result.Exitoso == false)
			{
				return result;
			}
			_contexto.SaveChanges();
			result.Exitoso = true;
			return result;
		}

		public void AgregarCarrera()
		{
			var NuevaCarrera = new Carrera();
			ListaCarrerra.Add(NuevaCarrera);
		}

		//METODO PARA ELIMINAR registro guardado
		public bool Eliminar(int id)
		{
			foreach (var item in ListaCarrerra)
			{
				if (item.Id == id)
				{
					ListaCarrerra.Remove(item);
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

	}

	public class Carrera
	{
		public int Id { get; set; }
		public string Descripcion { get; set; }
		public int FacultadId { get; set; }
		public Facultades Facultades { get; set; }
	}

	public class Facultades
	{
		public int Id { get; set; }
		public string Descripcion { get; set; }
	}

}
