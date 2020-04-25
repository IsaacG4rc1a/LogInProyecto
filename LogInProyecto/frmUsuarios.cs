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
	public partial class frmUsuarios : Form
	{
		UsuariosBL _userBL;

		public frmUsuarios()
		{
			InitializeComponent();

			_userBL = new UsuariosBL();

			usuariosBindingSource.DataSource = _userBL.ObtenerUsuarios(); //Obtener listado en datagrid
		}

		private void label1_Click(object sender, EventArgs e) //Cerrar formulario hijo
		{
			this.Close();
		}

		//Agregar Usuario
		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			_userBL.AgregarUsuarios();
			usuariosBindingSource.MoveLast();
			ActivarDesactivarBotones(false);
		}

		//Habilitar y deshabilitar botones 
		private void ActivarDesactivarBotones(bool v)
		{
			bindingNavigatorMoveFirstItem.Enabled = v;
			bindingNavigatorCountItem.Enabled = v;
			bindingNavigatorMoveLastItem.Enabled = v;
			bindingNavigatorMoveNextItem.Enabled = v;
			bindingNavigatorMovePreviousItem.Enabled = v;
			bindingNavigatorPositionItem.Enabled = v;
			bindingNavigatorDeleteItem.Enabled = v;
			bindingNavigatorAddNewItem.Enabled = v;

			toolStripButton1.Visible = !v;
			usuariosBindingNavigatorSaveItem.Enabled = !v;

		}

		//Guardar Usuario
		private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			usuariosBindingSource.EndEdit();

			var Users = (Usuarios)usuariosBindingSource.Current;

			var Resultado = _userBL.Guardar(Users);

			if (Resultado.Exitoso == true)
			{
				usuariosBindingSource.ResetBindings(false);
				ActivarDesactivarBotones(true);
				MessageBox.Show("El registro se agregó correctamente.");
			}
			else
			{
				MessageBox.Show(Resultado.Mensaje);
			}
		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{
			if (idTextBox.Text != "")
			{
				var resultado = MessageBox.Show("¿Desea eliminar el registro '" + usuarioTextBox.Text +  "'?", "Eliminar", MessageBoxButtons.YesNo);
				if (resultado == DialogResult.Yes)
				{
					var Id = int.Parse(idTextBox.Text);
					EliminarLinea(Id);
				}
			}
		}

		//Metodo para eliminar registro
		private void EliminarLinea(int id)
		{
			var Resultado = _userBL.Eliminar(id);
			if (Resultado == true)
			{
				usuariosBindingSource.ResetBindings(false);
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			ActivarDesactivarBotones(true);
			EliminarLinea(0);
		}

		private void contraseniaTextBox_TextChanged(object sender, EventArgs e)
		{
			contraseniaTextBox.UseSystemPasswordChar = true;
		}
	}
}
