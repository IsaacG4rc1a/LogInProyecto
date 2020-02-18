using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.BL
{
    public class UserValidation
    {
		List<Usuarios> ListaUsuarios;

		public UserValidation()
		{
			ListaUsuarios = new List<Usuarios>();

			var Usuario = new Usuarios();

			Usuario.Id = 1;
			Usuario.Usuario = "admin";
			Usuario.Contrasenia = "123";

			ListaUsuarios.Add(Usuario);

			var Usuario2 = new Usuarios();

			Usuario2.Id = 1;
			Usuario2.Usuario = "supervisor";
			Usuario2.Contrasenia = "123";

			ListaUsuarios.Add(Usuario2);
		}

		public bool Validar(string usuario, string contra)
		{
			foreach (var u in ListaUsuarios)
			{
				if (u.Usuario == usuario && u.Contrasenia == contra)
				{
					return true;
				}
			}
			return false;
		}
    }
}
