namespace LogInProyecto
{
	partial class frmReporteMatricula
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.crystalReportViewerMatricula = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			// 
			// crystalReportViewerMatricula
			// 
			this.crystalReportViewerMatricula.ActiveViewIndex = -1;
			this.crystalReportViewerMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewerMatricula.Cursor = System.Windows.Forms.Cursors.Default;
			this.crystalReportViewerMatricula.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewerMatricula.Location = new System.Drawing.Point(0, 0);
			this.crystalReportViewerMatricula.Name = "crystalReportViewerMatricula";
			this.crystalReportViewerMatricula.ShowGroupTreeButton = false;
			this.crystalReportViewerMatricula.Size = new System.Drawing.Size(607, 491);
			this.crystalReportViewerMatricula.TabIndex = 0;
			this.crystalReportViewerMatricula.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
			// 
			// frmReporteMatricula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(607, 491);
			this.Controls.Add(this.crystalReportViewerMatricula);
			this.Name = "frmReporteMatricula";
			this.Text = "Reporte de Matricula";
			this.Load += new System.EventHandler(this.frmReporteMatricula_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerMatricula;
	}
}