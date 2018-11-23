using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace litRest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string nombre;

        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAjustes_MouseEnter_1(object sender, EventArgs e)
        {
            btnAjustes.Width = btnAjustes.Height = 66;
            btnAjustes.Location = new Point(btnAjustes.Location.X - 3, btnAjustes.Location.Y - 3);
            lblAjustes.Location = new Point(lblAjustes.Location.X, lblAjustes.Location.Y + 3);
            lblAjustes.Font = new Font(lblAjustes.Font.Name, lblAjustes.Font.SizeInPoints, FontStyle.Underline);
            lblAjustes.Font = new Font(lblAjustes.Font.Name, lblAjustes.Font.SizeInPoints, FontStyle.Bold);
        }

        private void btnAjustes_MouseLeave(object sender, EventArgs e)
        {
            btnAjustes.Width = btnAjustes.Height = 60;
            btnAjustes.Location = new Point(btnAjustes.Location.X + 3, btnAjustes.Location.Y + 3);
            lblAjustes.Location = new Point(lblAjustes.Location.X, lblAjustes.Location.Y - 3);
            lblAjustes.Font = new Font(lblAjustes.Font.Name, lblAjustes.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnUser_MouseEnter(object sender, EventArgs e)
        {
            btnUser.Width = btnUser.Height = 66;
            btnUser.Location = new Point(btnUser.Location.X - 3, btnUser.Location.Y - 3);
            lblUser.Location = new Point(lblUser.Location.X, lblUser.Location.Y + 3);
            lblUser.Font = new Font(lblUser.Font.Name, lblUser.Font.SizeInPoints, FontStyle.Underline);
            lblUser.Font = new Font(lblUser.Font.Name, lblUser.Font.SizeInPoints, FontStyle.Bold);
        }

        private void lblUser_MouseLeave(object sender, EventArgs e)
        {
            btnUser.Width = btnUser.Height = 60;
            btnUser.Location = new Point(btnUser.Location.X + 3, btnUser.Location.Y + 3);
            lblUser.Location = new Point(lblUser.Location.X, lblUser.Location.Y - 3);
            lblUser.Font = new Font(lblUser.Font.Name, lblUser.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnProdu_MouseEnter(object sender, EventArgs e)
        {
            btnProdu.Width = btnProdu.Height = 66;
            btnProdu.Location = new Point(btnProdu.Location.X - 3, btnProdu.Location.Y - 3);
            lblProdu.Location = new Point(lblProdu.Location.X, lblProdu.Location.Y + 3);
            lblProdu.Font = new Font(lblProdu.Font.Name, lblProdu.Font.SizeInPoints, FontStyle.Underline);
            lblProdu.Font = new Font(lblProdu.Font.Name, lblProdu.Font.SizeInPoints, FontStyle.Bold);
        }

        private void btnProdu_MouseLeave(object sender, EventArgs e)
        {
            btnProdu.Width = btnProdu.Height = 60;
            btnProdu.Location = new Point(btnProdu.Location.X + 3, btnProdu.Location.Y + 3);
            lblProdu.Location = new Point(lblProdu.Location.X, lblProdu.Location.Y - 3);
            lblProdu.Font = new Font(lblProdu.Font.Name, lblProdu.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnEstadis_MouseEnter(object sender, EventArgs e)
        {
            btnEstadis.Width = btnEstadis.Height = 66;
            btnEstadis.Location = new Point(btnEstadis.Location.X - 3, btnEstadis.Location.Y - 3);
            lblEstadis.Location = new Point(lblEstadis.Location.X, lblEstadis.Location.Y + 3);
            lblEstadis.Font = new Font(lblEstadis.Font.Name, lblEstadis.Font.SizeInPoints, FontStyle.Underline);
            lblEstadis.Font = new Font(lblEstadis.Font.Name, lblEstadis.Font.SizeInPoints, FontStyle.Bold);
        }

        private void btnEstadis_MouseLeave(object sender, EventArgs e)
        {
            btnEstadis.Width = btnEstadis.Height = 60;
            btnEstadis.Location = new Point(btnEstadis.Location.X + 3, btnEstadis.Location.Y + 3);
            lblEstadis.Location = new Point(lblEstadis.Location.X, lblEstadis.Location.Y - 3);
            lblEstadis.Font = new Font(lblEstadis.Font.Name, lblEstadis.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnInicio_MouseEnter(object sender, EventArgs e)
        {
            btnInicio.Width = btnInicio.Height = 66;
            btnInicio.Location = new Point(btnInicio.Location.X - 3, btnInicio.Location.Y - 3);
            lblInicio.Location = new Point(lblInicio.Location.X, lblInicio.Location.Y + 3);
            lblInicio.Font = new Font(lblInicio.Font.Name, lblInicio.Font.SizeInPoints, FontStyle.Underline);
            lblInicio.Font = new Font(lblInicio.Font.Name, lblInicio.Font.SizeInPoints, FontStyle.Bold);
        }

        private void btnInicio_MouseLeave(object sender, EventArgs e)
        {
            btnInicio.Width = btnInicio.Height = 60;
            btnInicio.Location = new Point(btnInicio.Location.X + 3, btnInicio.Location.Y + 3);
            lblInicio.Location = new Point(lblInicio.Location.X, lblInicio.Location.Y - 3);
            lblInicio.Font = new Font(lblInicio.Font.Name, lblInicio.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            lblNavegador.Text = "Inicio >";
            picCursor.Location = new Point(0, 131);
            inicio1.Visible = true;
            estadistica1.Visible = false;
            productos1.Visible = false;
            user1.Visible = false;
            if (Program.iniciado)
                login1.Visible = false;
        }

        private void btnEstadis_Click(object sender, EventArgs e)
        {
            lblNavegador.Text = "Estadisticas >";
            picCursor.Location = new Point(0, 230);
            inicio1.Visible = false;
            estadistica1.Visible = true;
            productos1.Visible = false;
            user1.Visible = false;
            if (Program.iniciado)
                login1.Visible = false;
        }

        private void btnProdu_Click(object sender, EventArgs e)
        {
            lblNavegador.Text = "Productos >";
            picCursor.Location = new Point(0, 329);
            inicio1.Visible = false;
            estadistica1.Visible = false;
            productos1.Visible = true;
            user1.Visible = false;
            if (Program.iniciado)
                login1.Visible = false;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            lblNavegador.Text = "Usuarios >";
            picCursor.Location = new Point(0, 420);
            inicio1.Visible = false;
            estadistica1.Visible = false;
            productos1.Visible = false;
            user1.Visible = true;
            if (Program.iniciado)
                login1.Visible = false;
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            lblNavegador.Text = "Ajustes >";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("ddd").ToUpper() + " - " + DateTime.Now.ToShortDateString() + " - "
                + DateTime.Now.ToString("hh:mm");
            
        }
    }
}
