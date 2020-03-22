using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.BL
{
	public class AlumnosLista
	{
		public int Id { get; set; }
		public string Nombres { get; set; }
		public string Apellidos { get; set; }
		public string Sexo { get; set; }
		public int EstadoCivilId { get; set; }
		public EstadoCivil EstadoCivil { get; set; }
		public string Telefono { get; set; }
		public string Direccion { get; set; } 
		public byte[] Foto { get; set; }
		public bool Activo { get; set; }

		public AlumnosLista()
		{
			Activo = true;
		}
	}
}
