using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.BL
{
    public class UserValidation
    {
		ContextoBD _contexto;

		public UserValidation()
		{
			_contexto = new ContextoBD();
		}

		public Usuarios Validar(string usuario, string contra)
		{
			var usuarios = _contexto.tbUsuarios.ToList();

			foreach (var usuarioDB in usuarios)
			{
				if (usuario == usuarioDB.Usuario && contra == usuarioDB.Contrasenia)
				{
					return usuarioDB;
				}
			}
			return null;
		}
    }
}
