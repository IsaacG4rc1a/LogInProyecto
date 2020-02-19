using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.BL
{
	public class AlumnosBL
	{
		public List<AlumnosLista> ListaAlumno { get; set; }

		public AlumnosBL()
		{
			ListaAlumno = new List<AlumnosLista>();
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
	}
}
