namespace LogInProyecto
{
	partial class frmUsuarios
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
			System.Windows.Forms.Label contraseniaLabel;
			System.Windows.Forms.Label idLabel;
			System.Windows.Forms.Label tipoUsuarioLabel;
			System.Windows.Forms.Label usuarioLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
			this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.usuariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.usuariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.contraseniaTextBox = new System.Windows.Forms.TextBox();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.usuarioTextBox = new System.Windows.Forms.TextBox();
			this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Contrasenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.tipoUsuarioComboBox = new System.Windows.Forms.ComboBox();
			label2 = new System.Windows.Forms.Label();
			contraseniaLabel = new System.Windows.Forms.Label();
			idLabel = new System.Windows.Forms.Label();
			tipoUsuarioLabel = new System.Windows.Forms.Label();
			usuarioLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usuariosBindingNavigator)).BeginInit();
			this.usuariosBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label2.ForeColor = System.Drawing.Color.Transparent;
			label2.Location = new System.Drawing.Point(247, 9);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(262, 33);
			label2.TabIndex = 19;
			label2.Text = "Listado de Usuarios";
			// 
			// contraseniaLabel
			// 
			contraseniaLabel.AutoSize = true;
			contraseniaLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			contraseniaLabel.ForeColor = System.Drawing.Color.Transparent;
			contraseniaLabel.Location = new System.Drawing.Point(138, 121);
			contraseniaLabel.Name = "contraseniaLabel";
			contraseniaLabel.Size = new System.Drawing.Size(102, 20);
			contraseniaLabel.TabIndex = 20;
			contraseniaLabel.Text = "Contrasenia:";
			// 
			// idLabel
			// 
			idLabel.AutoSize = true;
			idLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			idLabel.ForeColor = System.Drawing.Color.Transparent;
			idLabel.Location = new System.Drawing.Point(138, 95);
			idLabel.Name = "idLabel";
			idLabel.Size = new System.Drawing.Size(28, 20);
			idLabel.TabIndex = 22;
			idLabel.Text = "Id:";
			// 
			// tipoUsuarioLabel
			// 
			tipoUsuarioLabel.AutoSize = true;
			tipoUsuarioLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			tipoUsuarioLabel.ForeColor = System.Drawing.Color.Transparent;
			tipoUsuarioLabel.Location = new System.Drawing.Point(374, 123);
			tipoUsuarioLabel.Name = "tipoUsuarioLabel";
			tipoUsuarioLabel.Size = new System.Drawing.Size(99, 20);
			tipoUsuarioLabel.TabIndex = 24;
			tipoUsuarioLabel.Text = "Tipo Usuario:";
			// 
			// usuarioLabel
			// 
			usuarioLabel.AutoSize = true;
			usuarioLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			usuarioLabel.ForeColor = System.Drawing.Color.Transparent;
			usuarioLabel.Location = new System.Drawing.Point(374, 95);
			usuarioLabel.Name = "usuarioLabel";
			usuarioLabel.Size = new System.Drawing.Size(67, 20);
			usuarioLabel.TabIndex = 26;
			usuarioLabel.Text = "Usuario:";
			// 
			// usuariosBindingSource
			// 
			this.usuariosBindingSource.DataSource = typeof(Universidad.BL.Usuarios);
			// 
			// usuariosBindingNavigator
			// 
			this.usuariosBindingNavigator.AddNewItem = null;
			this.usuariosBindingNavigator.BindingSource = this.usuariosBindingSource;
			this.usuariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.usuariosBindingNavigator.DeleteItem = null;
			this.usuariosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
			this.usuariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.usuariosBindingNavigatorSaveItem,
            this.toolStripButton1});
			this.usuariosBindingNavigator.Location = new System.Drawing.Point(217, 58);
			this.usuariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.usuariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.usuariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.usuariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.usuariosBindingNavigator.Name = "usuariosBindingNavigator";
			this.usuariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.usuariosBindingNavigator.Size = new System.Drawing.Size(278, 25);
			this.usuariosBindingNavigator.TabIndex = 20;
			this.usuariosBindingNavigator.Text = "bindingNavigator1";
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
			this.bindingNavigatorAddNewItem.Text = "Nuevo";
			this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Eliminar";
			this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
			// 
			// usuariosBindingNavigatorSaveItem
			// 
			this.usuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.usuariosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosBindingNavigatorSaveItem.Image")));
			this.usuariosBindingNavigatorSaveItem.Name = "usuariosBindingNavigatorSaveItem";
			this.usuariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.usuariosBindingNavigatorSaveItem.Text = "Guardar";
			this.usuariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.usuariosBindingNavigatorSaveItem_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(57, 22);
			this.toolStripButton1.Text = "Cancelar";
			this.toolStripButton1.Visible = false;
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// contraseniaTextBox
			// 
			this.contraseniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Contrasenia", true));
			this.contraseniaTextBox.Location = new System.Drawing.Point(246, 121);
			this.contraseniaTextBox.Name = "contraseniaTextBox";
			this.contraseniaTextBox.Size = new System.Drawing.Size(100, 20);
			this.contraseniaTextBox.TabIndex = 21;
			this.contraseniaTextBox.TextChanged += new System.EventHandler(this.contraseniaTextBox_TextChanged);
			// 
			// idTextBox
			// 
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Id", true));
			this.idTextBox.Location = new System.Drawing.Point(246, 95);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.ReadOnly = true;
			this.idTextBox.Size = new System.Drawing.Size(100, 20);
			this.idTextBox.TabIndex = 23;
			// 
			// usuarioTextBox
			// 
			this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Usuario", true));
			this.usuarioTextBox.Location = new System.Drawing.Point(482, 95);
			this.usuarioTextBox.Name = "usuarioTextBox";
			this.usuarioTextBox.Size = new System.Drawing.Size(100, 20);
			this.usuarioTextBox.TabIndex = 27;
			// 
			// usuariosDataGridView
			// 
			this.usuariosDataGridView.AutoGenerateColumns = false;
			this.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.usuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Contrasenia,
            this.dataGridViewTextBoxColumn4});
			this.usuariosDataGridView.DataSource = this.usuariosBindingSource;
			this.usuariosDataGridView.Location = new System.Drawing.Point(186, 182);
			this.usuariosDataGridView.Name = "usuariosDataGridView";
			this.usuariosDataGridView.Size = new System.Drawing.Size(444, 195);
			this.usuariosDataGridView.TabIndex = 27;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Usuario";
			this.dataGridViewTextBoxColumn2.HeaderText = "Usuario";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// Contrasenia
			// 
			this.Contrasenia.DataPropertyName = "Contrasenia";
			this.Contrasenia.HeaderText = "Contrasenia";
			this.Contrasenia.Name = "Contrasenia";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "TipoUsuario";
			this.dataGridViewTextBoxColumn4.HeaderText = "TipoUsuario";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(6, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 22);
			this.label1.TabIndex = 28;
			this.label1.Text = "Cerrar";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// tipoUsuarioComboBox
			// 
			this.tipoUsuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.usuariosBindingSource, "TipoUsuario", true));
			this.tipoUsuarioComboBox.FormattingEnabled = true;
			this.tipoUsuarioComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Gerencia",
            "Secretaría"});
			this.tipoUsuarioComboBox.Location = new System.Drawing.Point(482, 123);
			this.tipoUsuarioComboBox.Name = "tipoUsuarioComboBox";
			this.tipoUsuarioComboBox.Size = new System.Drawing.Size(121, 21);
			this.tipoUsuarioComboBox.TabIndex = 29;
			// 
			// frmUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(803, 438);
			this.Controls.Add(this.tipoUsuarioComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.usuariosDataGridView);
			this.Controls.Add(contraseniaLabel);
			this.Controls.Add(this.contraseniaTextBox);
			this.Controls.Add(idLabel);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(tipoUsuarioLabel);
			this.Controls.Add(usuarioLabel);
			this.Controls.Add(this.usuarioTextBox);
			this.Controls.Add(this.usuariosBindingNavigator);
			this.Controls.Add(label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmUsuarios";
			this.Text = "frmUsuarios";
			((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usuariosBindingNavigator)).EndInit();
			this.usuariosBindingNavigator.ResumeLayout(false);
			this.usuariosBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource usuariosBindingSource;
		private System.Windows.Forms.BindingNavigator usuariosBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton usuariosBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox contraseniaTextBox;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox usuarioTextBox;
		private System.Windows.Forms.DataGridView usuariosDataGridView;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox tipoUsuarioComboBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Contrasenia;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
	}
}