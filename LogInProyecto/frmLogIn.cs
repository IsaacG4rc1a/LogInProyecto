using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogInProyecto.Properties;
using System.Runtime.InteropServices;
using Universidad.BL;
using System.Data.Entity;

namespace LogInProyecto
{
	public partial class frmLogIn : Form
	{

		UserValidation _seguridad;
		public frmLogIn()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_seguridad = new UserValidation();

			string User = textBox1.Text;
			string pass = textBox2.Text;
			var usuarioDB = _seguridad.Validar(User, pass);
			

			if (usuarioDB != null)
			{

				Program.UsuarioLogueado = usuarioDB;
				this.Hide();
				Bienvenida b = new Bienvenida();
				b.ShowDialog();

			}
			else
			{
				MessageBox.Show("Usuario ó contraseña inválida.");
			}
		}

		private void frmLogIn_Load(object sender, EventArgs e)
		{
			textBox1.AutoSize = false;
			textBox1.Size = new Size(326, 35);

			textBox2.AutoSize = false;
			textBox2.Size = new Size(326, 35);
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			textBox2.UseSystemPasswordChar = true;
		}

		private void chkPass_CheckedChanged(object sender, EventArgs e)
		{
			string text = textBox2.Text;
			if (chkPass.Checked)
			{
				textBox2.UseSystemPasswordChar = false;
				textBox2.Text = text;

			}
			else
			{
				textBox2.UseSystemPasswordChar = true;
				textBox2.Text = text;
			}
		}

		//Botón cerrar 
		private void pictureBox1_Click(object sender, EventArgs ex)
		{
			Application.Exit();
		}

		//Boton Minimizar
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}


		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]

		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private void Titulo_MouseDown_1(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(Keys.Enter) && !string.IsNullOrEmpty(textBox1.Text))
			{
				textBox2.Focus();
			}
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(Keys.Enter) && !string.IsNullOrEmpty(textBox2.Text))
			{
				button1.PerformClick();
			}
		}
	}
}
