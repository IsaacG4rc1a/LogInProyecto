using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.BL
{
	public class UsuariosBL
	{
		ContextoBD _contexto;

		public BindingList<Usuarios> ListaUsuarios { get; set; }

		public UsuariosBL()
		{
			_contexto = new ContextoBD();
			ListaUsuarios = new BindingList<Usuarios>();
		}

		public BindingList<Usuarios> ObtenerUsuarios()
		{
			_contexto.tbUsuarios.Load();

			ListaUsuarios = _contexto.tbUsuarios.Local.ToBindingList();

			return ListaUsuarios;
		}

		//Validacion
		public Resultado Validar(Usuarios Usuarios)
		{
			var res = new Resultado();
			res.Exitoso = true;

			if (Usuarios == null)
			{
				res.Mensaje = "Agregue un ALumno válido.";
				res.Exitoso = false;

				return res;
			}

			if (string.IsNullOrEmpty(Usuarios.Usuario) == true)
			{
				res.Mensaje = "Ingrese un Nombre de usuario";
				res.Exitoso = false;
				return res;
			}
			if (string.IsNullOrEmpty(Usuarios.Contrasenia) == true)
			{
				res.Mensaje = "Ingrese una contrasenia";
				res.Exitoso = false;
				return res;
			}
			if (string.IsNullOrEmpty(Usuarios.TipoUsuario) == true)
			{
				res.Mensaje = "Ingrese el Tipo de Usuario";
				res.Exitoso = false;
				return res;
			}
		
			return res;
		}

		//METODO PARA AGREGAR 
		public Resultado Guardar(Usuarios Usuarios)
		{
			var resultado = Validar(Usuarios);

			if (resultado.Exitoso == false)
			{
				return resultado;
			}
			_contexto.SaveChanges();
			resultado.Exitoso = true;
			return resultado;
		}

		public void AgregarUsuarios()
		{
			var Users = new Usuarios();
			ListaUsuarios.Add(Users);
		}

		//METODO PARA ELIMINAR registro guardado
		public bool Eliminar(int id)
		{
			foreach (var item in ListaUsuarios)
			{
				if (item.Id == id)
				{
					ListaUsuarios.Remove(item);
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
}
