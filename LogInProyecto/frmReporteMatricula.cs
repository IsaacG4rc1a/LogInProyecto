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
			var bindingSource = new BindingSource();

			bindingSource.DataSource = _Matri.ObtenerMatricula();

			var Report = new ReporteMatricula();

			Report.SetDataSource(bindingSource);
			crystalReportViewerMatricula.ReportSource = Report;
			crystalReportViewerMatricula.RefreshReport();
		}

		private void frmReporteMatricula_Load(object sender, EventArgs e)
		{

		}
	}
}
