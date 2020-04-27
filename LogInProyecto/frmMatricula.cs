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
	public partial class frmMatricula : Form
	{
		MatriculaBL _matriculaBL;
		AlumnosBL _alumnoBL;
		DocentesBL _docenteBL;
		AsignaturasBL _asignaturasBL;

		public frmMatricula()
		{
			InitializeComponent();

			_matriculaBL = new MatriculaBL();
			matriculaAsignaturasBindingSource.DataSource = _matriculaBL.ObtenerMatricula();

			_alumnoBL = new AlumnosBL();
			alumnosListaBindingSource.DataSource = _alumnoBL.ObtenerAlumnos();

			_docenteBL = new DocentesBL();
			docentesListaBindingSource.DataSource = _docenteBL.ObtenerDocentes();

			_asignaturasBL = new AsignaturasBL();
			asignaturasListaBindingSource.DataSource = _asignaturasBL.ObtenerAsignaturas();

			var Matricula = (MatriculaAsignaturas)matriculaAsignaturasBindingSource.Current;
			AnularFacura(Matricula);
		}

		private void label1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void bindingNavigatorAddNewMatricula_Click(object sender, EventArgs e)
		{
			alumnoIdComboBox.Enabled = true;
			_matriculaBL.AgregarMatricula();
			matriculaAsignaturasBindingSource.MoveLast();

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
			bindingNavigatorDeleteMatricula.Enabled = v;
			bindingNavigatorAddNewMatricula.Enabled = v;

			toolStripCancelar.Visible = !v;
			matriculaAsignaturasBindingNavigatorSaveItem.Enabled = !v;

		}

		private void matriculaAsignaturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			matriculaAsignaturasBindingSource.EndEdit();

			var Matricula = (MatriculaAsignaturas)matriculaAsignaturasBindingSource.Current;

			var resultado = _matriculaBL.Guardar(Matricula);

			if (resultado.Exitoso == true)
			{
				matriculaAsignaturasBindingSource.ResetBindings(false);
				ActivarDesactivarBotones(true);
				MessageBox.Show(resultado.Mensaje);
				alumnoIdComboBox.Enabled = false;
			}
			else
			{
				MessageBox.Show(resultado.Mensaje);
			}
		}

		private void toolStripCancelar_Click(object sender, EventArgs e)
		{
			ActivarDesactivarBotones(true);
			_matriculaBL.CancelarCambios();
		}

		private void btnAggDetalle_Click(object sender, EventArgs e)
		{
			var Matricula = (MatriculaAsignaturas)matriculaAsignaturasBindingSource.Current;

			_matriculaBL.AgregarMatriculaDetalle(Matricula);
			ActivarDesactivarBotones(false);
		}

		private void btnDeleteDetalle_Click(object sender, EventArgs e)
		{
			var Matricula = (MatriculaAsignaturas)matriculaAsignaturasBindingSource.Current;

			var MatriculaDet = (MatriculaAsignaturasDetalle)matriculaDetalleBindingSource.Current;

			_matriculaBL.RemoverMatriculaDetalle(Matricula, MatriculaDet);
			ActivarDesactivarBotones(false);
		}

		private void matriculaDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			e.ThrowException = false;
		}

		private void bindingNavigatorDeleteMatricula_Click(object sender, EventArgs e)
		{
			var Matricula = (MatriculaAsignaturas)matriculaAsignaturasBindingSource.Current;

			if (Matricula == null)
			{
				MessageBox.Show("No hay registros para anular");
			}

			if (Matricula != null && Matricula.Id != 0 && Matricula.Activo == false)
			{
				var resultado = MessageBox.Show("La matricula ya está anulada");
			}
			if(Matricula != null && Matricula.Id != 0 && Matricula.Activo == true)
			{
				var Nombre = alumnoIdComboBox.Text;
				var resultado = MessageBox.Show("Desea anular la matricula de " + Nombre + "?", "Aviso", MessageBoxButtons.YesNo);
				if (resultado == DialogResult.Yes)
				{
					var id = Convert.ToInt16(idTextBox.Text);
					Anular(id);
				}
			}
		}

		private void Anular(int id)
		{
			var Anular = _matriculaBL.AnularMatricula(id);
			if (Anular == true)
			{
				matriculaAsignaturasBindingSource.ResetBindings(false);
			}
			else
			{
				MessageBox.Show("No se anuló la matricula.");
			}
		}

		private void matriculaAsignaturasBindingSource_CurrentChanged(object sender, EventArgs e)
		{
			var Matricula = (MatriculaAsignaturas)matriculaAsignaturasBindingSource.Current;
			AnularFacura(Matricula);
		}

		private void AnularFacura(MatriculaAsignaturas Matricula)
		{
			if (Matricula == null)
			{
				lblVacio.Visible = true;
				lblActiva.Visible = false;
				lblCANCELADA.Visible = false;
			}

			if (Matricula != null && Matricula.Id != 0 && Matricula.Activo == false)
			{
				lblCANCELADA.Visible = true;
				lblActiva.Visible = false;
				lblVacio.Visible = false;
			}

			if (Matricula != null &&  Matricula.Activo == true)
			{
				lblCANCELADA.Visible = false;
				lblActiva.Visible = true;
				lblVacio.Visible = false;
			}
		}

		private void btnBusqueda_Click(object sender, EventArgs e)
		{
			//var busqueda = txtBusqueda.Text;
			//var nombre = alumnoIdComboBox.Text;

			//if (string.IsNullOrEmpty(busqueda) == true)
			//{
			//	matriculaAsignaturasBindingSource.DataSource = _matriculaBL.ObtenerMatricula();
			//}
			//else
			//{
			//	matriculaAsignaturasBindingSource.DataSource = _matriculaBL.ObtenerMatriculas(busqueda);
			//}
		}
	}
}
