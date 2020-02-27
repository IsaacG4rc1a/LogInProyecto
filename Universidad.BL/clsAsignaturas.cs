using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.BL
{
	public class clsAsignaturas
	{
		private Conexion conex = new Conexion();
		private SqlCommand comando = new SqlCommand();
		private SqlDataReader leerAsiganturas;

		public DataTable ListarAsignaturas()
		{
			DataTable tabla = new DataTable();
			comando.Connection = conex.AbrirConec();
			comando.CommandText = "listaAsignaturas";
			comando.CommandType = CommandType.StoredProcedure;
			leerAsiganturas = comando.ExecuteReader();
			tabla.Load(leerAsiganturas);
			leerAsiganturas.Close();
			conex.CerrarConec();
			return tabla;
		}
	}
}
