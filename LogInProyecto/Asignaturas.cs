using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Universidad.BL;

namespace LogInProyecto
{
	public partial class frmAsignaturas : Form
	{
		AsignaturasBL _AsigBl;
		CarrerasBL _carr;
		public frmAsignaturas()
		{
			InitializeComponent();
			_AsigBl = new AsignaturasBL();
			asignaturasListaBindingSource.DataSource = _AsigBl.ObtenerAsignaturas();

			_carr = new CarrerasBL();

			carreraBindingSource.DataSource = _carr.ObtenerCarreras();
		}

		private void lblCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]

		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{
			_AsigBl.AgregarAsignatura();
			asignaturasListaBindingSource.MoveLast();

			ActivarDesactivarBotones(false);
		}

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

			toolStripLabelCancelar.Visible = !v;
			asignaturasListaBindingNavigatorSaveItem.Enabled = !v;

		}

		private void asignaturasListaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			asignaturasListaBindingSource.EndEdit();
			var Asignatura = (AsignaturasLista)asignaturasListaBindingSource.Current;

			var resultado = _AsigBl.Guardar(Asignatura);

			if (resultado.Exitoso == true)
			{
				asignaturasListaBindingSource.ResetBindings(false);
				ActivarDesactivarBotones(true);
				MessageBox.Show("El registro se agregó correctamente.");
			}
			else
			{
				MessageBox.Show(resultado.Mensaje);
			}
		}

		//Llamada al metodo eliminar
		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{
			if (idTextBox.Text != "")
			{
				var resultado = MessageBox.Show("¿Desea eliminar el registro '" + descripcionTextBox.Text + "'?", "Eliminar", MessageBoxButtons.YesNo);
				if (resultado == DialogResult.Yes)
				{
					var Id = int.Parse(idTextBox.Text);
					EliminarLinea(Id);
				}
			}
			else
			{
				MessageBox.Show("No existen registros.");
			}
		}

		private void EliminarLinea(int id)
		{
			var Resultado = _AsigBl.Eliminar(id);
			if (Resultado == true)
			{
				asignaturasListaBindingSource.ResetBindings(false);
			}
		}

		private void toolStripLabelCancelar_Click(object sender, EventArgs e)
		{
			ActivarDesactivarBotones(true);
			EliminarLinea(0);
		}
	}
}
