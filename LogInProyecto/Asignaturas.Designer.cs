namespace LogInProyecto
{
	partial class frmAsignaturas
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
			this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAsignaturas
			// 
			this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAsignaturas.Location = new System.Drawing.Point(44, 65);
			this.dgvAsignaturas.Name = "dgvAsignaturas";
			this.dgvAsignaturas.Size = new System.Drawing.Size(277, 182);
			this.dgvAsignaturas.TabIndex = 0;
			// 
			// frmAsignaturas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(717, 353);
			this.Controls.Add(this.dgvAsignaturas);
			this.Name = "frmAsignaturas";
			this.Text = "Asignaturas";
			((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAsignaturas;
	}
}