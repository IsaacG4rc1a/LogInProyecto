using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Universidad.BL
{
	public class Conexion
	{

		static private string Conec = "server=DESKTOP-0SD9P5K; database=UNIVERSIDAD; integrated security= true";
		SqlConnection cnx = new SqlConnection(Conec);

		public SqlConnection AbrirConec()
		{
			if (cnx.State == ConnectionState.Closed)
				cnx.Open();
				return cnx;
		}

		public SqlConnection CerrarConec()
		{
			if (cnx.State == ConnectionState.Open)
				cnx.Close();
				return cnx;
		}
	}
}
