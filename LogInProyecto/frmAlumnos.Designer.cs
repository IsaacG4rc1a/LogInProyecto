﻿namespace LogInProyecto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
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
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
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
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			this.SuspendLayout();
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
			this.ListaAlumnosDataGridView.Location = new System.Drawing.Point(51, 245);
			this.ListaAlumnosDataGridView.Name = "ListaAlumnosDataGridView";
			this.ListaAlumnosDataGridView.Size = new System.Drawing.Size(742, 220);
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
			// activoCheckBox
			// 
			this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.alumnosListaBindingSource, "Activo", true));
			this.activoCheckBox.Location = new System.Drawing.Point(369, 191);
			this.activoCheckBox.Name = "activoCheckBox";
			this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
			this.activoCheckBox.TabIndex = 2;
			this.activoCheckBox.UseVisualStyleBackColor = true;
			// 
			// apellidosTextBox
			// 
			this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosListaBindingSource, "Apellidos", true));
			this.apellidosTextBox.Location = new System.Drawing.Point(120, 166);
			this.apellidosTextBox.Name = "apellidosTextBox";
			this.apellidosTextBox.Size = new System.Drawing.Size(104, 20);
			this.apellidosTextBox.TabIndex = 4;
			// 
			// direccionTextBox
			// 
			this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosListaBindingSource, "Direccion", true));
			this.direccionTextBox.Location = new System.Drawing.Point(120, 192);
			this.direccionTextBox.Name = "direccionTextBox";
			this.direccionTextBox.Size = new System.Drawing.Size(104, 20);
			this.direccionTextBox.TabIndex = 6;
			// 
			// estadoCivilTextBox
			// 
			this.estadoCivilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosListaBindingSource, "EstadoCivil", true));
			this.estadoCivilTextBox.Location = new System.Drawing.Point(369, 113);
			this.estadoCivilTextBox.Name = "estadoCivilTextBox";
			this.estadoCivilTextBox.Size = new System.Drawing.Size(104, 20);
			this.estadoCivilTextBox.TabIndex = 8;
			// 
			// idTextBox
			// 
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosListaBindingSource, "Id", true));
			this.idTextBox.Location = new System.Drawing.Point(120, 114);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(104, 20);
			this.idTextBox.TabIndex = 10;
			// 
			// nombresTextBox
			// 
			this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosListaBindingSource, "Nombres", true));
			this.nombresTextBox.Location = new System.Drawing.Point(120, 140);
			this.nombresTextBox.Name = "nombresTextBox";
			this.nombresTextBox.Size = new System.Drawing.Size(104, 20);
			this.nombresTextBox.TabIndex = 12;
			// 
			// sexoTextBox
			// 
			this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alumnosListaBindingSource, "Sexo", true));
			this.sexoTextBox.Location = new System.Drawing.Point(369, 139);
			this.sexoTextBox.Name = "sexoTextBox";
			this.sexoTextBox.Size = new System.Drawing.Size(104, 20);
			this.sexoTextBox.TabIndex = 14;
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
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(807, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 33);
			this.label1.TabIndex = 17;
			this.label1.Text = "X";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
			this.bindingNavigator1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.bindingNavigator1.BindingSource = this.alumnosListaBindingSource;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
			this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
			this.bindingNavigator1.Location = new System.Drawing.Point(45, 61);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(286, 25);
			this.bindingNavigator1.TabIndex = 19;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// frmAlumnos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(841, 530);
			this.Controls.Add(this.bindingNavigator1);
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
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAlumnos";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAlumnos_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ListaAlumnosDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosListaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
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
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
	}
}