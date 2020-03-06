using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.BL
{
    public class Contexto: DbContext    
    {
        public Contexto():base ("Universidad")//Constructor
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<AlumnosLista> tbAlumnos { get; set; }//lista de base de datos
    }
}
