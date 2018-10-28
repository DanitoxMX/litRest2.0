namespace litRest
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.lblAjustes = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblProdu = new System.Windows.Forms.Label();
            this.lblEstadis = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.lblNavegador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.btnEstadis = new System.Windows.Forms.PictureBox();
            this.btnProdu = new System.Windows.Forms.PictureBox();
            this.btnUser = new System.Windows.Forms.PictureBox();
            this.btnAjustes = new System.Windows.Forms.PictureBox();
            this.btnOcultar = new System.Windows.Forms.PictureBox();
            this.productos1 = new litRest.productos();
            this.menuVertical.SuspendLayout();
            this.barraTitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEstadis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuVertical.Controls.Add(this.btnSalir);
            this.menuVertical.Controls.Add(this.btnInicio);
            this.menuVertical.Controls.Add(this.btnEstadis);
            this.menuVertical.Controls.Add(this.btnProdu);
            this.menuVertical.Controls.Add(this.btnUser);
            this.menuVertical.Controls.Add(this.btnAjustes);
            this.menuVertical.Controls.Add(this.btnOcultar);
            this.menuVertical.Controls.Add(this.lblAjustes);
            this.menuVertical.Controls.Add(this.lblUser);
            this.menuVertical.Controls.Add(this.lblProdu);
            this.menuVertical.Controls.Add(this.lblEstadis);
            this.menuVertical.Controls.Add(this.lblInicio);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuVertical.Location = new System.Drawing.Point(1220, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(80, 700);
            this.menuVertical.TabIndex = 0;
            // 
            // lblAjustes
            // 
            this.lblAjustes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAjustes.AutoSize = true;
            this.lblAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAjustes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAjustes.Location = new System.Drawing.Point(9, 568);
            this.lblAjustes.Name = "lblAjustes";
            this.lblAjustes.Size = new System.Drawing.Size(61, 20);
            this.lblAjustes.TabIndex = 2;
            this.lblAjustes.Text = "Ajustes";
            this.lblAjustes.MouseEnter += new System.EventHandler(this.btnAjustes_MouseEnter_1);
            this.lblAjustes.MouseLeave += new System.EventHandler(this.btnAjustes_MouseLeave);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUser.AutoSize = true;
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUser.Location = new System.Drawing.Point(6, 473);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(70, 20);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Usuarios";
            this.lblUser.MouseEnter += new System.EventHandler(this.btnUser_MouseEnter);
            this.lblUser.MouseLeave += new System.EventHandler(this.lblUser_MouseLeave);
            // 
            // lblProdu
            // 
            this.lblProdu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProdu.AutoSize = true;
            this.lblProdu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProdu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProdu.Location = new System.Drawing.Point(-2, 376);
            this.lblProdu.Name = "lblProdu";
            this.lblProdu.Size = new System.Drawing.Size(84, 20);
            this.lblProdu.TabIndex = 6;
            this.lblProdu.Text = "Productos";
            this.lblProdu.MouseEnter += new System.EventHandler(this.btnProdu_MouseEnter);
            this.lblProdu.MouseLeave += new System.EventHandler(this.btnProdu_MouseLeave);
            // 
            // lblEstadis
            // 
            this.lblEstadis.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEstadis.AutoSize = true;
            this.lblEstadis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEstadis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstadis.Location = new System.Drawing.Point(-4, 281);
            this.lblEstadis.Name = "lblEstadis";
            this.lblEstadis.Size = new System.Drawing.Size(90, 20);
            this.lblEstadis.TabIndex = 7;
            this.lblEstadis.Text = "Estadisticas";
            this.lblEstadis.MouseEnter += new System.EventHandler(this.btnEstadis_MouseEnter);
            this.lblEstadis.MouseLeave += new System.EventHandler(this.btnEstadis_MouseLeave);
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblInicio.AutoSize = true;
            this.lblInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInicio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInicio.Location = new System.Drawing.Point(18, 183);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(45, 20);
            this.lblInicio.TabIndex = 8;
            this.lblInicio.Text = "Inicio";
            this.lblInicio.MouseEnter += new System.EventHandler(this.btnInicio_MouseEnter);
            this.lblInicio.MouseLeave += new System.EventHandler(this.btnInicio_MouseLeave);
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.barraTitulo.Controls.Add(this.lblNavegador);
            this.barraTitulo.Controls.Add(this.label2);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1220, 40);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // lblNavegador
            // 
            this.lblNavegador.AutoSize = true;
            this.lblNavegador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNavegador.Font = new System.Drawing.Font("Ubuntu", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavegador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNavegador.Location = new System.Drawing.Point(3, -3);
            this.lblNavegador.Name = "lblNavegador";
            this.lblNavegador.Size = new System.Drawing.Size(150, 47);
            this.lblNavegador.TabIndex = 1;
            this.lblNavegador.Text = "Inicio >";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(1076, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "LitRest℠";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Controls.Add(this.productos1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 40);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1220, 660);
            this.panelContenedor.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(45, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(30, 30);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Image = global::litRest.Properties.Resources.home;
            this.btnInicio.Location = new System.Drawing.Point(10, 128);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(60, 60);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 4;
            this.btnInicio.TabStop = false;
            this.btnInicio.MouseEnter += new System.EventHandler(this.btnInicio_MouseEnter);
            this.btnInicio.MouseLeave += new System.EventHandler(this.btnInicio_MouseLeave);
            // 
            // btnEstadis
            // 
            this.btnEstadis.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEstadis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadis.Image = global::litRest.Properties.Resources.bar_chart;
            this.btnEstadis.Location = new System.Drawing.Point(10, 224);
            this.btnEstadis.Name = "btnEstadis";
            this.btnEstadis.Size = new System.Drawing.Size(60, 60);
            this.btnEstadis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEstadis.TabIndex = 2;
            this.btnEstadis.TabStop = false;
            this.btnEstadis.MouseEnter += new System.EventHandler(this.btnEstadis_MouseEnter);
            this.btnEstadis.MouseLeave += new System.EventHandler(this.btnEstadis_MouseLeave);
            // 
            // btnProdu
            // 
            this.btnProdu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnProdu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdu.Image = global::litRest.Properties.Resources.box;
            this.btnProdu.Location = new System.Drawing.Point(10, 320);
            this.btnProdu.Name = "btnProdu";
            this.btnProdu.Size = new System.Drawing.Size(60, 60);
            this.btnProdu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnProdu.TabIndex = 3;
            this.btnProdu.TabStop = false;
            this.btnProdu.MouseEnter += new System.EventHandler(this.btnProdu_MouseEnter);
            this.btnProdu.MouseLeave += new System.EventHandler(this.btnProdu_MouseLeave);
            // 
            // btnUser
            // 
            this.btnUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Image = global::litRest.Properties.Resources.stick_man;
            this.btnUser.Location = new System.Drawing.Point(10, 416);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(60, 60);
            this.btnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUser.TabIndex = 2;
            this.btnUser.TabStop = false;
            this.btnUser.MouseEnter += new System.EventHandler(this.btnUser_MouseEnter);
            this.btnUser.MouseLeave += new System.EventHandler(this.lblUser_MouseLeave);
            // 
            // btnAjustes
            // 
            this.btnAjustes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustes.Image = global::litRest.Properties.Resources.levels;
            this.btnAjustes.Location = new System.Drawing.Point(10, 512);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(60, 60);
            this.btnAjustes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAjustes.TabIndex = 1;
            this.btnAjustes.TabStop = false;
            this.btnAjustes.MouseEnter += new System.EventHandler(this.btnAjustes_MouseEnter_1);
            this.btnAjustes.MouseLeave += new System.EventHandler(this.btnAjustes_MouseLeave);
            // 
            // btnOcultar
            // 
            this.btnOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultar.Image = global::litRest.Properties.Resources.minimize;
            this.btnOcultar.Location = new System.Drawing.Point(5, 5);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(30, 30);
            this.btnOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOcultar.TabIndex = 0;
            this.btnOcultar.TabStop = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // productos1
            // 
            this.productos1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productos1.Location = new System.Drawing.Point(0, 0);
            this.productos1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productos1.Name = "productos1";
            this.productos1.Size = new System.Drawing.Size(1220, 660);
            this.productos1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.menuVertical);
            this.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEstadis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnOcultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnAjustes;
        private System.Windows.Forms.PictureBox btnProdu;
        private System.Windows.Forms.PictureBox btnUser;
        private System.Windows.Forms.Label lblAjustes;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.PictureBox btnEstadis;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblProdu;
        private System.Windows.Forms.Label lblEstadis;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblNavegador;
        private productos productos1;
    }
}

