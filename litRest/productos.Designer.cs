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
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlModifica = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlModifica.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(41, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(650, 571);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Producto";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 197;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Disponibilidad";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(795, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ingresa ID de prducto";
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
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.Controls.Add(this.label9);
            this.pnlNuevo.Controls.Add(this.label8);
            this.pnlNuevo.Controls.Add(this.textBox2);
            this.pnlNuevo.Controls.Add(this.comboBox2);
            this.pnlNuevo.Controls.Add(this.comboBox1);
            this.pnlNuevo.Controls.Add(this.btnAgregar);
            this.pnlNuevo.Controls.Add(this.label7);
            this.pnlNuevo.Controls.Add(this.label6);
            this.pnlNuevo.Controls.Add(this.label2);
            this.pnlNuevo.Controls.Add(this.txbApellido);
            this.pnlNuevo.Controls.Add(this.txbNombre);
            this.pnlNuevo.Controls.Add(this.label5);
            this.pnlNuevo.Controls.Add(this.label4);
            this.pnlNuevo.Location = new System.Drawing.Point(742, 216);
            this.pnlNuevo.Name = "pnlNuevo";
            this.pnlNuevo.Size = new System.Drawing.Size(436, 366);
            this.pnlNuevo.TabIndex = 26;
            // 
            // txbApellido
            // 
            this.txbApellido.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.txbApellido.Location = new System.Drawing.Point(161, 123);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(79, 30);
            this.txbApellido.TabIndex = 35;
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.txbNombre.Location = new System.Drawing.Point(161, 68);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(211, 30);
            this.txbNombre.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label5.Location = new System.Drawing.Point(84, 126);
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
            this.label4.Location = new System.Drawing.Point(67, 71);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label6.Location = new System.Drawing.Point(103, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tipo";
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
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rollo",
            "Platillo",
            "Bebida",
            "Entrada",
            "Postre"});
            this.comboBox1.Location = new System.Drawing.Point(161, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 33);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.Text = "Seleccionar...";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboBox2.Location = new System.Drawing.Point(161, 233);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(210, 33);
            this.comboBox2.TabIndex = 40;
            this.comboBox2.Text = "Seleccionar...";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.textBox2.Location = new System.Drawing.Point(269, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 30);
            this.textBox2.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label8.Location = new System.Drawing.Point(246, 128);
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
            this.label9.Location = new System.Drawing.Point(354, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "MXN";
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
            // pnlModifica
            // 
            this.pnlModifica.Controls.Add(this.label10);
            this.pnlModifica.Controls.Add(this.label11);
            this.pnlModifica.Controls.Add(this.textBox1);
            this.pnlModifica.Controls.Add(this.comboBox3);
            this.pnlModifica.Controls.Add(this.comboBox4);
            this.pnlModifica.Controls.Add(this.button1);
            this.pnlModifica.Controls.Add(this.label12);
            this.pnlModifica.Controls.Add(this.label13);
            this.pnlModifica.Controls.Add(this.label14);
            this.pnlModifica.Controls.Add(this.textBox3);
            this.pnlModifica.Controls.Add(this.textBox4);
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
            this.label10.Location = new System.Drawing.Point(354, 128);
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
            this.label11.Location = new System.Drawing.Point(246, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = ".";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.textBox1.Location = new System.Drawing.Point(269, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 30);
            this.textBox1.TabIndex = 41;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboBox3.Location = new System.Drawing.Point(161, 233);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(210, 33);
            this.comboBox3.TabIndex = 40;
            this.comboBox3.Text = "Seleccionar...";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Rollo",
            "Platillo",
            "Bebida",
            "Entrada",
            "Postre"});
            this.comboBox4.Location = new System.Drawing.Point(161, 178);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(210, 33);
            this.comboBox4.TabIndex = 39;
            this.comboBox4.Text = "Seleccionar...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(130, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 37);
            this.button1.TabIndex = 38;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label13.Location = new System.Drawing.Point(103, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 25);
            this.label13.TabIndex = 36;
            this.label13.Text = "Tipo";
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
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.textBox3.Location = new System.Drawing.Point(161, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 30);
            this.textBox3.TabIndex = 35;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Ubuntu", 15F);
            this.textBox4.Location = new System.Drawing.Point(161, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(211, 30);
            this.textBox4.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Ubuntu", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(69)))));
            this.label15.Location = new System.Drawing.Point(84, 126);
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
            // productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pnlNuevo);
            this.Controls.Add(this.btnNuevoPro);
            this.Controls.Add(this.btnModificaPro);
            this.Controls.Add(this.btnEliminaPro);
            this.Controls.Add(this.txbIdProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pnlModifica);
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "productos";
            this.Size = new System.Drawing.Size(1220, 660);
            this.pnlNuevo.ResumeLayout(false);
            this.pnlNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlModifica.ResumeLayout(false);
            this.pnlModifica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
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
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pnlModifica;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}
