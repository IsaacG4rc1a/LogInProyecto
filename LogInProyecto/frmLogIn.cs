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

namespace LogInProyecto
{
	public partial class frmLogIn : Form
	{
		public frmLogIn()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			frmMenu menu = new frmMenu();
			if (textBox1.Text == "User" && textBox2.Text == "123")
			{
				menu.Show();

			}
			else
			{
				if (textBox1.Text == "caja" && textBox2.Text == "123")
				{
					menu.Show();
					this.Visible = false;
				}
				else
				{
					MessageBox.Show("Usuario ó contraseña inválida.");
				}
			}
		}

		private void frmLogIn_Load(object sender, EventArgs e)
		{
			textBox1.AutoSize = false;
			textBox1.Size = new Size(326, 35);

			textBox2.AutoSize = false;
			textBox2.Size = new Size(326, 35);
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

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
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//Boton Minimizar
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		
	}
}
