using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInProyecto
{
	public partial class frmMenu : Form
	{
		frmLogIn frmLogin = new frmLogIn();
		public frmMenu()
		{
			InitializeComponent();
		}

		private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frmDocentes = new frmRegistroDocentes();
			frmDocentes.Show();
		}

		private void frmMenu_Load(object sender, EventArgs e)
		{
			
		}

		private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frmAsig = new frmAsignaturas();
			frmAsig.Show();
		}

		private void logInToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			frmLogin.Show();
		}
	}
}
