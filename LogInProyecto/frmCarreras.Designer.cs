namespace LogInProyecto
{
	partial class frmCarreras
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
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label descripcionLabel;
			System.Windows.Forms.Label facultadIdLabel;
			System.Windows.Forms.Label idLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarreras));
			this.lblCerrar = new System.Windows.Forms.Label();
			this.carreraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.carreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAgregar = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorEliminar = new System.Windows.Forms.ToolStripButton();
			this.carreraBindingNavigatorGuardar = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
			this.descripcionTextBox = new System.Windows.Forms.TextBox();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.facultadIdComboBox = new System.Windows.Forms.ComboBox();
			this.facultadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.carreraDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Facultades = new System.Windows.Forms.DataGridViewTextBoxColumn();
			label2 = new System.Windows.Forms.Label();
			descripcionLabel = new System.Windows.Forms.Label();
			facultadIdLabel = new System.Windows.Forms.Label();
			idLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.carreraBindingNavigator)).BeginInit();
			this.carreraBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.facultadesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carreraDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label2.ForeColor = System.Drawing.Color.Transparent;
			label2.Location = new System.Drawing.Point(234, 4);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(269, 33);
			label2.TabIndex = 22;
			label2.Text = "Listado de Carreras";
			// 
			// descripcionLabel
			// 
			descripcionLabel.AutoSize = true;
			descripcionLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			descripcionLabel.ForeColor = System.Drawing.Color.Transparent;
			descripcionLabel.Location = new System.Drawing.Point(206, 130);
			descripcionLabel.Name = "descripcionLabel";
			descripcionLabel.Size = new System.Drawing.Size(100, 20);
			descripcionLabel.TabIndex = 23;
			descripcionLabel.Text = "Descripcion:";
			// 
			// facultadIdLabel
			// 
			facultadIdLabel.AutoSize = true;
			facultadIdLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			facultadIdLabel.ForeColor = System.Drawing.Color.Transparent;
			facultadIdLabel.Location = new System.Drawing.Point(206, 156);
			facultadIdLabel.Name = "facultadIdLabel";
			facultadIdLabel.Size = new System.Drawing.Size(77, 20);
			facultadIdLabel.TabIndex = 25;
			facultadIdLabel.Text = "Facultad:";
			// 
			// idLabel
			// 
			idLabel.AutoSize = true;
			idLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			idLabel.ForeColor = System.Drawing.Color.Transparent;
			idLabel.Location = new System.Drawing.Point(206, 104);
			idLabel.Name = "idLabel";
			idLabel.Size = new System.Drawing.Size(28, 20);
			idLabel.TabIndex = 27;
			idLabel.Text = "Id:";
			// 
			// lblCerrar
			// 
			this.lblCerrar.AutoSize = true;
			this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblCerrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCerrar.ForeColor = System.Drawing.Color.Transparent;
			this.lblCerrar.Location = new System.Drawing.Point(6, 4);
			this.lblCerrar.Name = "lblCerrar";
			this.lblCerrar.Size = new System.Drawing.Size(68, 22);
			this.lblCerrar.TabIndex = 21;
			this.lblCerrar.Text = "Cerrar";
			this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
			// 
			// carreraBindingNavigator
			// 
			this.carreraBindingNavigator.AddNewItem = null;
			this.carreraBindingNavigator.BindingSource = this.carreraBindingSource;
			this.carreraBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.carreraBindingNavigator.DeleteItem = null;
			this.carreraBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
			this.carreraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAgregar,
            this.bindingNavigatorEliminar,
            this.carreraBindingNavigatorGuardar,
            this.toolStripButtonCancelar});
			this.carreraBindingNavigator.Location = new System.Drawing.Point(203, 47);
			this.carreraBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.carreraBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.carreraBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.carreraBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.carreraBindingNavigator.Name = "carreraBindingNavigator";
			this.carreraBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.carreraBindingNavigator.Size = new System.Drawing.Size(278, 25);
			this.carreraBindingNavigator.TabIndex = 23;
			this.carreraBindingNavigator.Text = "bindingNavigator1";
			// 
			// carreraBindingSource
			// 
			this.carreraBindingSource.DataSource = typeof(Universidad.BL.Carrera);
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorAgregar
			// 
			this.bindingNavigatorAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAgregar.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAgregar.Image")));
			this.bindingNavigatorAgregar.Name = "bindingNavigatorAgregar";
			this.bindingNavigatorAgregar.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAgregar.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAgregar.Text = "Add new";
			this.bindingNavigatorAgregar.Click += new System.EventHandler(this.bindingNavigatorAgregar_Click);
			// 
			// bindingNavigatorEliminar
			// 
			this.bindingNavigatorEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorEliminar.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEliminar.Image")));
			this.bindingNavigatorEliminar.Name = "bindingNavigatorEliminar";
			this.bindingNavigatorEliminar.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorEliminar.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorEliminar.Text = "Delete";
			this.bindingNavigatorEliminar.Click += new System.EventHandler(this.bindingNavigatorEliminar_Click);
			// 
			// carreraBindingNavigatorGuardar
			// 
			this.carreraBindingNavigatorGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.carreraBindingNavigatorGuardar.Image = ((System.Drawing.Image)(resources.GetObject("carreraBindingNavigatorGuardar.Image")));
			this.carreraBindingNavigatorGuardar.Name = "carreraBindingNavigatorGuardar";
			this.carreraBindingNavigatorGuardar.Size = new System.Drawing.Size(23, 22);
			this.carreraBindingNavigatorGuardar.Text = "Save Data";
			this.carreraBindingNavigatorGuardar.Click += new System.EventHandler(this.carreraBindingNavigatorGuardar_Click);
			// 
			// toolStripButtonCancelar
			// 
			this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
			this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
			this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
			this.toolStripButtonCancelar.Text = "Cancelar";
			this.toolStripButtonCancelar.Visible = false;
			this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
			// 
			// descripcionTextBox
			// 
			this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carreraBindingSource, "Descripcion", true));
			this.descripcionTextBox.Location = new System.Drawing.Point(315, 130);
			this.descripcionTextBox.Name = "descripcionTextBox";
			this.descripcionTextBox.Size = new System.Drawing.Size(149, 20);
			this.descripcionTextBox.TabIndex = 24;
			// 
			// idTextBox
			// 
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carreraBindingSource, "Id", true));
			this.idTextBox.Location = new System.Drawing.Point(315, 104);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.ReadOnly = true;
			this.idTextBox.Size = new System.Drawing.Size(100, 20);
			this.idTextBox.TabIndex = 28;
			// 
			// facultadIdComboBox
			// 
			this.facultadIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carreraBindingSource, "FacultadId", true));
			this.facultadIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.carreraBindingSource, "FacultadId", true));
			this.facultadIdComboBox.DataSource = this.facultadesBindingSource;
			this.facultadIdComboBox.DisplayMember = "Descripcion";
			this.facultadIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.facultadIdComboBox.FormattingEnabled = true;
			this.facultadIdComboBox.Location = new System.Drawing.Point(315, 158);
			this.facultadIdComboBox.Name = "facultadIdComboBox";
			this.facultadIdComboBox.Size = new System.Drawing.Size(246, 21);
			this.facultadIdComboBox.TabIndex = 29;
			this.facultadIdComboBox.ValueMember = "Id";
			// 
			// facultadesBindingSource
			// 
			this.facultadesBindingSource.DataSource = typeof(Universidad.BL.Facultades);
			// 
			// carreraDataGridView
			// 
			this.carreraDataGridView.AutoGenerateColumns = false;
			this.carreraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.carreraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Facultades});
			this.carreraDataGridView.DataSource = this.carreraBindingSource;
			this.carreraDataGridView.Location = new System.Drawing.Point(203, 219);
			this.carreraDataGridView.Name = "carreraDataGridView";
			this.carreraDataGridView.Size = new System.Drawing.Size(358, 220);
			this.carreraDataGridView.TabIndex = 29;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
			this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// Facultades
			// 
			this.Facultades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Facultades.DataPropertyName = "Facultades";
			this.Facultades.HeaderText = "Facultades";
			this.Facultades.Name = "Facultades";
			// 
			// frmCarreras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(803, 474);
			this.Controls.Add(this.carreraDataGridView);
			this.Controls.Add(this.facultadIdComboBox);
			this.Controls.Add(descripcionLabel);
			this.Controls.Add(this.descripcionTextBox);
			this.Controls.Add(facultadIdLabel);
			this.Controls.Add(idLabel);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(this.carreraBindingNavigator);
			this.Controls.Add(label2);
			this.Controls.Add(this.lblCerrar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmCarreras";
			this.Text = "frmCarreras";
			((System.ComponentModel.ISupportInitialize)(this.carreraBindingNavigator)).EndInit();
			this.carreraBindingNavigator.ResumeLayout(false);
			this.carreraBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.facultadesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carreraDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCerrar;
		private System.Windows.Forms.BindingSource carreraBindingSource;
		private System.Windows.Forms.BindingNavigator carreraBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAgregar;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorEliminar;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton carreraBindingNavigatorGuardar;
		private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
		private System.Windows.Forms.TextBox descripcionTextBox;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.ComboBox facultadIdComboBox;
		private System.Windows.Forms.BindingSource facultadesBindingSource;
		private System.Windows.Forms.DataGridView carreraDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Facultades;
	}
}