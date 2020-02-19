namespace LogInProyecto
{
	partial class frmAlumnos
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label activoLabel;
			System.Windows.Forms.Label apellidosLabel;
			System.Windows.Forms.Label direccionLabel;
			System.Windows.Forms.Label estadoCivilLabel;
			System.Windows.Forms.Label idLabel;
			System.Windows.Forms.Label nombresLabel;
			System.Windows.Forms.Label sexoLabel;
			System.Windows.Forms.Label telefonoLabel;
			System.Windows.Forms.Label label2;
			this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ListaAlumnosDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.alumnosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.activoCheckBox = new System.Windows.Forms.CheckBox();
			this.apellidosTextBox = new System.Windows.Forms.TextBox();
			this.direccionTextBox = new System.Windows.Forms.TextBox();
			this.estadoCivilTextBox = new System.Windows.Forms.TextBox();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.nombresTextBox = new System.Windows.Forms.TextBox();
			this.sexoTextBox = new System.Windows.Forms.TextBox();
			this.telefonoTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			activoLabel = new System.Windows.Forms.Label();
			apellidosLabel = new System.Windows.Forms.Label();
			direccionLabel = new System.Windows.Forms.Label();
			estadoCivilLabel = new System.Windows.Forms.Label();
			idLabel = new System.Windows.Forms.Label();
			nombresLabel = new System.Windows.Forms.Label();
			sexoLabel = new System.Windows.Forms.Label();
			telefonoLabel = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ListaAlumnosDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosListaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// ListaAlumnosDataGridView
			// 
			this.ListaAlumnosDataGridView.AutoGenerateColumns = false;
			this.ListaAlumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ListaAlumnosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
			this.ListaAlumnosDataGridView.DataSource = this.alumnosListaBindingSource;
			this.ListaAlumnosDataGridView.Location = new System.Drawing.Point(12, 239);
			this.ListaAlumnosDataGridView.Name = "ListaAlumnosDataGridView";
			this.ListaAlumnosDataGridView.Size = new System.Drawing.Size(840, 220);
			this.ListaAlumnosDataGridView.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombres";
			this.dataGridViewTextBoxColumn2.HeaderText = "Nombres";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellidos";
			this.dataGridViewTextBoxColumn3.HeaderText = "Apellidos";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Sexo";
			this.dataGridViewTextBoxColumn4.HeaderText = "Sexo";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "EstadoCivil";
			this.dataGridViewTextBoxColumn5.HeaderText = "EstadoCivil";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Telefono";
			this.dataGridViewTextBoxColumn6.HeaderText = "Telefono";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Direccion";
			this.dataGridViewTextBoxColumn7.HeaderText = "Direccion";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
			this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			// 
			// alumnosListaBindingSource
			// 
			this.alumnosListaBindingSource.DataSource = typeof(Universidad.BL.AlumnosLista);
			// 
			// activoLabel
			// 
			activoLabel.AutoSize = true;
			activoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			activoLabel.ForeColor = System.Drawing.Color.Transparent;
			activoLabel.Location = new System.Drawing.Point(275, 194);
			activoLabel.Name = "activoLabel";
			activoLabel.Size = new System.Drawing.Size(54, 17);
			activoLabel.TabIndex = 1;
			activoLabel.Text = "Activo:";
			// 
			// activoCheckBox
			// 
			this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.alumnosListaBindingSource, "Activo", true));
			this.activoCheckBox.Location = new System.Drawing.Point(369, 191);
			this.activoCheckBox.Name = "activoCheckBox";
			this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
			this.activoCheckBox.TabIndex = 2;
			this.activoCheckBox.UseVisualStyleBackColor = true;
			// 
			// apellidosLabel
			// 
			apellidosLabel.AutoSize = true;
			apellidosLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			apellidosLabel.ForeColor = System.Drawing.Color.Transparent;
			apellidosLabel.Location = new System.Drawing.Point(42, 169);
			apellidosLabel.Name = "apellidosLabel";
			apellidosLabel.Size = new System.Drawing.Size(70, 17);
			apellidosLabel.TabIndex = 3;
			apellidosLabel.Text = "Apellidos:";
			// 
			// apellidosTextBox
			// 
			this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosListaBindingSource, "Apellidos", true));
			this.apellidosTextBox.Location = new System.Drawing.Point(120, 166);
			this.apellidosTextBox.Name = "apellidosTextBox";
			this.apellidosTextBox.Size = new System.Drawing.Size(104, 20);
			this.apellidosTextBox.TabIndex = 4;
			// 
			// direccionLabel
			// 
			direccionLabel.AutoSize = true;
			direccionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			direccionLabel.ForeColor = System.Drawing.Color.Transparent;
			direccionLabel.Location = new System.Drawing.Point(42, 195);
			direccionLabel.Name = "direccionLabel";
			direccionLabel.Size = new System.Drawing.Size(73, 17);
			direccionLabel.TabIndex = 5;
			direccionLabel.Text = "Direccion:";
			// 
			// direccionTextBox
			// 
			this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosListaBindingSource, "Direccion", true));
			this.direccionTextBox.Location = new System.Drawing.Point(120, 192);
			this.direccionTextBox.Name = "direccionTextBox";
			this.direccionTextBox.Size = new System.Drawing.Size(104, 20);
			this.direccionTextBox.TabIndex = 6;
			// 
			// estadoCivilLabel
			// 
			estadoCivilLabel.AutoSize = true;
			estadoCivilLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			estadoCivilLabel.ForeColor = System.Drawing.Color.Transparent;
			estadoCivilLabel.Location = new System.Drawing.Point(275, 114);
			estadoCivilLabel.Name = "estadoCivilLabel";
			estadoCivilLabel.Size = new System.Drawing.Size(88, 17);
			estadoCivilLabel.TabIndex = 7;
			estadoCivilLabel.Text = "Estado Civil:";
			// 
			// estadoCivilTextBox
			// 
			this.estadoCivilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosListaBindingSource, "EstadoCivil", true));
			this.estadoCivilTextBox.Location = new System.Drawing.Point(369, 113);
			this.estadoCivilTextBox.Name = "estadoCivilTextBox";
			this.estadoCivilTextBox.Size = new System.Drawing.Size(104, 20);
			this.estadoCivilTextBox.TabIndex = 8;
			// 
			// idLabel
			// 
			idLabel.AutoSize = true;
			idLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			idLabel.ForeColor = System.Drawing.Color.Transparent;
			idLabel.Location = new System.Drawing.Point(42, 117);
			idLabel.Name = "idLabel";
			idLabel.Size = new System.Drawing.Size(24, 17);
			idLabel.TabIndex = 9;
			idLabel.Text = "Id:";
			// 
			// idTextBox
			// 
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosListaBindingSource, "Id", true));
			this.idTextBox.Location = new System.Drawing.Point(120, 114);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(104, 20);
			this.idTextBox.TabIndex = 10;
			// 
			// nombresLabel
			// 
			nombresLabel.AutoSize = true;
			nombresLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nombresLabel.ForeColor = System.Drawing.Color.Transparent;
			nombresLabel.Location = new System.Drawing.Point(42, 143);
			nombresLabel.Name = "nombresLabel";
			nombresLabel.Size = new System.Drawing.Size(70, 17);
			nombresLabel.TabIndex = 11;
			nombresLabel.Text = "Nombres:";
			// 
			// nombresTextBox
			// 
			this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosListaBindingSource, "Nombres", true));
			this.nombresTextBox.Location = new System.Drawing.Point(120, 140);
			this.nombresTextBox.Name = "nombresTextBox";
			this.nombresTextBox.Size = new System.Drawing.Size(104, 20);
			this.nombresTextBox.TabIndex = 12;
			// 
			// sexoLabel
			// 
			sexoLabel.AutoSize = true;
			sexoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			sexoLabel.ForeColor = System.Drawing.Color.Transparent;
			sexoLabel.Location = new System.Drawing.Point(275, 140);
			sexoLabel.Name = "sexoLabel";
			sexoLabel.Size = new System.Drawing.Size(41, 17);
			sexoLabel.TabIndex = 13;
			sexoLabel.Text = "Sexo:";
			// 
			// sexoTextBox
			// 
			this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosListaBindingSource, "Sexo", true));
			this.sexoTextBox.Location = new System.Drawing.Point(369, 139);
			this.sexoTextBox.Name = "sexoTextBox";
			this.sexoTextBox.Size = new System.Drawing.Size(104, 20);
			this.sexoTextBox.TabIndex = 14;
			// 
			// telefonoLabel
			// 
			telefonoLabel.AutoSize = true;
			telefonoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			telefonoLabel.ForeColor = System.Drawing.Color.Transparent;
			telefonoLabel.Location = new System.Drawing.Point(275, 166);
			telefonoLabel.Name = "telefonoLabel";
			telefonoLabel.Size = new System.Drawing.Size(66, 17);
			telefonoLabel.TabIndex = 15;
			telefonoLabel.Text = "Telefono:";
			// 
			// telefonoTextBox
			// 
			this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosListaBindingSource, "Telefono", true));
			this.telefonoTextBox.Location = new System.Drawing.Point(369, 165);
			this.telefonoTextBox.Name = "telefonoTextBox";
			this.telefonoTextBox.Size = new System.Drawing.Size(104, 20);
			this.telefonoTextBox.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(836, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 17);
			this.label1.TabIndex = 17;
			this.label1.Text = "X";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label2.ForeColor = System.Drawing.Color.Transparent;
			label2.Location = new System.Drawing.Point(289, 9);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(270, 33);
			label2.TabIndex = 18;
			label2.Text = "Listado de Alumnos";
			// 
			// frmAlumnos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(864, 530);
			this.Controls.Add(label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(activoLabel);
			this.Controls.Add(this.activoCheckBox);
			this.Controls.Add(apellidosLabel);
			this.Controls.Add(this.apellidosTextBox);
			this.Controls.Add(direccionLabel);
			this.Controls.Add(this.direccionTextBox);
			this.Controls.Add(estadoCivilLabel);
			this.Controls.Add(this.estadoCivilTextBox);
			this.Controls.Add(idLabel);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(nombresLabel);
			this.Controls.Add(this.nombresTextBox);
			this.Controls.Add(sexoLabel);
			this.Controls.Add(this.sexoTextBox);
			this.Controls.Add(telefonoLabel);
			this.Controls.Add(this.telefonoTextBox);
			this.Controls.Add(this.ListaAlumnosDataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAlumnos";
			this.Text = "frmAlumnos";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAlumnos_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ListaAlumnosDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosListaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource alumnosBindingSource;
		private System.Windows.Forms.BindingSource alumnosListaBindingSource;
		private System.Windows.Forms.DataGridView ListaAlumnosDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.CheckBox activoCheckBox;
		private System.Windows.Forms.TextBox apellidosTextBox;
		private System.Windows.Forms.TextBox direccionTextBox;
		private System.Windows.Forms.TextBox estadoCivilTextBox;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox nombresTextBox;
		private System.Windows.Forms.TextBox sexoTextBox;
		private System.Windows.Forms.TextBox telefonoTextBox;
		private System.Windows.Forms.Label label1;
	}
}