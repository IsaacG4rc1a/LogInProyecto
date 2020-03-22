using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.BL
{
	public class DocentesBL
	{
        ContextoBD _contexto;//declarando la instancia de tipo global para poder usarla en todos los metodos
		public BindingList<DocentesLista> ListaDocentes { get; set; }

		public DocentesBL()
		{
			_contexto = new ContextoBD();//Const.
			ListaDocentes = new BindingList<DocentesLista>();//Instancia de lista alumnos

		}

		public BindingList<DocentesLista> ObtenerDocentes()
		{
			_contexto.tbDocentes.Load();
			ListaDocentes = _contexto.tbDocentes.Local.ToBindingList();
			return ListaDocentes;
		}

		//METODO PARA AGREGAR 
		public Resultado Guardar(DocentesLista Doce)
		{
			var resultado = Validar(Doce);

			if (resultado.Exitoso == false)
			{
				return resultado;
			}
			_contexto.SaveChanges();
			resultado.Exitoso = true;
			return resultado;
		}

		public void AgregarDocente()
		{
			var NuevoDocente = new DocentesLista();
			ListaDocentes.Add(NuevoDocente);
		}

		//METODO PARA ELIMINAR registro guardado
		public bool Eliminar(int id)
		{
			foreach (var item in ListaDocentes)
			{
				if (item.Id == id)
				{
					ListaDocentes.Remove(item);
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

		public Resultado Validar(DocentesLista Docentes)
		{
			var res = new Resultado();
			res.Exitoso = true;

			return res;
		}
	}

}
