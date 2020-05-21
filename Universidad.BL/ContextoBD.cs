using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Universidad.BL
{
	public class ContextoBD : DbContext
	{
		public ContextoBD() : base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" +
			Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Universidad")
		{

		}
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			Database.SetInitializer(new DatosDeInicio());
		}

		public DbSet<AlumnosLista> tbAlumnos { get; set; }
		public DbSet<EstadoCivil> tbEstadoCivil { get; set; }
		public DbSet<AsignaturasLista> tbAsignaturas { get; set; }
		public DbSet<DocentesLista> tbDocentes { get; set; }
		public DbSet<MatriculaAsignaturas> tbMatricula { get; set; }
		public DbSet<Usuarios> tbUsuarios { get; set; }
		public	DbSet<Carrera> tbCarreras { get; set; }
		public DbSet<Facultades> tbFacultades { get; set; }
	}
}
