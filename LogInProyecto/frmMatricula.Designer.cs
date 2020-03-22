namespace LogInProyecto
{
	partial class frmMatricula
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
			System.Windows.Forms.Label activoLabel;
			System.Windows.Forms.Label alumnoIdLabel;
			System.Windows.Forms.Label fechaLabel;
			System.Windows.Forms.Label matriculaIdLabel;
			System.Windows.Forms.Label label3;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatricula));
			this.label1 = new System.Windows.Forms.Label();
			this.matriculaAsignaturasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.matriculaAsignaturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewMatricula = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteMatricula = new System.Windows.Forms.ToolStripButton();
			this.matriculaAsignaturasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
			this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.activoCheckBox = new System.Windows.Forms.CheckBox();
			this.alumnoIdComboBox = new System.Windows.Forms.ComboBox();
			this.alumnosListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.matriculaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.matriculaDetalleDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.asignaturasListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.docentesListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAggDetalle = new System.Windows.Forms.Button();
			this.btnDeleteDetalle = new System.Windows.Forms.Button();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.lblCANCELADA = new System.Windows.Forms.Label();
			this.lblActiva = new System.Windows.Forms.Label();
			this.lblVacio = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			activoLabel = new System.Windows.Forms.Label();
			alumnoIdLabel = new System.Windows.Forms.Label();
			fechaLabel = new System.Windows.Forms.Label();
			matriculaIdLabel = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.matriculaAsignaturasBindingNavigator)).BeginInit();
			this.matriculaAsignaturasBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.matriculaAsignaturasBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosListaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.matriculaDetalleBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.matriculaDetalleDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.asignaturasListaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.docentesListaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label2.ForeColor = System.Drawing.Color.Transparent;
			label2.Location = new System.Drawing.Point(330, 9);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(139, 33);
			label2.TabIndex = 22;
			label2.Text = "Matricula";
			// 
			// activoLabel
			// 
			activoLabel.AutoSize = true;
			activoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			activoLabel.ForeColor = System.Drawing.Color.Transparent;
			activoLabel.Location = new System.Drawing.Point(485, 121);
			activoLabel.Name = "activoLabel";
			activoLabel.Size = new System.Drawing.Size(62, 20);
			activoLabel.TabIndex = 23;
			activoLabel.Text = "Activo:";
			// 
			// alumnoIdLabel
			// 
			alumnoIdLabel.AutoSize = true;
			alumnoIdLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			alumnoIdLabel.ForeColor = System.Drawing.Color.Transparent;
			alumnoIdLabel.Location = new System.Drawing.Point(58, 116);
			alumnoIdLabel.Name = "alumnoIdLabel";
			alumnoIdLabel.Size = new System.Drawing.Size(68, 20);
			alumnoIdLabel.TabIndex = 25;
			alumnoIdLabel.Text = "Alumno:";
			// 
			// fechaLabel
			// 
			fechaLabel.AutoSize = true;
			fechaLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			fechaLabel.ForeColor = System.Drawing.Color.Transparent;
			fechaLabel.Location = new System.Drawing.Point(485, 91);
			fechaLabel.Name = "fechaLabel";
			fechaLabel.Size = new System.Drawing.Size(59, 20);
			fechaLabel.TabIndex = 27;
			fechaLabel.Text = "Fecha:";
			// 
			// matriculaIdLabel
			// 
			matriculaIdLabel.AutoSize = true;
			matriculaIdLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			matriculaIdLabel.ForeColor = System.Drawing.Color.Transparent;
			matriculaIdLabel.Location = new System.Drawing.Point(58, 90);
			matriculaIdLabel.Name = "matriculaIdLabel";
			matriculaIdLabel.Size = new System.Drawing.Size(102, 20);
			matriculaIdLabel.TabIndex = 29;
			matriculaIdLabel.Text = "Matricula Id:";
			// 
			// label3
			// 
			label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label3.ForeColor = System.Drawing.Color.Transparent;
			label3.Location = new System.Drawing.Point(257, 183);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(287, 33);
			label3.TabIndex = 35;
			label3.Text = "Detalle de matricula";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(4, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 22);
			this.label1.TabIndex = 21;
			this.label1.Text = "Cerrar";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// matriculaAsignaturasBindingNavigator
			// 
			this.matriculaAsignaturasBindingNavigator.AddNewItem = null;
			this.matriculaAsignaturasBindingNavigator.BindingSource = this.matriculaAsignaturasBindingSource;
			this.matriculaAsignaturasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.matriculaAsignaturasBindingNavigator.DeleteItem = null;
			this.matriculaAsignaturasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
			this.matriculaAsignaturasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewMatricula,
            this.bindingNavigatorDeleteMatricula,
            this.matriculaAsignaturasBindingNavigatorSaveItem,
            this.toolStripCancelar});
			this.matriculaAsignaturasBindingNavigator.Location = new System.Drawing.Point(245, 45);
			this.matriculaAsignaturasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.matriculaAsignaturasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.matriculaAsignaturasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.matriculaAsignaturasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.matriculaAsignaturasBindingNavigator.Name = "matriculaAsignaturasBindingNavigator";
			this.matriculaAsignaturasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.matriculaAsignaturasBindingNavigator.Size = new System.Drawing.Size(278, 25);
			this.matriculaAsignaturasBindingNavigator.TabIndex = 23;
			this.matriculaAsignaturasBindingNavigator.Text = "bindingNavigator1";
			// 
			// matriculaAsignaturasBindingSource
			// 
			this.matriculaAsignaturasBindingSource.DataSource = typeof(Universidad.BL.MatriculaAsignaturas);
			this.matriculaAsignaturasBindingSource.CurrentChanged += new System.EventHandler(this.matriculaAsignaturasBindingSource_CurrentChanged);
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
			// bindingNavigatorAddNewMatricula
			// 
			this.bindingNavigatorAddNewMatricula.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewMatricula.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewMatricula.Image")));
			this.bindingNavigatorAddNewMatricula.Name = "bindingNavigatorAddNewMatricula";
			this.bindingNavigatorAddNewMatricula.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewMatricula.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewMatricula.Text = "Agregar Matrícula";
			this.bindingNavigatorAddNewMatricula.Click += new System.EventHandler(this.bindingNavigatorAddNewMatricula_Click);
			// 
			// bindingNavigatorDeleteMatricula
			// 
			this.bindingNavigatorDeleteMatricula.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteMatricula.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteMatricula.Image")));
			this.bindingNavigatorDeleteMatricula.Name = "bindingNavigatorDeleteMatricula";
			this.bindingNavigatorDeleteMatricula.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteMatricula.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteMatricula.Text = "Anular Matrícula";
			this.bindingNavigatorDeleteMatricula.Click += new System.EventHandler(this.bindingNavigatorDeleteMatricula_Click);
			// 
			// matriculaAsignaturasBindingNavigatorSaveItem
			// 
			this.matriculaAsignaturasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.matriculaAsignaturasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("matriculaAsignaturasBindingNavigatorSaveItem.Image")));
			this.matriculaAsignaturasBindingNavigatorSaveItem.Name = "matriculaAsignaturasBindingNavigatorSaveItem";
			this.matriculaAsignaturasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.matriculaAsignaturasBindingNavigatorSaveItem.Text = "Guardar Matrícula";
			this.matriculaAsignaturasBindingNavigatorSaveItem.Click += new System.EventHandler(this.matriculaAsignaturasBindingNavigatorSaveItem_Click);
			// 
			// toolStripCancelar
			// 
			this.toolStripCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCancelar.Image")));
			this.toolStripCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripCancelar.Name = "toolStripCancelar";
			this.toolStripCancelar.Size = new System.Drawing.Size(57, 22);
			this.toolStripCancelar.Text = "Cancelar";
			this.toolStripCancelar.Visible = false;
			this.toolStripCancelar.Click += new System.EventHandler(this.toolStripCancelar_Click);
			// 
			// fechaDateTimePicker
			// 
			this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.matriculaAsignaturasBindingSource, "Fecha", true));
			this.fechaDateTimePicker.Location = new System.Drawing.Point(556, 93);
			this.fechaDateTimePicker.Name = "fechaDateTimePicker";
			this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.fechaDateTimePicker.TabIndex = 28;
			// 
			// activoCheckBox
			// 
			this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.matriculaAsignaturasBindingSource, "Activo", true));
			this.activoCheckBox.Enabled = false;
			this.activoCheckBox.Location = new System.Drawing.Point(556, 121);
			this.activoCheckBox.Name = "activoCheckBox";
			this.activoCheckBox.Size = new System.Drawing.Size(31, 24);
			this.activoCheckBox.TabIndex = 24;
			this.activoCheckBox.UseVisualStyleBackColor = true;
			// 
			// alumnoIdComboBox
			// 
			this.alumnoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.matriculaAsignaturasBindingSource, "AlumnoId", true));
			this.alumnoIdComboBox.DataSource = this.alumnosListaBindingSource;
			this.alumnoIdComboBox.DisplayMember = "Nombres";
			this.alumnoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.alumnoIdComboBox.Enabled = false;
			this.alumnoIdComboBox.FormattingEnabled = true;
			this.alumnoIdComboBox.Location = new System.Drawing.Point(166, 119);
			this.alumnoIdComboBox.Name = "alumnoIdComboBox";
			this.alumnoIdComboBox.Size = new System.Drawing.Size(121, 21);
			this.alumnoIdComboBox.TabIndex = 31;
			this.alumnoIdComboBox.ValueMember = "Id";
			// 
			// alumnosListaBindingSource
			// 
			this.alumnosListaBindingSource.DataSource = typeof(Universidad.BL.AlumnosLista);
			// 
			// matriculaDetalleBindingSource
			// 
			this.matriculaDetalleBindingSource.AllowNew = false;
			this.matriculaDetalleBindingSource.DataMember = "MatriculaDetalle";
			this.matriculaDetalleBindingSource.DataSource = this.matriculaAsignaturasBindingSource;
			// 
			// matriculaDetalleDataGridView
			// 
			this.matriculaDetalleDataGridView.AutoGenerateColumns = false;
			this.matriculaDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.matriculaDetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
			this.matriculaDetalleDataGridView.DataSource = this.matriculaDetalleBindingSource;
			this.matriculaDetalleDataGridView.Location = new System.Drawing.Point(30, 230);
			this.matriculaDetalleDataGridView.Name = "matriculaDetalleDataGridView";
			this.matriculaDetalleDataGridView.Size = new System.Drawing.Size(741, 220);
			this.matriculaDetalleDataGridView.TabIndex = 31;
			this.matriculaDetalleDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.matriculaDetalleDataGridView_DataError);
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "AsignaturaId";
			this.dataGridViewTextBoxColumn3.DataSource = this.asignaturasListaBindingSource;
			this.dataGridViewTextBoxColumn3.DisplayMember = "Descripcion";
			this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.dataGridViewTextBoxColumn3.HeaderText = "Asigantura";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn3.ValueMember = "Id";
			// 
			// asignaturasListaBindingSource
			// 
			this.asignaturasListaBindingSource.DataSource = typeof(Universidad.BL.AsignaturasLista);
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "DocenteId";
			this.dataGridViewTextBoxColumn5.DataSource = this.docentesListaBindingSource;
			this.dataGridViewTextBoxColumn5.DisplayMember = "Nombres";
			this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.dataGridViewTextBoxColumn5.HeaderText = "Docentes";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn5.ValueMember = "Id";
			// 
			// docentesListaBindingSource
			// 
			this.docentesListaBindingSource.DataSource = typeof(Universidad.BL.DocentesLista);
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "HoraInicio";
			this.dataGridViewTextBoxColumn6.HeaderText = "HoraInicio";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "HoraFinaliza";
			this.dataGridViewTextBoxColumn7.HeaderText = "HoraFinaliza";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// btnAggDetalle
			// 
			this.btnAggDetalle.FlatAppearance.BorderSize = 0;
			this.btnAggDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAggDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnAggDetalle.Image")));
			this.btnAggDetalle.Location = new System.Drawing.Point(30, 189);
			this.btnAggDetalle.Name = "btnAggDetalle";
			this.btnAggDetalle.Size = new System.Drawing.Size(42, 35);
			this.btnAggDetalle.TabIndex = 32;
			this.toolTip1.SetToolTip(this.btnAggDetalle, "Agregar registros al detalle");
			this.btnAggDetalle.UseVisualStyleBackColor = true;
			this.btnAggDetalle.Click += new System.EventHandler(this.btnAggDetalle_Click);
			// 
			// btnDeleteDetalle
			// 
			this.btnDeleteDetalle.FlatAppearance.BorderSize = 0;
			this.btnDeleteDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDetalle.Image")));
			this.btnDeleteDetalle.Location = new System.Drawing.Point(729, 189);
			this.btnDeleteDetalle.Name = "btnDeleteDetalle";
			this.btnDeleteDetalle.Size = new System.Drawing.Size(42, 35);
			this.btnDeleteDetalle.TabIndex = 33;
			this.toolTip1.SetToolTip(this.btnDeleteDetalle, "Eliminar registro del detalle");
			this.btnDeleteDetalle.UseVisualStyleBackColor = true;
			this.btnDeleteDetalle.Click += new System.EventHandler(this.btnDeleteDetalle_Click);
			// 
			// idTextBox
			// 
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matriculaAsignaturasBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "00000"));
			this.idTextBox.Enabled = false;
			this.idTextBox.Location = new System.Drawing.Point(166, 96);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.ReadOnly = true;
			this.idTextBox.Size = new System.Drawing.Size(121, 20);
			this.idTextBox.TabIndex = 34;
			// 
			// lblCANCELADA
			// 
			this.lblCANCELADA.AutoSize = true;
			this.lblCANCELADA.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCANCELADA.ForeColor = System.Drawing.Color.Red;
			this.lblCANCELADA.Location = new System.Drawing.Point(484, 121);
			this.lblCANCELADA.Name = "lblCANCELADA";
			this.lblCANCELADA.Size = new System.Drawing.Size(114, 25);
			this.lblCANCELADA.TabIndex = 36;
			this.lblCANCELADA.Text = "ANULADA";
			this.lblCANCELADA.Visible = false;
			// 
			// lblActiva
			// 
			this.lblActiva.AutoSize = true;
			this.lblActiva.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblActiva.ForeColor = System.Drawing.Color.LimeGreen;
			this.lblActiva.Location = new System.Drawing.Point(484, 121);
			this.lblActiva.Name = "lblActiva";
			this.lblActiva.Size = new System.Drawing.Size(90, 25);
			this.lblActiva.TabIndex = 37;
			this.lblActiva.Text = "ACTIVA";
			this.lblActiva.Visible = false;
			// 
			// lblVacio
			// 
			this.lblVacio.AutoSize = true;
			this.lblVacio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVacio.ForeColor = System.Drawing.Color.Yellow;
			this.lblVacio.Location = new System.Drawing.Point(484, 121);
			this.lblVacio.Name = "lblVacio";
			this.lblVacio.Size = new System.Drawing.Size(159, 25);
			this.lblVacio.TabIndex = 38;
			this.lblVacio.Text = "SIN REGISTROS";
			this.lblVacio.Visible = false;
			// 
			// frmMatricula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(803, 482);
			this.Controls.Add(this.lblVacio);
			this.Controls.Add(this.lblActiva);
			this.Controls.Add(this.lblCANCELADA);
			this.Controls.Add(label3);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(this.btnDeleteDetalle);
			this.Controls.Add(this.btnAggDetalle);
			this.Controls.Add(this.matriculaDetalleDataGridView);
			this.Controls.Add(this.alumnoIdComboBox);
			this.Controls.Add(activoLabel);
			this.Controls.Add(this.activoCheckBox);
			this.Controls.Add(alumnoIdLabel);
			this.Controls.Add(fechaLabel);
			this.Controls.Add(this.fechaDateTimePicker);
			this.Controls.Add(matriculaIdLabel);
			this.Controls.Add(this.matriculaAsignaturasBindingNavigator);
			this.Controls.Add(label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmMatricula";
			this.Text = "frmMatricula";
			((System.ComponentModel.ISupportInitialize)(this.matriculaAsignaturasBindingNavigator)).EndInit();
			this.matriculaAsignaturasBindingNavigator.ResumeLayout(false);
			this.matriculaAsignaturasBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.matriculaAsignaturasBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosListaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.matriculaDetalleBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.matriculaDetalleDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.asignaturasListaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.docentesListaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource matriculaAsignaturasBindingSource;
		private System.Windows.Forms.BindingNavigator matriculaAsignaturasBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewMatricula;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteMatricula;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton matriculaAsignaturasBindingNavigatorSaveItem;
		private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
		private System.Windows.Forms.CheckBox activoCheckBox;
		private System.Windows.Forms.BindingSource alumnosListaBindingSource;
		private System.Windows.Forms.BindingSource asignaturasListaBindingSource;
		private System.Windows.Forms.ComboBox alumnoIdComboBox;
		private System.Windows.Forms.BindingSource matriculaDetalleBindingSource;
		private System.Windows.Forms.DataGridView matriculaDetalleDataGridView;
		private System.Windows.Forms.ToolStripButton toolStripCancelar;
		private System.Windows.Forms.BindingSource docentesListaBindingSource;
		private System.Windows.Forms.Button btnAggDetalle;
		private System.Windows.Forms.Button btnDeleteDetalle;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lblCANCELADA;
		private System.Windows.Forms.Label lblActiva;
		private System.Windows.Forms.Label lblVacio;
	}
}