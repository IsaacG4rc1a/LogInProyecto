namespace LogInProyecto
{
	partial class frmMenu
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.registroDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.asignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportesDeMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeDatosToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.seguridadToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(476, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// registroDeDatosToolStripMenuItem
			// 
			this.registroDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docentesToolStripMenuItem,
            this.asignaturasToolStripMenuItem,
            this.alumnosToolStripMenuItem});
			this.registroDeDatosToolStripMenuItem.Name = "registroDeDatosToolStripMenuItem";
			this.registroDeDatosToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
			this.registroDeDatosToolStripMenuItem.Text = "Registro de datos";
			// 
			// docentesToolStripMenuItem
			// 
			this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
			this.docentesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.docentesToolStripMenuItem.Text = "Docentes";
			this.docentesToolStripMenuItem.Click += new System.EventHandler(this.docentesToolStripMenuItem_Click);
			// 
			// asignaturasToolStripMenuItem
			// 
			this.asignaturasToolStripMenuItem.Name = "asignaturasToolStripMenuItem";
			this.asignaturasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.asignaturasToolStripMenuItem.Text = "Asignaturas";
			// 
			// alumnosToolStripMenuItem
			// 
			this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
			this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.alumnosToolStripMenuItem.Text = "Alumnos";
			// 
			// reporteToolStripMenuItem
			// 
			this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeMatriculaToolStripMenuItem});
			this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
			this.reporteToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.reporteToolStripMenuItem.Text = "Reportes";
			// 
			// reportesDeMatriculaToolStripMenuItem
			// 
			this.reportesDeMatriculaToolStripMenuItem.Name = "reportesDeMatriculaToolStripMenuItem";
			this.reportesDeMatriculaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.reportesDeMatriculaToolStripMenuItem.Text = "Reportes de matricula";
			// 
			// seguridadToolStripMenuItem
			// 
			this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.usuariosToolStripMenuItem});
			this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
			this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.seguridadToolStripMenuItem.Text = "Seguridad";
			// 
			// logInToolStripMenuItem
			// 
			this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
			this.logInToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.logInToolStripMenuItem.Text = "LogIn";
			// 
			// usuariosToolStripMenuItem
			// 
			this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
			this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.usuariosToolStripMenuItem.Text = "Usuarios";
			// 
			// frmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(476, 272);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA DE MATRICULA";
			this.Load += new System.EventHandler(this.frmMenu_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem registroDeDatosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem asignaturasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportesDeMatriculaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
	}
}

