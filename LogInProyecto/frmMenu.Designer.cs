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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
			this.BarraTitulo = new System.Windows.Forms.Panel();
			this.btnMin = new System.Windows.Forms.PictureBox();
			this.btnCerrar = new System.Windows.Forms.PictureBox();
			this.MenuVertical = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCerrarSesion = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Logo = new System.Windows.Forms.PictureBox();
			this.btnAsignaturas = new System.Windows.Forms.Button();
			this.PanelContenedor = new System.Windows.Forms.Panel();
			this.BarraTitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
			this.MenuVertical.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
			this.SuspendLayout();
			// 
			// BarraTitulo
			// 
			this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
			this.BarraTitulo.Controls.Add(this.btnMin);
			this.BarraTitulo.Controls.Add(this.btnCerrar);
			this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
			this.BarraTitulo.Name = "BarraTitulo";
			this.BarraTitulo.Size = new System.Drawing.Size(1008, 35);
			this.BarraTitulo.TabIndex = 0;
			this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDowm);
			// 
			// btnMin
			// 
			this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
			this.btnMin.Location = new System.Drawing.Point(943, 5);
			this.btnMin.Name = "btnMin";
			this.btnMin.Size = new System.Drawing.Size(25, 25);
			this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnMin.TabIndex = 1;
			this.btnMin.TabStop = false;
			this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.Location = new System.Drawing.Point(974, 5);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(25, 25);
			this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnCerrar.TabIndex = 0;
			this.btnCerrar.TabStop = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// MenuVertical
			// 
			this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.MenuVertical.Controls.Add(this.panel2);
			this.MenuVertical.Controls.Add(this.btnCerrarSesion);
			this.MenuVertical.Controls.Add(this.panel1);
			this.MenuVertical.Controls.Add(this.Logo);
			this.MenuVertical.Controls.Add(this.btnAsignaturas);
			this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuVertical.Location = new System.Drawing.Point(0, 35);
			this.MenuVertical.Name = "MenuVertical";
			this.MenuVertical.Size = new System.Drawing.Size(169, 530);
			this.MenuVertical.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.panel2.Location = new System.Drawing.Point(2, 443);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(8, 32);
			this.panel2.TabIndex = 4;
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
			this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrarSesion.ForeColor = System.Drawing.Color.Transparent;
			this.btnCerrarSesion.Location = new System.Drawing.Point(8, 443);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(161, 32);
			this.btnCerrarSesion.TabIndex = 3;
			this.btnCerrarSesion.Text = "Cerrar sesión";
			this.btnCerrarSesion.UseVisualStyleBackColor = false;
			this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.panel1.Location = new System.Drawing.Point(2, 97);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(8, 32);
			this.panel1.TabIndex = 2;
			// 
			// Logo
			// 
			this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
			this.Logo.Location = new System.Drawing.Point(0, 0);
			this.Logo.Name = "Logo";
			this.Logo.Size = new System.Drawing.Size(169, 95);
			this.Logo.TabIndex = 1;
			this.Logo.TabStop = false;
			// 
			// btnAsignaturas
			// 
			this.btnAsignaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.btnAsignaturas.FlatAppearance.BorderSize = 0;
			this.btnAsignaturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.btnAsignaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAsignaturas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAsignaturas.ForeColor = System.Drawing.Color.Transparent;
			this.btnAsignaturas.Location = new System.Drawing.Point(8, 97);
			this.btnAsignaturas.Name = "btnAsignaturas";
			this.btnAsignaturas.Size = new System.Drawing.Size(161, 32);
			this.btnAsignaturas.TabIndex = 0;
			this.btnAsignaturas.Text = "Alumnos";
			this.btnAsignaturas.UseVisualStyleBackColor = false;
			this.btnAsignaturas.Click += new System.EventHandler(this.btnAsignaturas_Click);
			// 
			// PanelContenedor
			// 
			this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanelContenedor.Location = new System.Drawing.Point(169, 35);
			this.PanelContenedor.Name = "PanelContenedor";
			this.PanelContenedor.Size = new System.Drawing.Size(839, 530);
			this.PanelContenedor.TabIndex = 2;
			// 
			// frmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 565);
			this.Controls.Add(this.PanelContenedor);
			this.Controls.Add(this.MenuVertical);
			this.Controls.Add(this.BarraTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SISTEMA DE MATRICULA";
			this.Load += new System.EventHandler(this.frmMenu_Load);
			this.BarraTitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
			this.MenuVertical.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel BarraTitulo;
		private System.Windows.Forms.Panel MenuVertical;
		private System.Windows.Forms.PictureBox btnCerrar;
		private System.Windows.Forms.PictureBox btnMin;
		private System.Windows.Forms.PictureBox Logo;
		private System.Windows.Forms.Button btnAsignaturas;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnCerrarSesion;
		private System.Windows.Forms.Panel PanelContenedor;
	}
}

