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
    public partial class user : UserControl
    {
        SqlConnection conexion;
        SqlDataReader lector;
        SqlCommand query;

        public user()
        {
            InitializeComponent();
            conexionSQL();
            refrescar();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txbUser.TextLength == 0 || txbNombre.TextLength == 0 || txbApellido.TextLength == 0 || txbPassword.TextLength == 0 ||
                txbPassword2.TextLength == 0 || cbPuesto.Text == "Seleccionar..." || cbPuesto.Text == "")
            {
                MessageBox.Show("Rellena todos los campos", "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(txbPassword.Text == txbPassword2.Text)
                {
                    query = new SqlCommand("INSERT INTO Trabajador(Usuario, pass, Nombre, Apellido, Puesto) VALUES (\'" + txbUser.Text + "\', \'" + txbPassword.Text + "\', " +
                   "\'" + txbNombre.Text + "\', \'" + txbApellido.Text + "\', \'" + cbPuesto.Text + "\')", conexion);
                    lector = query.ExecuteReader();
                    MessageBox.Show("Datos insertados correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    lector.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no son iguales", "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void refrescar()
        {
            try
            {
                query = new SqlCommand("SELECT Usuario, Nombre, Puesto FROM Trabajador", conexion);
                lector = query.ExecuteReader();
                while (lector.Read())
                {
                    string[] row ={
                        lector.GetValue(0).ToString(),
                        lector.GetValue(1).ToString(),
                        lector.GetValue(2).ToString()
                    };
                    ListViewItem lisItem = new ListViewItem(row);
                    lsUsers.Items.Add(lisItem);
                }
                lector.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refrescar();
        }
    }
}
