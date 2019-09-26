namespace Clinica
{
    partial class FormMedicos
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label jornadaIdLabel;
            System.Windows.Forms.Label especialidadIdLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label costoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicos));
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
            this.listaMedicosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.listaMedicosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaMedicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaEspecialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaJornadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.jornadaIdComboBox = new System.Windows.Forms.ComboBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.especialidadIdComboBox = new System.Windows.Forms.ComboBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.costoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            jornadaIdLabel = new System.Windows.Forms.Label();
            especialidadIdLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicosBindingNavigator)).BeginInit();
            this.listaMedicosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEspecialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaJornadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            idLabel.AutoSize = true;
            idLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            idLabel.Location = new System.Drawing.Point(106, 150);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 11;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nombreLabel.AutoSize = true;
            nombreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nombreLabel.Location = new System.Drawing.Point(106, 183);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 12;
            nombreLabel.Text = "Nombre:";
            // 
            // jornadaIdLabel
            // 
            jornadaIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            jornadaIdLabel.AutoSize = true;
            jornadaIdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            jornadaIdLabel.Location = new System.Drawing.Point(106, 293);
            jornadaIdLabel.Name = "jornadaIdLabel";
            jornadaIdLabel.Size = new System.Drawing.Size(48, 13);
            jornadaIdLabel.TabIndex = 21;
            jornadaIdLabel.Text = "Jornada:";
            // 
            // especialidadIdLabel
            // 
            especialidadIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            especialidadIdLabel.AutoSize = true;
            especialidadIdLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            especialidadIdLabel.Location = new System.Drawing.Point(106, 259);
            especialidadIdLabel.Name = "especialidadIdLabel";
            especialidadIdLabel.Size = new System.Drawing.Size(70, 13);
            especialidadIdLabel.TabIndex = 17;
            especialidadIdLabel.Text = "Especialidad:";
            // 
            // codigoLabel
            // 
            codigoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            codigoLabel.AutoSize = true;
            codigoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            codigoLabel.Location = new System.Drawing.Point(106, 221);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(65, 13);
            codigoLabel.TabIndex = 15;
            codigoLabel.Text = "Colegiación:";
            // 
            // activoLabel
            // 
            activoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            activoLabel.AutoSize = true;
            activoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            activoLabel.Location = new System.Drawing.Point(313, 330);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 13;
            activoLabel.Text = "Activo:";
            // 
            // costoLabel
            // 
            costoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            costoLabel.AutoSize = true;
            costoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            costoLabel.Location = new System.Drawing.Point(106, 330);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(93, 13);
            costoLabel.TabIndex = 21;
            costoLabel.Text = "Valor de Consulta:";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
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
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
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
            // listaMedicosBindingNavigatorSaveItem
            // 
            this.listaMedicosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaMedicosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaMedicosBindingNavigatorSaveItem.Image")));
            this.listaMedicosBindingNavigatorSaveItem.Name = "listaMedicosBindingNavigatorSaveItem";
            this.listaMedicosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaMedicosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaMedicosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaMedicosBindingNavigatorSaveItem_Click);
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
            // listaMedicosBindingNavigator
            // 
            this.listaMedicosBindingNavigator.AddNewItem = null;
            this.listaMedicosBindingNavigator.BindingSource = this.listaMedicosBindingSource;
            this.listaMedicosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaMedicosBindingNavigator.DeleteItem = null;
            this.listaMedicosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaMedicosBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaMedicosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaMedicosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaMedicosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaMedicosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaMedicosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaMedicosBindingNavigator.Name = "listaMedicosBindingNavigator";
            this.listaMedicosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaMedicosBindingNavigator.Size = new System.Drawing.Size(576, 25);
            this.listaMedicosBindingNavigator.TabIndex = 13;
            this.listaMedicosBindingNavigator.Text = "bindingNavigator1";
            // 
            // listaMedicosBindingSource
            // 
            this.listaMedicosBindingSource.DataSource = typeof(Clinica.BL.Medico);
            // 
            // listaEspecialidadesBindingSource
            // 
            this.listaEspecialidadesBindingSource.DataSource = typeof(Clinica.BL.Especialidad);
            this.listaEspecialidadesBindingSource.CurrentChanged += new System.EventHandler(this.listaEspecialidadesBindingSource_CurrentChanged);
            // 
            // listaJornadasBindingSource
            // 
            this.listaJornadasBindingSource.DataSource = typeof(Clinica.BL.Jornada);
            this.listaJornadasBindingSource.CurrentChanged += new System.EventHandler(this.listaJornadasBindingSource_CurrentChanged);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMedicosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(155, 180);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(317, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // jornadaIdComboBox
            // 
            this.jornadaIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jornadaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaMedicosBindingSource, "JornadaId", true));
            this.jornadaIdComboBox.DataSource = this.listaJornadasBindingSource;
            this.jornadaIdComboBox.DisplayMember = "Descripcion";
            this.jornadaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jornadaIdComboBox.FormattingEnabled = true;
            this.jornadaIdComboBox.Location = new System.Drawing.Point(182, 290);
            this.jornadaIdComboBox.Name = "jornadaIdComboBox";
            this.jornadaIdComboBox.Size = new System.Drawing.Size(181, 21);
            this.jornadaIdComboBox.TabIndex = 9;
            this.jornadaIdComboBox.ValueMember = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMedicosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(131, 147);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(60, 20);
            this.idTextBox.TabIndex = 20;
            // 
            // especialidadIdComboBox
            // 
            this.especialidadIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.especialidadIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaMedicosBindingSource, "EspecialidadId", true));
            this.especialidadIdComboBox.DataSource = this.listaEspecialidadesBindingSource;
            this.especialidadIdComboBox.DisplayMember = "Descripcion";
            this.especialidadIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especialidadIdComboBox.FormattingEnabled = true;
            this.especialidadIdComboBox.Location = new System.Drawing.Point(182, 256);
            this.especialidadIdComboBox.Name = "especialidadIdComboBox";
            this.especialidadIdComboBox.Size = new System.Drawing.Size(181, 21);
            this.especialidadIdComboBox.TabIndex = 4;
            this.especialidadIdComboBox.ValueMember = "Id";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMedicosBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(182, 218);
            this.codigoTextBox.MaxLength = 8;
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(103, 20);
            this.codigoTextBox.TabIndex = 2;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaMedicosBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(359, 325);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(121, 24);
            this.activoCheckBox.TabIndex = 3;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // costoTextBox
            // 
            this.costoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.costoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMedicosBindingSource, "Costo", true));
            this.costoTextBox.Location = new System.Drawing.Point(205, 327);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(100, 20);
            this.costoTextBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(385, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "* Busqueda por Nombre o Apellido";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Image = global::Clinica.Properties.Resources.search_icon__1_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(479, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "    Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(377, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 37;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Image = global::Clinica.Properties.Resources.close_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(479, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 40;
            this.button3.Text = "   Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(476, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(369, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(369, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(286, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(374, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "* Campos Obligatorios";
            // 
            // FormMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(123)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(576, 457);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(costoLabel);
            this.Controls.Add(this.costoTextBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(especialidadIdLabel);
            this.Controls.Add(this.especialidadIdComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(jornadaIdLabel);
            this.Controls.Add(this.jornadaIdComboBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.listaMedicosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMedicos";
            this.Text = "Datos de Medicos";
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicosBindingNavigator)).EndInit();
            this.listaMedicosBindingNavigator.ResumeLayout(false);
            this.listaMedicosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEspecialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaJornadasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource listaEspecialidadesBindingSource;
        private System.Windows.Forms.BindingSource listaJornadasBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton listaMedicosBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.BindingNavigator listaMedicosBindingNavigator;
        private System.Windows.Forms.BindingSource listaMedicosBindingSource;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox jornadaIdComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox especialidadIdComboBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox costoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}