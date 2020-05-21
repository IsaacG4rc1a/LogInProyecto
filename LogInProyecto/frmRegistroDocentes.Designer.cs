namespace LogInProyecto
{
	partial class frmRegistroDocentes
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
			System.Windows.Forms.Label apellidosLabel;
			System.Windows.Forms.Label areaDesempenioLabel;
			System.Windows.Forms.Label domicilioLabel;
			System.Windows.Forms.Label estadoCivilIdLabel;
			System.Windows.Forms.Label facultadIdLabel;
			System.Windows.Forms.Label fechaNacimientoLabel;
			System.Windows.Forms.Label idLabel;
			System.Windows.Forms.Label nombresLabel;
			System.Windows.Forms.Label sexoLabel;
			System.Windows.Forms.Label telefonoLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroDocentes));
			this.lblCerrar = new System.Windows.Forms.Label();
			this.docentesListaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.docentesListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
			this.docentesListaBindingNavigatorGuardar = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabelCancelar = new System.Windows.Forms.ToolStripLabel();
			this.docentesListaDataGridView = new System.Windows.Forms.DataGridView();
			this.apellidosTextBox = new System.Windows.Forms.TextBox();
			this.areaDesempenioTextBox = new System.Windows.Forms.TextBox();
			this.domicilioTextBox = new System.Windows.Forms.TextBox();
			this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.nombresTextBox = new System.Windows.Forms.TextBox();
			this.telefonoTextBox = new System.Windows.Forms.TextBox();
			this.estadoCivilIdComboBox = new System.Windows.Forms.ComboBox();
			this.estadoCivilBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.facultadIdComboBox = new System.Windows.Forms.ComboBox();
			this.facultadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cbSexo = new System.Windows.Forms.ComboBox();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			label2 = new System.Windows.Forms.Label();
			apellidosLabel = new System.Windows.Forms.Label();
			areaDesempenioLabel = new System.Windows.Forms.Label();
			domicilioLabel = new System.Windows.Forms.Label();
			estadoCivilIdLabel = new System.Windows.Forms.Label();
			facultadIdLabel = new System.Windows.Forms.Label();
			fechaNacimientoLabel = new System.Windows.Forms.Label();
			idLabel = new System.Windows.Forms.Label();
			nombresLabel = new System.Windows.Forms.Label();
			sexoLabel = new System.Windows.Forms.Label();
			telefonoLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.docentesListaBindingNavigator)).BeginInit();
			this.docentesListaBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.docentesListaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.docentesListaDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.estadoCivilBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.facultadesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label2.ForeColor = System.Drawing.Color.Transparent;
			label2.Location = new System.Drawing.Point(308, 9);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(286, 33);
			label2.TabIndex = 22;
			label2.Text = "Listado de Docentes";
			// 
			// apellidosLabel
			// 
			apellidosLabel.AutoSize = true;
			apellidosLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			apellidosLabel.ForeColor = System.Drawing.Color.Transparent;
			apellidosLabel.Location = new System.Drawing.Point(398, 110);
			apellidosLabel.Name = "apellidosLabel";
			apellidosLabel.Size = new System.Drawing.Size(79, 20);
			apellidosLabel.TabIndex = 25;
			apellidosLabel.Text = "Apellidos:";
			// 
			// areaDesempenioLabel
			// 
			areaDesempenioLabel.AutoSize = true;
			areaDesempenioLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			areaDesempenioLabel.ForeColor = System.Drawing.Color.Transparent;
			areaDesempenioLabel.Location = new System.Drawing.Point(46, 162);
			areaDesempenioLabel.Name = "areaDesempenioLabel";
			areaDesempenioLabel.Size = new System.Drawing.Size(145, 20);
			areaDesempenioLabel.TabIndex = 27;
			areaDesempenioLabel.Text = "Area Desempenio:";
			// 
			// domicilioLabel
			// 
			domicilioLabel.AutoSize = true;
			domicilioLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			domicilioLabel.ForeColor = System.Drawing.Color.Transparent;
			domicilioLabel.Location = new System.Drawing.Point(46, 188);
			domicilioLabel.Name = "domicilioLabel";
			domicilioLabel.Size = new System.Drawing.Size(79, 20);
			domicilioLabel.TabIndex = 29;
			domicilioLabel.Text = "Domicilio:";
			// 
			// estadoCivilIdLabel
			// 
			estadoCivilIdLabel.AutoSize = true;
			estadoCivilIdLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			estadoCivilIdLabel.ForeColor = System.Drawing.Color.Transparent;
			estadoCivilIdLabel.Location = new System.Drawing.Point(46, 214);
			estadoCivilIdLabel.Name = "estadoCivilIdLabel";
			estadoCivilIdLabel.Size = new System.Drawing.Size(97, 20);
			estadoCivilIdLabel.TabIndex = 31;
			estadoCivilIdLabel.Text = "Estado Civil:";
			// 
			// facultadIdLabel
			// 
			facultadIdLabel.AutoSize = true;
			facultadIdLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			facultadIdLabel.ForeColor = System.Drawing.Color.Transparent;
			facultadIdLabel.Location = new System.Drawing.Point(398, 214);
			facultadIdLabel.Name = "facultadIdLabel";
			facultadIdLabel.Size = new System.Drawing.Size(77, 20);
			facultadIdLabel.TabIndex = 33;
			facultadIdLabel.Text = "Facultad:";
			// 
			// fechaNacimientoLabel
			// 
			fechaNacimientoLabel.AutoSize = true;
			fechaNacimientoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			fechaNacimientoLabel.ForeColor = System.Drawing.Color.Transparent;
			fechaNacimientoLabel.Location = new System.Drawing.Point(398, 189);
			fechaNacimientoLabel.Name = "fechaNacimientoLabel";
			fechaNacimientoLabel.Size = new System.Drawing.Size(147, 20);
			fechaNacimientoLabel.TabIndex = 35;
			fechaNacimientoLabel.Text = "Fecha Nacimiento:";
			// 
			// idLabel
			// 
			idLabel.AutoSize = true;
			idLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			idLabel.ForeColor = System.Drawing.Color.Transparent;
			idLabel.Location = new System.Drawing.Point(46, 110);
			idLabel.Name = "idLabel";
			idLabel.Size = new System.Drawing.Size(28, 20);
			idLabel.TabIndex = 37;
			idLabel.Text = "Id:";
			// 
			// nombresLabel
			// 
			nombresLabel.AutoSize = true;
			nombresLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			nombresLabel.ForeColor = System.Drawing.Color.Transparent;
			nombresLabel.Location = new System.Drawing.Point(46, 137);
			nombresLabel.Name = "nombresLabel";
			nombresLabel.Size = new System.Drawing.Size(78, 20);
			nombresLabel.TabIndex = 39;
			nombresLabel.Text = "Nombres:";
			// 
			// sexoLabel
			// 
			sexoLabel.AutoSize = true;
			sexoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			sexoLabel.ForeColor = System.Drawing.Color.Transparent;
			sexoLabel.Location = new System.Drawing.Point(398, 136);
			sexoLabel.Name = "sexoLabel";
			sexoLabel.Size = new System.Drawing.Size(47, 20);
			sexoLabel.TabIndex = 41;
			sexoLabel.Text = "Sexo:";
			// 
			// telefonoLabel
			// 
			telefonoLabel.AutoSize = true;
			telefonoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			telefonoLabel.ForeColor = System.Drawing.Color.Transparent;
			telefonoLabel.Location = new System.Drawing.Point(398, 162);
			telefonoLabel.Name = "telefonoLabel";
			telefonoLabel.Size = new System.Drawing.Size(75, 20);
			telefonoLabel.TabIndex = 43;
			telefonoLabel.Text = "Telefono:";
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
			// docentesListaBindingNavigator
			// 
			this.docentesListaBindingNavigator.AddNewItem = null;
			this.docentesListaBindingNavigator.BindingSource = this.docentesListaBindingSource;
			this.docentesListaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.docentesListaBindingNavigator.DeleteItem = null;
			this.docentesListaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
			this.docentesListaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.docentesListaBindingNavigatorGuardar,
            this.toolStripLabelCancelar});
			this.docentesListaBindingNavigator.Location = new System.Drawing.Point(269, 42);
			this.docentesListaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.docentesListaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.docentesListaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.docentesListaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.docentesListaBindingNavigator.Name = "docentesListaBindingNavigator";
			this.docentesListaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.docentesListaBindingNavigator.Size = new System.Drawing.Size(278, 25);
			this.docentesListaBindingNavigator.TabIndex = 23;
			this.docentesListaBindingNavigator.Text = "bindingNavigator1";
			// 
			// docentesListaBindingSource
			// 
			this.docentesListaBindingSource.DataSource = typeof(Universidad.BL.DocentesLista);
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
			this.bindingNavigatorAgregar.Text = "Agregar";
			this.bindingNavigatorAgregar.Click += new System.EventHandler(this.bindingNavigatorAgregar_Click);
			// 
			// bindingNavigatorEliminar
			// 
			this.bindingNavigatorEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorEliminar.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEliminar.Image")));
			this.bindingNavigatorEliminar.Name = "bindingNavigatorEliminar";
			this.bindingNavigatorEliminar.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorEliminar.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorEliminar.Text = "Eliminar";
			this.bindingNavigatorEliminar.Click += new System.EventHandler(this.bindingNavigatorEliminar_Click);
			// 
			// docentesListaBindingNavigatorGuardar
			// 
			this.docentesListaBindingNavigatorGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.docentesListaBindingNavigatorGuardar.Enabled = false;
			this.docentesListaBindingNavigatorGuardar.Image = ((System.Drawing.Image)(resources.GetObject("docentesListaBindingNavigatorGuardar.Image")));
			this.docentesListaBindingNavigatorGuardar.Name = "docentesListaBindingNavigatorGuardar";
			this.docentesListaBindingNavigatorGuardar.Size = new System.Drawing.Size(23, 22);
			this.docentesListaBindingNavigatorGuardar.Text = "Guardar";
			this.docentesListaBindingNavigatorGuardar.Click += new System.EventHandler(this.docentesListaBindingNavigatorGuardar_Click);
			// 
			// toolStripLabelCancelar
			// 
			this.toolStripLabelCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabelCancelar.Name = "toolStripLabelCancelar";
			this.toolStripLabelCancelar.Size = new System.Drawing.Size(53, 22);
			this.toolStripLabelCancelar.Text = "Cancelar";
			this.toolStripLabelCancelar.Visible = false;
			this.toolStripLabelCancelar.Click += new System.EventHandler(this.toolStripLabelCancelar_Click);
			// 
			// docentesListaDataGridView
			// 
			this.docentesListaDataGridView.AutoGenerateColumns = false;
			this.docentesListaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.docentesListaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn1});
			this.docentesListaDataGridView.DataSource = this.docentesListaBindingSource;
			this.docentesListaDataGridView.Location = new System.Drawing.Point(13, 245);
			this.docentesListaDataGridView.Name = "docentesListaDataGridView";
			this.docentesListaDataGridView.Size = new System.Drawing.Size(797, 288);
			this.docentesListaDataGridView.TabIndex = 23;
			// 
			// apellidosTextBox
			// 
			this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docentesListaBindingSource, "Apellidos", true));
			this.apellidosTextBox.Location = new System.Drawing.Point(543, 112);
			this.apellidosTextBox.Name = "apellidosTextBox";
			this.apellidosTextBox.Size = new System.Drawing.Size(200, 20);
			this.apellidosTextBox.TabIndex = 26;
			// 
			// areaDesempenioTextBox
			// 
			this.areaDesempenioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docentesListaBindingSource, "AreaDesempenio", true));
			this.areaDesempenioTextBox.Location = new System.Drawing.Point(191, 164);
			this.areaDesempenioTextBox.Name = "areaDesempenioTextBox";
			this.areaDesempenioTextBox.Size = new System.Drawing.Size(200, 20);
			this.areaDesempenioTextBox.TabIndex = 28;
			// 
			// domicilioTextBox
			// 
			this.domicilioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docentesListaBindingSource, "Domicilio", true));
			this.domicilioTextBox.Location = new System.Drawing.Point(191, 190);
			this.domicilioTextBox.Name = "domicilioTextBox";
			this.domicilioTextBox.Size = new System.Drawing.Size(200, 20);
			this.domicilioTextBox.TabIndex = 30;
			// 
			// fechaNacimientoDateTimePicker
			// 
			this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.docentesListaBindingSource, "FechaNacimiento", true));
			this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(543, 190);
			this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
			this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.fechaNacimientoDateTimePicker.TabIndex = 36;
			// 
			// idTextBox
			// 
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docentesListaBindingSource, "Id", true));
			this.idTextBox.Location = new System.Drawing.Point(191, 112);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.ReadOnly = true;
			this.idTextBox.Size = new System.Drawing.Size(200, 20);
			this.idTextBox.TabIndex = 38;
			// 
			// nombresTextBox
			// 
			this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docentesListaBindingSource, "Nombres", true));
			this.nombresTextBox.Location = new System.Drawing.Point(191, 139);
			this.nombresTextBox.Name = "nombresTextBox";
			this.nombresTextBox.Size = new System.Drawing.Size(200, 20);
			this.nombresTextBox.TabIndex = 40;
			// 
			// telefonoTextBox
			// 
			this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docentesListaBindingSource, "Telefono", true));
			this.telefonoTextBox.Location = new System.Drawing.Point(543, 164);
			this.telefonoTextBox.Name = "telefonoTextBox";
			this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
			this.telefonoTextBox.TabIndex = 44;
			// 
			// estadoCivilIdComboBox
			// 
			this.estadoCivilIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.docentesListaBindingSource, "EstadoCivilId", true));
			this.estadoCivilIdComboBox.DataSource = this.estadoCivilBindingSource;
			this.estadoCivilIdComboBox.DisplayMember = "Descripcion";
			this.estadoCivilIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.estadoCivilIdComboBox.FormattingEnabled = true;
			this.estadoCivilIdComboBox.Location = new System.Drawing.Point(191, 216);
			this.estadoCivilIdComboBox.Name = "estadoCivilIdComboBox";
			this.estadoCivilIdComboBox.Size = new System.Drawing.Size(200, 21);
			this.estadoCivilIdComboBox.TabIndex = 51;
			this.estadoCivilIdComboBox.ValueMember = "Id";
			// 
			// estadoCivilBindingSource
			// 
			this.estadoCivilBindingSource.DataSource = typeof(Universidad.BL.EstadoCivil);
			// 
			// facultadIdComboBox
			// 
			this.facultadIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.docentesListaBindingSource, "FacultadId", true));
			this.facultadIdComboBox.DataSource = this.facultadesBindingSource;
			this.facultadIdComboBox.DisplayMember = "Descripcion";
			this.facultadIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.facultadIdComboBox.FormattingEnabled = true;
			this.facultadIdComboBox.Location = new System.Drawing.Point(543, 216);
			this.facultadIdComboBox.Name = "facultadIdComboBox";
			this.facultadIdComboBox.Size = new System.Drawing.Size(200, 21);
			this.facultadIdComboBox.TabIndex = 52;
			this.facultadIdComboBox.ValueMember = "Id";
			// 
			// facultadesBindingSource
			// 
			this.facultadesBindingSource.DataSource = typeof(Universidad.BL.Facultades);
			// 
			// cbSexo
			// 
			this.cbSexo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.docentesListaBindingSource, "Sexo", true));
			this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSexo.FormattingEnabled = true;
			this.cbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
			this.cbSexo.Location = new System.Drawing.Point(543, 137);
			this.cbSexo.Name = "cbSexo";
			this.cbSexo.Size = new System.Drawing.Size(200, 21);
			this.cbSexo.TabIndex = 53;
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(478, 85);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(177, 20);
			this.txtBusqueda.TabIndex = 55;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Location = new System.Drawing.Point(660, 81);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(83, 25);
			this.btnBuscar.TabIndex = 54;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
			this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaNacimiento";
			this.dataGridViewTextBoxColumn4.HeaderText = "FechaNacimiento";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Sexo";
			this.dataGridViewTextBoxColumn5.HeaderText = "Sexo";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Telefono";
			this.dataGridViewTextBoxColumn8.HeaderText = "Telefono";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Domicilio";
			this.dataGridViewTextBoxColumn9.HeaderText = "Domicilio";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "AreaDesempenio";
			this.dataGridViewTextBoxColumn10.HeaderText = "AreaDesempenio";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
			this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			// 
			// frmRegistroDocentes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(830, 545);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.cbSexo);
			this.Controls.Add(this.facultadIdComboBox);
			this.Controls.Add(this.estadoCivilIdComboBox);
			this.Controls.Add(apellidosLabel);
			this.Controls.Add(this.apellidosTextBox);
			this.Controls.Add(areaDesempenioLabel);
			this.Controls.Add(this.areaDesempenioTextBox);
			this.Controls.Add(domicilioLabel);
			this.Controls.Add(this.domicilioTextBox);
			this.Controls.Add(estadoCivilIdLabel);
			this.Controls.Add(facultadIdLabel);
			this.Controls.Add(fechaNacimientoLabel);
			this.Controls.Add(this.fechaNacimientoDateTimePicker);
			this.Controls.Add(idLabel);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(nombresLabel);
			this.Controls.Add(this.nombresTextBox);
			this.Controls.Add(sexoLabel);
			this.Controls.Add(telefonoLabel);
			this.Controls.Add(this.telefonoTextBox);
			this.Controls.Add(this.docentesListaDataGridView);
			this.Controls.Add(this.docentesListaBindingNavigator);
			this.Controls.Add(label2);
			this.Controls.Add(this.lblCerrar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmRegistroDocentes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmRegistroDocentes";
			((System.ComponentModel.ISupportInitialize)(this.docentesListaBindingNavigator)).EndInit();
			this.docentesListaBindingNavigator.ResumeLayout(false);
			this.docentesListaBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.docentesListaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.docentesListaDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.estadoCivilBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.facultadesBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCerrar;
		private System.Windows.Forms.BindingSource docentesListaBindingSource;
		private System.Windows.Forms.BindingNavigator docentesListaBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton docentesListaBindingNavigatorGuardar;
		private System.Windows.Forms.DataGridView docentesListaDataGridView;
		private System.Windows.Forms.TextBox apellidosTextBox;
		private System.Windows.Forms.TextBox areaDesempenioTextBox;
		private System.Windows.Forms.TextBox domicilioTextBox;
		private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox nombresTextBox;
		private System.Windows.Forms.TextBox telefonoTextBox;
		private System.Windows.Forms.ComboBox estadoCivilIdComboBox;
		private System.Windows.Forms.ComboBox facultadIdComboBox;
		private System.Windows.Forms.BindingSource facultadesBindingSource;
		private System.Windows.Forms.BindingSource estadoCivilBindingSource;
		private System.Windows.Forms.ComboBox cbSexo;
		private System.Windows.Forms.ToolStripLabel toolStripLabelCancelar;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
	}
}