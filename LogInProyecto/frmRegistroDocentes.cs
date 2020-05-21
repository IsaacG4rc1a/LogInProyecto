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
	public partial class frmRegistroDocentes : Form
	{
		DocentesBL _DocenteBL;
		EstadoCivilBL _EstadoC;
		CarrerasBL FacultadBL;

		public frmRegistroDocentes()
		{
			InitializeComponent();
			_DocenteBL = new DocentesBL();
			docentesListaBindingSource.DataSource = _DocenteBL.ObtenerDocentes();

			_EstadoC = new EstadoCivilBL();
			estadoCivilBindingSource.DataSource = _EstadoC.ObtenerEC();

			FacultadBL = new CarrerasBL();
			facultadesBindingSource.DataSource = FacultadBL.Obtenerfacultades();
		}

		private void lblCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bindingNavigatorAgregar_Click(object sender, EventArgs e)
		{
			_DocenteBL.AgregarDocente();
			docentesListaBindingSource.MoveLast();

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

			toolStripLabelCancelar.Visible = !v;
			docentesListaBindingNavigatorGuardar.Enabled = !v;
		}

		private void docentesListaBindingNavigatorGuardar_Click(object sender, EventArgs e)
		{

			docentesListaBindingSource.EndEdit();
			var Docente = (DocentesLista)docentesListaBindingSource.Current;
			string sexo = cbSexo.Text;
			Docente.Sexo = sexo;

			var Resultado = _DocenteBL.Guardar(Docente);
			if (Resultado.Exitoso == true)
			{
				docentesListaBindingSource.ResetBindings(false);
				ActivarDesactivarBotones(true);
				MessageBox.Show("El registro se guardó correctamente.");
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
				var resultado = MessageBox.Show("¿Desea eliminar el registro '" + nombresTextBox.Text + " " + apellidosTextBox.Text + "'?", "Eliminar", MessageBoxButtons.YesNo);
				if (resultado == DialogResult.Yes)
				{
					var Id = int.Parse(idTextBox.Text);
					EliminarLinea(Id);
				}
			}
			else if(idTextBox.Text == "")
			{
				MessageBox.Show("No hay registros que eliminar");
			}
		}

		//Metodo para eliminar registro
		private void EliminarLinea(int id)
		{
			var Resultado = _DocenteBL.Eliminar(id);
			if (Resultado == true)
			{
				docentesListaBindingSource.ResetBindings(false);
			}
		}

		private void toolStripLabelCancelar_Click(object sender, EventArgs e)
		{
			ActivarDesactivarBotones(true);
			EliminarLinea(0);
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			var busqueda = txtBusqueda.Text;

			if (string.IsNullOrEmpty(busqueda) == true)
			{
				docentesListaBindingSource.DataSource = _DocenteBL.ObtenerDocentes();
			}
			else
			{
				docentesListaBindingSource.DataSource = _DocenteBL.ObtenerDocentesBusqueda(busqueda);
			}

			docentesListaBindingSource.ResetBindings(false);
		}
	}
}
