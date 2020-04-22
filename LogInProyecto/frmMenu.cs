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
			OcultarMenus();
		}

		private void frmMenu_Load(object sender, EventArgs e)
		{
			Login();
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
			frmAsignaturas frmAsig = new frmAsignaturas();
			frmAsig.ShowDialog();
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

		private void btnSalir_Click(object sender, EventArgs e)
		{
			frmLogIn frmLogin = new frmLogIn();
			this.Hide();
			frmLogin.Show();
		}

		private void lblSalir_Click(object sender, EventArgs e)
		{
			frmLogIn frmLogin = new frmLogIn();
			this.Hide();
			frmLogin.Show();
		}

		private void btnAlumnos_Click(object sender, EventArgs e)
		{
			OcultarMenus();
			AbrirfrmHijo(new frmAlumnos());
		}

		//#1 Bloque de código para mostrar y ocultar los sub menus
		private void OcultarMenus()
		{
			panelMantenimiento.Visible = false;
			panelReportes.Visible = false;
			panelSeguridad.Visible = false;
		}

		private void cerarSubmenus()
		{
			if (panelMantenimiento.Visible == true)
			{
				panelMantenimiento.Visible = false;
			}
			if (panelReportes.Visible == true)
			{
				panelMantenimiento.Visible = false;
			}
			if (panelSeguridad.Visible == true)
			{
				panelMantenimiento.Visible = false;
			}
		}

		private void MostarSubMenu(Panel SubMenu)
		{
			if (SubMenu.Visible == false)
			{
				OcultarMenus();
				SubMenu.Visible = true;
			}
			else
			{
				SubMenu.Visible = false;
			}
		}

		private void btnMantenimiento_Click(object sender, EventArgs e)
		{
			MostarSubMenu(panelMantenimiento);
		}

		private void btnSeguridad_Click(object sender, EventArgs e)
		{
			MostarSubMenu(panelSeguridad);
		}

		private void btnReportes_Click(object sender, EventArgs e)
		{
			MostarSubMenu(panelReportes);
		}
		//#1 Final 

		//#2 Bloque de código para abrir un  formulario dentro de otro.
		private Form FrmActivo = null;
		private void AbrirfrmHijo(Form frmHijo)
		{
			if (FrmActivo != null)
				FrmActivo.Close();
			FrmActivo = frmHijo;
			frmHijo.TopLevel = false;
			frmHijo.Dock = DockStyle.Fill;
			PanelContenedor.Controls.Add(frmHijo);
			PanelContenedor.Tag = frmHijo;
			frmHijo.BringToFront();
			frmHijo.Show();
		}

		private void btnDocentes_Click(object sender, EventArgs e)
		{

		}

		private void btnMatricula_Click(object sender, EventArgs e)
		{
			OcultarMenus();
			AbrirfrmHijo(new frmMatricula());
		}

		private void btnReportAlumnos_Click(object sender, EventArgs e)
		{
			OcultarMenus();
			frmReporteAlumnos reportA = new frmReporteAlumnos();
			reportA.ShowDialog();
		}

		private void btnReportMatricula_Click(object sender, EventArgs e)
		{
			OcultarMenus();
			frmReporteMatricula reportM = new frmReporteMatricula();
			reportM.ShowDialog();
		}

		private void btnUsuarios_Click(object sender, EventArgs e)
		{
			OcultarMenus();
			AbrirfrmHijo(new frmUsuarios());
		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			
		}

		private void Login()
		{
			if (Program.UsuarioLogueado != null)
			{
				var Nombre = Program.UsuarioLogueado.Usuario.ToUpper();
				toolStripStatusLabel1.Text = "Usuario: " + Nombre;
			}
		}
		// Final #2


	}
}
