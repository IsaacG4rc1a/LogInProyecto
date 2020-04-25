using LogInProyecto.Reports;
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
	public partial class frmReporteMatricula : Form
	{
		public frmReporteMatricula()
		{
			InitializeComponent();
			var _Matri = new MatriculaBL();
			var _Alumno = new AlumnosBL();

			var bindingSource = new BindingSource();
			bindingSource.DataSource = _Matri.ObtenerMatricula();

			var bindingSource2 = new BindingSource();
			bindingSource2.DataSource = _Alumno.ObtenerAlumnos();

			var Report = new ReporteMatricula();
			//da error todavia
			Report.Database.Tables["MatriculaAsignaturas"].SetDataSource(bindingSource);
			Report.Database.Tables["AlumnosLista"].SetDataSource(bindingSource2);

			crystalReportViewerMatricula.ReportSource = Report;
			crystalReportViewerMatricula.RefreshReport();
		}

		private void frmReporteMatricula_Load(object sender, EventArgs e)
		{

		}
	}
}
