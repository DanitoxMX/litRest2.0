using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace litRest
{
    public partial class inicio : UserControl
    {
        bool cocina, mesero, caja;
        SqlConnection conexion;
        SqlCommand query;
        SqlDataReader lector;

        public inicio()
        {
            InitializeComponent();
            cocina = mesero = caja = false;
            //conexionSQL();
        }

        public void conexionSQL()
        {
            try
            {
                conexion = new SqlConnection("server=den1.mssql8.gear.host; database=litrest; user id=litrest; password=litrest_; initial catalog=litrest");
                conexion.Open();
                Console.WriteLine("Conexión establecida con base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
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


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if(txbAdd.TextLength == 0)
                MessageBox.Show("Rellena el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (verifica(txbAdd.Text))
                {
                    if (lisMeseroAct.Items.Contains(txbAdd.Text))
                        lisMeseroAct.Items.Remove(txbAdd.Text);
                    else
                        lisMeseroAct.Items.Add(txbAdd.Text);
                }
                else
                    MessageBox.Show("El mesero no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            btnCocina();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            btnMesero();
        }

        private bool verifica(string user)
        {
            try
            {
                bool found = false;
                query = new SqlCommand("SELECT Usuario FROM Trabajador WHERE Puesto = \'Mesero\'", conexion);
                lector = query.ExecuteReader();
                while (lector.Read())
                {
                    if (user == lector.GetValue(0).ToString())
                    {
                        found = true;
                        break;
                    }
                }
                lector.Close();
                return found;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
