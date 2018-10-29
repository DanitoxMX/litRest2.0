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
    public partial class login : UserControl
    {
        string user = "";
        string pass = "";
        SqlConnection conexion;
        SqlDataReader lector;
        SqlCommand query;

        public login()
        {
            InitializeComponent();
            conexionSQL();
        }

        public void conexionSQL()
        {
            try
            {
                conexion = new SqlConnection("server=DANIEL-PC; database=litrest; integrated security=true");
                conexion.Open();
                Console.WriteLine("Conexión establecida con base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            txbLogUser.Text = "Usuario";
            txbLogPass.Text = "Contraseña";
            txbLogPass.PasswordChar = char.Parse("\0");
            txbLogUser.ForeColor = Color.Gray;
            txbLogPass.ForeColor = Color.Gray;
            btnLogin.Focus();
        }

        private void txbLogUser_MouseEnter(object sender, EventArgs e)
        {
            txbLogUser.Text = "";
            txbLogUser.ForeColor = Color.Black;
        }

        private void txbLogPass_MouseEnter(object sender, EventArgs e)
        {
            txbLogPass.Text = "";
            txbLogPass.ForeColor = Color.Black;
            txbLogPass.PasswordChar = '*';
        }

        private void txbLogUser_MouseLeave(object sender, EventArgs e)
        {
            user = txbLogUser.Text;
            if (txbLogUser.Equals("Usuario"))
            {
                txbLogUser.Text = "Usuario";
                txbLogUser.ForeColor = Color.Gray;
            }
            else
            {
                if (user.Equals(""))
                {
                    txbLogUser.Text = "Usuario";
                    txbLogUser.ForeColor = Color.Gray;
                }
                else
                {
                    txbLogUser.Text = user;
                    txbLogUser.ForeColor = Color.Black;
                }
            }
            label1.Focus();
        }

        private void txbLogPass_MouseLeave(object sender, EventArgs e)
        {
            pass = txbLogPass.Text;
            if (txbLogPass.Equals("Contraseña"))
            {
                txbLogPass.Text = "Contraseña";
                txbLogPass.ForeColor = Color.Gray;
                txbLogPass.PasswordChar = char.Parse("\0");

            }
            else
            {
                if (pass.Equals(""))
                {
                    txbLogPass.Text = "Contraseña";
                    txbLogPass.ForeColor = Color.Gray;
                    txbLogPass.PasswordChar = char.Parse("\0");

                }
                else
                {
                    txbLogPass.Text = pass;
                    txbLogPass.ForeColor = Color.Black;
                    txbLogPass.PasswordChar = '*';

                }
            }
            label1.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbLogPass.Text == "Contraseña" || txbLogUser.Text == "Usuario")
            {
                MessageBox.Show("Rellena todos los campos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (verifica(txbLogUser.Text))
                {
                    try
                    {
                        query = new SqlCommand("SELECT pass FROM Trabajador WHERE Usuario = \'" + txbLogUser.Text + "\'", conexion);
                        lector = query.ExecuteReader();
                        lector.Read();
                        if (lector.GetValue(0).ToString() == txbLogPass.Text)
                        {
                            MessageBox.Show("Se ha iniciado sesión", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                            MessageBox.Show("El usuario o la contraseña no son correctos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lector.Close();
                    }
                    catch (Exception)
                    {

                        throw;
                    }                    
                }
                else
                    MessageBox.Show("El usuario o la contraseña no son correctos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool verifica(string user)
        {
            try
            {
                bool found = false;
                query = new SqlCommand("SELECT Usuario FROM Trabajador", conexion);
                lector = query.ExecuteReader();
                while (lector.Read())
                {
                    if (txbLogUser.Text == lector.GetValue(0).ToString())
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
