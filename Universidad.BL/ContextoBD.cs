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
			Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Universidad.mdf")
		{

		}
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}

		public DbSet<AlumnosLista> tbAlumnos { get; set; }
	}
}
