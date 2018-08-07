namespace INTEGRADORA
{
    partial class IngresosyBajas
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
			this.dgvAlumnos = new System.Windows.Forms.DataGridView();
			this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.datos1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.datos1 = new INTEGRADORA.Datos();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbCarrera = new System.Windows.Forms.ComboBox();
			this.cmbGrupo = new System.Windows.Forms.ComboBox();
			this.txtMatricula = new System.Windows.Forms.TextBox();
			this.txtApellidoP = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtApellidoM = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtProcedencia = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.alumnosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.datos1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.alumnosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.alumnosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellidopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellidomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idpocedenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idgruposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idcarreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.datos1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.datos1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.datos1BindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource3)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAlumnos
			// 
			this.dgvAlumnos.AutoGenerateColumns = false;
			this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculaDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidopDataGridViewTextBoxColumn,
            this.apellidomDataGridViewTextBoxColumn,
            this.idpocedenciaDataGridViewTextBoxColumn,
            this.idgruposDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.idcarreraDataGridViewTextBoxColumn});
			this.dgvAlumnos.DataSource = this.alumnosBindingSource;
			this.dgvAlumnos.Location = new System.Drawing.Point(390, 12);
			this.dgvAlumnos.Name = "dgvAlumnos";
			this.dgvAlumnos.Size = new System.Drawing.Size(862, 347);
			this.dgvAlumnos.TabIndex = 40;
			this.dgvAlumnos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.seleccionar_alumno);
			// 
			// alumnosBindingSource
			// 
			this.alumnosBindingSource.DataMember = "alumnos";
			this.alumnosBindingSource.DataSource = this.datos1BindingSource;
			// 
			// datos1BindingSource
			// 
			this.datos1BindingSource.DataSource = this.datos1;
			this.datos1BindingSource.Position = 0;
			// 
			// datos1
			// 
			this.datos1.DataSetName = "Datos";
			this.datos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(1038, 389);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 38;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(269, 370);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 42);
			this.btnEliminar.TabIndex = 37;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(152, 370);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 42);
			this.btnModificar.TabIndex = 36;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(24, 370);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 42);
			this.btnAgregar.TabIndex = 35;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(39, 326);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 34;
			this.label6.Text = "Carrera:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(39, 236);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 33;
			this.label5.Text = "Grupo:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 13);
			this.label4.TabIndex = 32;
			this.label4.Text = "Apellido Paterno";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 31;
			this.label3.Text = "Nombres:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 29;
			this.label1.Text = "Matricula:";
			// 
			// cmbCarrera
			// 
			this.cmbCarrera.FormattingEnabled = true;
			this.cmbCarrera.Items.AddRange(new object[] {
            "SELECCIONAR",
            "ADMINISTRACION",
            "GASTRONOMIA",
            "MANTENIMIENTO",
            "SISTEMAS",
            "TURISMO"});
			this.cmbCarrera.Location = new System.Drawing.Point(112, 318);
			this.cmbCarrera.Name = "cmbCarrera";
			this.cmbCarrera.Size = new System.Drawing.Size(232, 21);
			this.cmbCarrera.TabIndex = 28;
			// 
			// cmbGrupo
			// 
			this.cmbGrupo.FormattingEnabled = true;
			this.cmbGrupo.Items.AddRange(new object[] {
            "SELECCIONAR",
            "A",
            "B",
            "C",
            "D"});
			this.cmbGrupo.Location = new System.Drawing.Point(112, 233);
			this.cmbGrupo.Name = "cmbGrupo";
			this.cmbGrupo.Size = new System.Drawing.Size(232, 21);
			this.cmbGrupo.TabIndex = 27;
			// 
			// txtMatricula
			// 
			this.txtMatricula.Location = new System.Drawing.Point(112, 33);
			this.txtMatricula.Name = "txtMatricula";
			this.txtMatricula.Size = new System.Drawing.Size(232, 20);
			this.txtMatricula.TabIndex = 25;
			// 
			// txtApellidoP
			// 
			this.txtApellidoP.Location = new System.Drawing.Point(129, 106);
			this.txtApellidoP.Name = "txtApellidoP";
			this.txtApellidoP.Size = new System.Drawing.Size(215, 20);
			this.txtApellidoP.TabIndex = 24;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(112, 67);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(232, 20);
			this.txtNombre.TabIndex = 23;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(39, 281);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 13);
			this.label7.TabIndex = 44;
			this.label7.Text = "Direccion:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(387, 394);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(122, 13);
			this.label8.TabIndex = 46;
			this.label8.Text = "Busqueda por Matricula:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(39, 150);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(86, 13);
			this.label9.TabIndex = 48;
			this.label9.Text = "Apellido Materno";
			// 
			// txtApellidoM
			// 
			this.txtApellidoM.Location = new System.Drawing.Point(131, 147);
			this.txtApellidoM.Name = "txtApellidoM";
			this.txtApellidoM.Size = new System.Drawing.Size(213, 20);
			this.txtApellidoM.TabIndex = 47;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 189);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 50;
			this.label2.Text = "Procedencia:";
			// 
			// txtProcedencia
			// 
			this.txtProcedencia.Location = new System.Drawing.Point(112, 189);
			this.txtProcedencia.Name = "txtProcedencia";
			this.txtProcedencia.Size = new System.Drawing.Size(232, 20);
			this.txtProcedencia.TabIndex = 51;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(112, 278);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(232, 20);
			this.txtDireccion.TabIndex = 52;
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(570, 391);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(447, 20);
			this.txtBusqueda.TabIndex = 45;
			this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
			// 
			// alumnosBindingSource1
			// 
			this.alumnosBindingSource1.DataMember = "alumnos";
			this.alumnosBindingSource1.DataSource = this.datos1BindingSource;
			// 
			// datos1BindingSource1
			// 
			this.datos1BindingSource1.DataSource = this.datos1;
			this.datos1BindingSource1.Position = 0;
			// 
			// alumnosBindingSource2
			// 
			this.alumnosBindingSource2.DataMember = "alumnos";
			this.alumnosBindingSource2.DataSource = this.datos1BindingSource1;
			// 
			// alumnosBindingSource3
			// 
			this.alumnosBindingSource3.DataMember = "alumnos";
			this.alumnosBindingSource3.DataSource = this.datos1BindingSource;
			// 
			// matriculaDataGridViewTextBoxColumn
			// 
			this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "matricula";
			this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
			this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
			// 
			// nombresDataGridViewTextBoxColumn
			// 
			this.nombresDataGridViewTextBoxColumn.DataPropertyName = "nombres";
			this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
			this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
			// 
			// apellidopDataGridViewTextBoxColumn
			// 
			this.apellidopDataGridViewTextBoxColumn.DataPropertyName = "apellidop";
			this.apellidopDataGridViewTextBoxColumn.HeaderText = "Apellido Paterno";
			this.apellidopDataGridViewTextBoxColumn.Name = "apellidopDataGridViewTextBoxColumn";
			// 
			// apellidomDataGridViewTextBoxColumn
			// 
			this.apellidomDataGridViewTextBoxColumn.DataPropertyName = "apellidom";
			this.apellidomDataGridViewTextBoxColumn.HeaderText = "Apellido Materno";
			this.apellidomDataGridViewTextBoxColumn.Name = "apellidomDataGridViewTextBoxColumn";
			// 
			// idpocedenciaDataGridViewTextBoxColumn
			// 
			this.idpocedenciaDataGridViewTextBoxColumn.DataPropertyName = "id_pocedencia";
			this.idpocedenciaDataGridViewTextBoxColumn.HeaderText = "id_pocedencia";
			this.idpocedenciaDataGridViewTextBoxColumn.Name = "idpocedenciaDataGridViewTextBoxColumn";
			// 
			// idgruposDataGridViewTextBoxColumn
			// 
			this.idgruposDataGridViewTextBoxColumn.DataPropertyName = "id_grupos";
			this.idgruposDataGridViewTextBoxColumn.HeaderText = "Grupo";
			this.idgruposDataGridViewTextBoxColumn.Name = "idgruposDataGridViewTextBoxColumn";
			// 
			// direccionDataGridViewTextBoxColumn
			// 
			this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
			this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
			this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
			// 
			// idcarreraDataGridViewTextBoxColumn
			// 
			this.idcarreraDataGridViewTextBoxColumn.DataPropertyName = "id_carrera";
			this.idcarreraDataGridViewTextBoxColumn.HeaderText = "Carrera";
			this.idcarreraDataGridViewTextBoxColumn.Name = "idcarreraDataGridViewTextBoxColumn";
			// 
			// IngresosyBajas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1266, 440);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtProcedencia);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtApellidoM);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dgvAlumnos);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbCarrera);
			this.Controls.Add(this.cmbGrupo);
			this.Controls.Add(this.txtMatricula);
			this.Controls.Add(this.txtApellidoP);
			this.Controls.Add(this.txtNombre);
			this.Name = "IngresosyBajas";
			this.Text = "Altas y Bajas";
			((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.datos1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.datos1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.datos1BindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcedencia;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.BindingSource alumnosBindingSource;
		private System.Windows.Forms.BindingSource datos1BindingSource;
		private Datos datos1;
		private System.Windows.Forms.BindingSource alumnosBindingSource1;
		private System.Windows.Forms.BindingSource alumnosBindingSource2;
		private System.Windows.Forms.BindingSource datos1BindingSource1;
		private System.Windows.Forms.BindingSource alumnosBindingSource3;
		private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellidopDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn apellidomDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idpocedenciaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idgruposDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idcarreraDataGridViewTextBoxColumn;
	}
}