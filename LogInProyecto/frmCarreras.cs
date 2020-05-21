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
	public partial class frmCarreras : Form
	{

		CarrerasBL _Carrera;


		public frmCarreras()
		{
			InitializeComponent();
			_Carrera = new CarrerasBL();
			carreraBindingSource.DataSource = _Carrera.ObtenerCarreras();
			facultadesBindingSource.DataSource = _Carrera.Obtenerfacultades();
		}

		private void lblCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bindingNavigatorAgregar_Click(object sender, EventArgs e)
		{
			_Carrera.AgregarCarrera();
			carreraBindingSource.MoveLast();
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
			bindingNavigatorEliminar.Enabled = v;
			bindingNavigatorAgregar.Enabled = v;

			toolStripButtonCancelar.Visible = !v;
			carreraBindingNavigatorGuardar.Enabled = !v;

		}

		private void carreraBindingNavigatorGuardar_Click(object sender, EventArgs e)
		{
			carreraBindingSource.EndEdit();

			var Carreras = (Carrera)carreraBindingSource.Current;
			var Resultado = _Carrera.Guardar(Carreras);
			if (Resultado.Exitoso == true)
			{
				carreraBindingSource.ResetBindings(false);
				ActivarDesactivarBotones(true);
				MessageBox.Show("El registro se agregó corecctamente.");
			}
			else
			{
				MessageBox.Show(Resultado.Mensaje);
			}
		}

		private void bindingNavigatorEliminar_Click(object sender, EventArgs e)
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
		}

		//Metodo para eliminar registro
		private void EliminarLinea(int id)
		{
			var Resultado = _Carrera.Eliminar(id);
			if (Resultado == true)
			{
				carreraBindingSource.ResetBindings(false);
			}
		}

		private void toolStripButtonCancelar_Click(object sender, EventArgs e)
		{
			ActivarDesactivarBotones(true);
			EliminarLinea(0);
		}
	}
}
