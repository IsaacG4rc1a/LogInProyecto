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
	public partial class frmReporteAlumnos : Form
	{
		public frmReporteAlumnos()
		{
			InitializeComponent();

			var _AlumBL = new AlumnosBL();
			var bindingSource = new BindingSource();

			bindingSource.DataSource = _AlumBL.ObtenerAlumnos();

			var Report = new ReporteAlumnos();

			Report.SetDataSource(bindingSource);
			crystalReportViewer1.ReportSource = Report;
			crystalReportViewer1.RefreshReport();
		}
	}
}
