using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LogInProyecto
{
	public partial class frmMenu : Form
	{
		public frmMenu()
		{
			InitializeComponent();
		}

		private void frmMenu_Load(object sender, EventArgs e)
		{
			
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


		private void btnMin_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnAsignaturas_Click(object sender, EventArgs e)
		{
			frmAlumnos alum = new frmAlumnos();
			alum.ShowDialog();
		}

		private void btnCerrarSesion_Click(object sender, EventArgs e)
		{
			frmLogIn frmLogin = new frmLogIn();
			this.Hide();
			frmLogin.Show();
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]

		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private void BarraTitulo_MouseDowm(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
	}
}
