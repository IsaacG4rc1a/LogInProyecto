using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universidad.BL;

namespace LogInProyecto
{
	public partial class frmAsignaturas : Form
	{
		public frmAsignaturas()
		{
			InitializeComponent();
			ListaAsignaturas();
		}

		public void ListaAsignaturas()
		{
			clsAsignaturas asig = new clsAsignaturas();

			dgvAsignaturas.DataSource = asig.ListarAsignaturas();
		}
	}
}
