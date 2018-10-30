namespace litRest
{
    partial class productos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsProduc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txbIdProd = new System.Windows.Forms.TextBox();
            this.btnModificaPro = new System.Windows.Forms.Button();
            this.btnEliminaPro = new System.Windows.Forms.Button();
            this.btnNuevoPro = new System.Windows.Forms.Button();
            this.pnlNuevo = new System.Windows.Forms.Panel();
            this.txbPrecio1 = new System.Windows.Forms.TextBox();
            this.txbNombre1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbDispo1 = new System.Windows.Forms.ComboBox();
            this.txbDec1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlModifica = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbdec2 = new System.Windows.Forms.TextBox();
            this.cbDispo2 = new System.Windows.Forms.ComboBox();
            this.btnAgrega2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txbPrecio2 = new System.Windows.Forms.TextBox();
            this.txbNombre2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txbLogPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlNuevo.SuspendLayout();
            this.pnlModifica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lsProduc
            // 
            this.lsProduc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsProduc.Location = new System.Drawing.Point(41, 30);
            this.lsProduc.Name = "lsProduc";
            this.lsProduc.Size = new System.Drawing.Size(650, 571);
            this.lsProduc.TabIndex = 15;
            this.lsProduc.UseCompatibleStateImageBehavior = false;
            this.lsProduc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Producto";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 176;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Disponibilidad";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 158;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(795, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ingresa ID de producto";
            // 
            // txbIdProd
            // 
            this.txbIdProd.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.txbIdProd.Location = new System.Drawing.Point(1027, 76);
            this.txbIdProd.Name = "txbIdProd";
            this.txbIdProd.Size = new System.Drawing.Size(100, 30);
            this.txbIdProd.TabIndex = 22;
            // 
            // btnModificaPro
            // 
            this.btnModificaPro.BackColor = System.Drawing.Color.Orange;
            this.btnModificaPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificaPro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificaPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaPro.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaPro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificaPro.Location = new System.Drawing.Point(990, 125);
            this.btnModificaPro.Name = "btnModificaPro";
            this.btnModificaPro.Size = new System.Drawing.Size(123, 40);
            this.btnModificaPro.TabIndex = 24;
            this.btnModificaPro.Text = "Modificar";
            this.btnModificaPro.UseVisualStyleBackColor = false;
            this.btnModificaPro.Click += new System.EventHandler(this.btnModificaPro_Click);
            // 
            // btnEliminaPro
            // 
            this.btnEliminaPro.BackColor = System.Drawing.Color.Orange;
            this.btnEliminaPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminaPro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminaPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaPro.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaPro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminaPro.Location = new System.Drawing.Point(839, 126);
            this.btnEliminaPro.Name = "btnEliminaPro";
            this.btnEliminaPro.Size = new System.Drawing.Size(123, 40);
            this.btnEliminaPro.TabIndex = 23;
            this.btnEliminaPro.Text = "Eliminar";
            this.btnEliminaPro.UseVisualStyleBackColor = false;
            this.btnEliminaPro.Click += new System.EventHandler(this.btnEliminaPro_Click);
            // 
            // btnNuevoPro
            // 
            this.btnNuevoPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.btnNuevoPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPro.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.btnNuevoPro.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPro.Location = new System.Drawing.Point(263, 607);
            this.btnNuevoPro.Name = "btnNuevoPro";
            this.btnNuevoPro.Size = new System.Drawing.Size(198, 36);
            this.btnNuevoPro.TabIndex = 25;
            this.btnNuevoPro.Text = "Nuevo producto";
            this.btnNuevoPro.UseVisualStyleBackColor = false;
            this.btnNuevoPro.Click += new System.EventHandler(this.btnNuevoPro_Click);
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.Controls.Add(this.label9);
            this.pnlNuevo.Controls.Add(this.label8);
            this.pnlNuevo.Controls.Add(this.txbDec1);
            this.pnlNuevo.Controls.Add(this.cbDispo1);
            this.pnlNuevo.Controls.Add(this.btnAgregar);
            this.pnlNuevo.Controls.Add(this.label7);
            this.pnlNuevo.Controls.Add(this.label2);
            this.pnlNuevo.Controls.Add(this.txbPrecio1);
            this.pnlNuevo.Controls.Add(this.txbNombre1);
            this.pnlNuevo.Controls.Add(this.label5);
            this.pnlNuevo.Controls.Add(this.label4);
            this.pnlNuevo.Location = new System.Drawing.Point(742, 216);
            this.pnlNuevo.Name = "pnlNuevo";
            this.pnlNuevo.Size = new System.Drawing.Size(436, 366);
            this.pnlNuevo.TabIndex = 26;
            // 
            // txbPrecio1
            // 
            this.txbPrecio1.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.txbPrecio1.Location = new System.Drawing.Point(161, 148);
            this.txbPrecio1.Name = "txbPrecio1";
            this.txbPrecio1.Size = new System.Drawing.Size(79, 30);
            this.txbPrecio1.TabIndex = 35;
            // 
            // txbNombre1
            // 
            this.txbNombre1.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.txbNombre1.Location = new System.Drawing.Point(161, 74);
            this.txbNombre1.Name = "txbNombre1";
            this.txbNombre1.Size = new System.Drawing.Size(211, 30);
            this.txbNombre1.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label5.Location = new System.Drawing.Point(84, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label4.Location = new System.Drawing.Point(67, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(124, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 33);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nuevo producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label7.Location = new System.Drawing.Point(8, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Disponibilidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregar.Location = new System.Drawing.Point(130, 294);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(185, 37);
            this.btnAgregar.TabIndex = 38;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbDispo1
            // 
            this.cbDispo1.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.cbDispo1.FormattingEnabled = true;
            this.cbDispo1.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbDispo1.Location = new System.Drawing.Point(161, 233);
            this.cbDispo1.Name = "cbDispo1";
            this.cbDispo1.Size = new System.Drawing.Size(210, 33);
            this.cbDispo1.TabIndex = 40;
            this.cbDispo1.Text = "Seleccionar...";
            // 
            // txbDec1
            // 
            this.txbDec1.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.txbDec1.Location = new System.Drawing.Point(269, 148);
            this.txbDec1.Name = "txbDec1";
            this.txbDec1.Size = new System.Drawing.Size(79, 30);
            this.txbDec1.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label8.Location = new System.Drawing.Point(246, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label9.Location = new System.Drawing.Point(354, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "MXN";
            // 
            // pnlModifica
            // 
            this.pnlModifica.Controls.Add(this.label10);
            this.pnlModifica.Controls.Add(this.label11);
            this.pnlModifica.Controls.Add(this.txbdec2);
            this.pnlModifica.Controls.Add(this.cbDispo2);
            this.pnlModifica.Controls.Add(this.btnAgrega2);
            this.pnlModifica.Controls.Add(this.label12);
            this.pnlModifica.Controls.Add(this.label14);
            this.pnlModifica.Controls.Add(this.txbPrecio2);
            this.pnlModifica.Controls.Add(this.txbNombre2);
            this.pnlModifica.Controls.Add(this.label15);
            this.pnlModifica.Controls.Add(this.label16);
            this.pnlModifica.Location = new System.Drawing.Point(742, 219);
            this.pnlModifica.Name = "pnlModifica";
            this.pnlModifica.Size = new System.Drawing.Size(436, 366);
            this.pnlModifica.TabIndex = 44;
            this.pnlModifica.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label10.Location = new System.Drawing.Point(354, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 25);
            this.label10.TabIndex = 43;
            this.label10.Text = "MXN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label11.Location = new System.Drawing.Point(246, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = ".";
            // 
            // txbdec2
            // 
            this.txbdec2.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.txbdec2.Location = new System.Drawing.Point(269, 143);
            this.txbdec2.Name = "txbdec2";
            this.txbdec2.Size = new System.Drawing.Size(79, 30);
            this.txbdec2.TabIndex = 41;
            // 
            // cbDispo2
            // 
            this.cbDispo2.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.cbDispo2.FormattingEnabled = true;
            this.cbDispo2.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbDispo2.Location = new System.Drawing.Point(161, 233);
            this.cbDispo2.Name = "cbDispo2";
            this.cbDispo2.Size = new System.Drawing.Size(210, 33);
            this.cbDispo2.TabIndex = 40;
            this.cbDispo2.Text = "Seleccionar...";
            // 
            // btnAgrega2
            // 
            this.btnAgrega2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgrega2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgrega2.FlatAppearance.BorderSize = 0;
            this.btnAgrega2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrega2.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrega2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgrega2.Location = new System.Drawing.Point(130, 294);
            this.btnAgrega2.Name = "btnAgrega2";
            this.btnAgrega2.Size = new System.Drawing.Size(185, 37);
            this.btnAgrega2.TabIndex = 38;
            this.btnAgrega2.Text = "Modificar";
            this.btnAgrega2.UseVisualStyleBackColor = false;
            this.btnAgrega2.Click += new System.EventHandler(this.btnAgrega2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label12.Location = new System.Drawing.Point(8, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 25);
            this.label12.TabIndex = 36;
            this.label12.Text = "Disponibilidad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ubuntu", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label14.Location = new System.Drawing.Point(102, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(251, 33);
            this.label14.TabIndex = 27;
            this.label14.Text = "Modificar producto";
            // 
            // txbPrecio2
            // 
            this.txbPrecio2.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.txbPrecio2.Location = new System.Drawing.Point(161, 143);
            this.txbPrecio2.Name = "txbPrecio2";
            this.txbPrecio2.Size = new System.Drawing.Size(79, 30);
            this.txbPrecio2.TabIndex = 35;
            // 
            // txbNombre2
            // 
            this.txbNombre2.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.txbNombre2.Location = new System.Drawing.Point(161, 68);
            this.txbNombre2.Name = "txbNombre2";
            this.txbNombre2.Size = new System.Drawing.Size(211, 30);
            this.txbNombre2.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label15.Location = new System.Drawing.Point(84, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 25);
            this.label15.TabIndex = 33;
            this.label15.Text = "Precio";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label16.Location = new System.Drawing.Point(67, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 25);
            this.label16.TabIndex = 32;
            this.label16.Text = "Nombre";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.pictureBox5.Location = new System.Drawing.Point(732, 189);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(449, 5);
            this.pictureBox5.TabIndex = 55;
            this.pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txbLogPass);
            this.panel1.Location = new System.Drawing.Point(75, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 537);
            this.panel1.TabIndex = 57;
            this.panel1.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(445, 308);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(182, 37);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Continuar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 47);
            this.label1.TabIndex = 16;
            this.label1.Text = "Contraseña";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(401, 255);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 35);
            this.panel4.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::litRest.Properties.Resources.key;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // txbLogPass
            // 
            this.txbLogPass.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLogPass.Location = new System.Drawing.Point(435, 255);
            this.txbLogPass.Name = "txbLogPass";
            this.txbLogPass.PasswordChar = '*';
            this.txbLogPass.Size = new System.Drawing.Size(234, 35);
            this.txbLogPass.TabIndex = 14;
            this.txbLogPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.label6.Location = new System.Drawing.Point(470, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Administrador";
            // 
            // productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnNuevoPro);
            this.Controls.Add(this.btnModificaPro);
            this.Controls.Add(this.btnEliminaPro);
            this.Controls.Add(this.txbIdProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsProduc);
            this.Controls.Add(this.pnlNuevo);
            this.Controls.Add(this.pnlModifica);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "productos";
            this.Size = new System.Drawing.Size(1220, 660);
            this.pnlNuevo.ResumeLayout(false);
            this.pnlNuevo.PerformLayout();
            this.pnlModifica.ResumeLayout(false);
            this.pnlModifica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsProduc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbIdProd;
        private System.Windows.Forms.Button btnModificaPro;
        private System.Windows.Forms.Button btnEliminaPro;
        private System.Windows.Forms.Button btnNuevoPro;
        private System.Windows.Forms.Panel pnlNuevo;
        private System.Windows.Forms.TextBox txbPrecio1;
        private System.Windows.Forms.TextBox txbNombre1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbDec1;
        private System.Windows.Forms.ComboBox cbDispo1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pnlModifica;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbdec2;
        private System.Windows.Forms.ComboBox cbDispo2;
        private System.Windows.Forms.Button btnAgrega2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbPrecio2;
        private System.Windows.Forms.TextBox txbNombre2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txbLogPass;
    }
}
