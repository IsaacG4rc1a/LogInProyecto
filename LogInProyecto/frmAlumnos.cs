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
using System.Runtime.InteropServices;

namespace LogInProyecto
{
	public partial class frmAlumnos : Form
	{
		public frmAlumnos()
		{
			InitializeComponent();

			var AluBL = new AlumnosBL();
			alumnosListaBindingSource.DataSource = AluBL.ListaAlumno;
			idTextBox.Enabled = false;
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]

		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


		private void frmAlumnos_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void label1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
