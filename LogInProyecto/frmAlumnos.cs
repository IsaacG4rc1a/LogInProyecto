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
using System.IO;

namespace LogInProyecto
{
	public partial class frmAlumnos : Form
	{

		AlumnosBL _Alumnos;
		EstadoCivilBL _EstadoCivil;

		public frmAlumnos()
		{
			InitializeComponent();
			_Alumnos = new AlumnosBL();
			alumnosListaBindingSource.DataSource = _Alumnos.ObtenerAlumnos();

			_EstadoCivil = new EstadoCivilBL();
			estadoCivilBindingSource.DataSource = _EstadoCivil.ObtenerEC();

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
		//Cerrar formulario Menu
		private void label1_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		//Añadir campo nuevo a la lista
		private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
		{
			_Alumnos.AgregarAlumnos();
			alumnosListaBindingSource.MoveLast();

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

			toolStripButtonCancelar.Visible = !v;
			toolStripButton1.Enabled = !v;

		}

		//Guardar cambios
		private void toolStripButton1_Click_1(object sender, EventArgs e)
		{
			alumnosListaBindingSource.EndEdit();
			var Alumnos = (AlumnosLista)alumnosListaBindingSource.Current;

			if (fotoPictureBox.Image != null)
			{
				Alumnos.Foto = Program.imageToArray(fotoPictureBox.Image); 
			}
			else
			{
				fotoPictureBox.Image = null;
			}

			var Resultado = _Alumnos.Guardar(Alumnos);

			if (Resultado.Exitoso == true)
			{
				alumnosListaBindingSource.ResetBindings(false);
				ActivarDesactivarBotones(true);
				MessageBox.Show("El registro se agregó correctamente.");
			}
			else
			{
				MessageBox.Show(Resultado.Mensaje);
			}
		}

		//Llamada al metodo eliminar
		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
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
			else
			{
				MessageBox.Show("No existen registros.");
			}
		}
		//Metodo para eliminar registro
		private void EliminarLinea(int id)
		{
			var Resultado = _Alumnos.Eliminar(id);
			if (Resultado == true)
			{
				alumnosListaBindingSource.ResetBindings(false);
			}
		}

		//Cancelar registro nuevo 
		private void toolStripButtonCancelar_Click(object sender, EventArgs e)
		{
			ActivarDesactivarBotones(true);
			EliminarLinea(0);
		}

        private void frmAlumnos_Load(object sender, EventArgs e)
        {

        }

		private void btnAgregarFoto_Click(object sender, EventArgs e) /////// FALTAN CORRECCIONES
		{
			var Alumno = (AlumnosLista)alumnosListaBindingSource.Current;

			if (Alumno != null)
			{
				ofpElegirFoto.ShowDialog();
				var Archivo = ofpElegirFoto.FileName;

				if (Archivo != "")
				{
					var fileInfo = new FileInfo(Archivo);
					var fileStream = fileInfo.OpenRead();

					fotoPictureBox.Image = Image.FromStream(fileStream);
				}
			}
			else
			{
				MessageBox.Show("Cree un registro antes de asignar la imagen.", "Advertencia");
			}
		}

		///FIN CORRECCIONES 

		private void btnQuitarFoto_Click(object sender, EventArgs e) ////FALTAN CORRECIONES GUARDAR FOTO NULA
		{
			fotoPictureBox.Image = null;
		}
	}
}
