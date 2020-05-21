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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label carreraIdLabel;
			System.Windows.Forms.Label cupoLabel;
			System.Windows.Forms.Label descripcionLabel;
			System.Windows.Forms.Label idLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignaturas));
			this.lblCerrar = new System.Windows.Forms.Label();
			this.asignaturasListaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.asignaturasListaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.asignaturasListaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabelCancelar = new System.Windows.Forms.ToolStripLabel();
			this.asignaturasListaDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.carreraIdComboBox = new System.Windows.Forms.ComboBox();
			this.cupoTextBox = new System.Windows.Forms.TextBox();
			this.descripcionTextBox = new System.Windows.Forms.TextBox();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.carreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
			label2 = new System.Windows.Forms.Label();
			carreraIdLabel = new System.Windows.Forms.Label();
			cupoLabel = new System.Windows.Forms.Label();
			descripcionLabel = new System.Windows.Forms.Label();
			idLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.asignaturasListaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.asignaturasListaBindingNavigator)).BeginInit();
			this.asignaturasListaBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.asignaturasListaDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).BeginInit();
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
			label2.Size = new System.Drawing.Size(308, 33);
			label2.TabIndex = 23;
			label2.Text = "Listado de Asignaturas";
			// 
			// carreraIdLabel
			// 
			carreraIdLabel.AutoSize = true;
			carreraIdLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			carreraIdLabel.ForeColor = System.Drawing.Color.Transparent;
			carreraIdLabel.Location = new System.Drawing.Point(428, 138);
			carreraIdLabel.Name = "carreraIdLabel";
			carreraIdLabel.Size = new System.Drawing.Size(70, 20);
			carreraIdLabel.TabIndex = 23;
			carreraIdLabel.Text = "Carrera:";
			// 
			// cupoLabel
			// 
			cupoLabel.AutoSize = true;
			cupoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			cupoLabel.ForeColor = System.Drawing.Color.Transparent;
			cupoLabel.Location = new System.Drawing.Point(428, 112);
			cupoLabel.Name = "cupoLabel";
			cupoLabel.Size = new System.Drawing.Size(54, 20);
			cupoLabel.TabIndex = 25;
			cupoLabel.Text = "Cupo:";
			// 
			// descripcionLabel
			// 
			descripcionLabel.AutoSize = true;
			descripcionLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			descripcionLabel.ForeColor = System.Drawing.Color.Transparent;
			descripcionLabel.Location = new System.Drawing.Point(189, 136);
			descripcionLabel.Name = "descripcionLabel";
			descripcionLabel.Size = new System.Drawing.Size(100, 20);
			descripcionLabel.TabIndex = 27;
			descripcionLabel.Text = "Descripcion:";
			// 
			// idLabel
			// 
			idLabel.AutoSize = true;
			idLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			idLabel.ForeColor = System.Drawing.Color.Transparent;
			idLabel.Location = new System.Drawing.Point(261, 110);
			idLabel.Name = "idLabel";
			idLabel.Size = new System.Drawing.Size(28, 20);
			idLabel.TabIndex = 29;
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
			// asignaturasListaBindingSource
			// 
			this.asignaturasListaBindingSource.DataSource = typeof(Universidad.BL.AsignaturasLista);
			// 
			// asignaturasListaBindingNavigator
			// 
			this.asignaturasListaBindingNavigator.AddNewItem = null;
			this.asignaturasListaBindingNavigator.BindingSource = this.asignaturasListaBindingSource;
			this.asignaturasListaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.asignaturasListaBindingNavigator.DeleteItem = null;
			this.asignaturasListaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
			this.asignaturasListaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.asignaturasListaBindingNavigatorSaveItem,
            this.toolStripLabelCancelar});
			this.asignaturasListaBindingNavigator.Location = new System.Drawing.Point(295, 65);
			this.asignaturasListaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.asignaturasListaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.asignaturasListaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.asignaturasListaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.asignaturasListaBindingNavigator.Name = "asignaturasListaBindingNavigator";
			this.asignaturasListaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.asignaturasListaBindingNavigator.Size = new System.Drawing.Size(362, 25);
			this.asignaturasListaBindingNavigator.TabIndex = 22;
			this.asignaturasListaBindingNavigator.Text = "bindingNavigator1";
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
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "of {0}";
			this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
			// 
			// asignaturasListaBindingNavigatorSaveItem
			// 
			this.asignaturasListaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.asignaturasListaBindingNavigatorSaveItem.Enabled = false;
			this.asignaturasListaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("asignaturasListaBindingNavigatorSaveItem.Image")));
			this.asignaturasListaBindingNavigatorSaveItem.Name = "asignaturasListaBindingNavigatorSaveItem";
			this.asignaturasListaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.asignaturasListaBindingNavigatorSaveItem.Text = "Save Data";
			this.asignaturasListaBindingNavigatorSaveItem.Click += new System.EventHandler(this.asignaturasListaBindingNavigatorSaveItem_Click);
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
			// asignaturasListaDataGridView
			// 
			this.asignaturasListaDataGridView.AutoGenerateColumns = false;
			this.asignaturasListaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.asignaturasListaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.asignaturasListaDataGridView.DataSource = this.asignaturasListaBindingSource;
			this.asignaturasListaDataGridView.Location = new System.Drawing.Point(175, 208);
			this.asignaturasListaDataGridView.Name = "asignaturasListaDataGridView";
			this.asignaturasListaDataGridView.Size = new System.Drawing.Size(543, 220);
			this.asignaturasListaDataGridView.TabIndex = 22;
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
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Cupo";
			this.dataGridViewTextBoxColumn3.HeaderText = "Cupo";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "CarreraId";
			this.dataGridViewTextBoxColumn4.HeaderText = "CarreraId";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Carreras";
			this.dataGridViewTextBoxColumn5.HeaderText = "Carreras";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// carreraIdComboBox
			// 
			this.carreraIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asignaturasListaBindingSource, "CarreraId", true));
			this.carreraIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.asignaturasListaBindingSource, "CarreraId", true));
			this.carreraIdComboBox.DataSource = this.carreraBindingSource;
			this.carreraIdComboBox.DisplayMember = "Descripcion";
			this.carreraIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.carreraIdComboBox.FormattingEnabled = true;
			this.carreraIdComboBox.Location = new System.Drawing.Point(502, 138);
			this.carreraIdComboBox.Name = "carreraIdComboBox";
			this.carreraIdComboBox.Size = new System.Drawing.Size(121, 21);
			this.carreraIdComboBox.TabIndex = 24;
			this.carreraIdComboBox.ValueMember = "Id";
			// 
			// cupoTextBox
			// 
			this.cupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asignaturasListaBindingSource, "Cupo", true));
			this.cupoTextBox.Location = new System.Drawing.Point(502, 112);
			this.cupoTextBox.Name = "cupoTextBox";
			this.cupoTextBox.Size = new System.Drawing.Size(121, 20);
			this.cupoTextBox.TabIndex = 26;
			// 
			// descripcionTextBox
			// 
			this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asignaturasListaBindingSource, "Descripcion", true));
			this.descripcionTextBox.Location = new System.Drawing.Point(295, 136);
			this.descripcionTextBox.Name = "descripcionTextBox";
			this.descripcionTextBox.Size = new System.Drawing.Size(121, 20);
			this.descripcionTextBox.TabIndex = 28;
			// 
			// idTextBox
			// 
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asignaturasListaBindingSource, "Id", true));
			this.idTextBox.Location = new System.Drawing.Point(295, 110);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.ReadOnly = true;
			this.idTextBox.Size = new System.Drawing.Size(121, 20);
			this.idTextBox.TabIndex = 30;
			// 
			// carreraBindingSource
			// 
			this.carreraBindingSource.DataSource = typeof(Universidad.BL.Carrera);
			// 
			// frmAsignaturas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(819, 477);
			this.Controls.Add(carreraIdLabel);
			this.Controls.Add(this.carreraIdComboBox);
			this.Controls.Add(cupoLabel);
			this.Controls.Add(this.cupoTextBox);
			this.Controls.Add(descripcionLabel);
			this.Controls.Add(this.descripcionTextBox);
			this.Controls.Add(idLabel);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(label2);
			this.Controls.Add(this.asignaturasListaDataGridView);
			this.Controls.Add(this.asignaturasListaBindingNavigator);
			this.Controls.Add(this.lblCerrar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAsignaturas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Asignaturas";
			((System.ComponentModel.ISupportInitialize)(this.asignaturasListaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.asignaturasListaBindingNavigator)).EndInit();
			this.asignaturasListaBindingNavigator.ResumeLayout(false);
			this.asignaturasListaBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.asignaturasListaDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCerrar;
		private System.Windows.Forms.BindingSource asignaturasListaBindingSource;
		private System.Windows.Forms.BindingNavigator asignaturasListaBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton asignaturasListaBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView asignaturasListaDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.ToolStripLabel toolStripLabelCancelar;
		private System.Windows.Forms.ComboBox carreraIdComboBox;
		private System.Windows.Forms.TextBox cupoTextBox;
		private System.Windows.Forms.TextBox descripcionTextBox;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.BindingSource carreraBindingSource;
	}
}