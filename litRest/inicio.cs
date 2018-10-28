using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace litRest
{
    public partial class inicio : UserControl
    {
        bool cocina, mesero, caja;
        public inicio()
        {
            InitializeComponent();
            cocina = mesero = caja = false;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(255, 255, 255);
            panel1.BackColor = Color.DarkOrange;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Orange;

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkOrange;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Orange;

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.DarkOrange;

        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Orange;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.DarkOrange;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Orange;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btnCaja();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnCaja();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            btnCaja();
        }

        private void btnCaja()
        {
            picAct1.Visible = !picAct1.Visible;
            picDes1.Visible = !picDes1.Visible;
            caja = !caja;
            if (caja == true)
                button1.Text = "Cerrar Caja";
            else
                button1.Text = "Abrir Caja";
        }

        private void btnCocina()
        {
            picAct2.Visible = !picAct2.Visible;
            picDes2.Visible = !picDes2.Visible;
            cocina = !cocina;
            if (cocina == true)
                button2.Text = "Cerrar Cocina";
            else
                button2.Text = "Abrir Cocina";
        }

        private void btnMesero()
        {
            picAct3.Visible = !picAct3.Visible;
            picDes3.Visible = !picDes3.Visible;
            mesero = !mesero;
            if (mesero == true)
                button3.Text = "Cerrar Mesero";
            else
                button3.Text = "Abrir Mesero";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            btnCocina();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnCocina();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            btnMesero();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnMesero();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("ddd").ToUpper() + " - " + DateTime.Now.ToShortDateString() + " - " 
                + DateTime.Now.ToString("hh:mm");
         
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            btnCocina();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            btnMesero();
        }
    }
}
