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
    public partial class productos : UserControl
    {
        SqlConnection conexion;
        SqlCommand query;
        SqlDataReader lector;

        public productos()
        {
            InitializeComponent();
            conexionSQL();
            refresh();
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

        private void btnNuevoPro_Click(object sender, EventArgs e)
        {
            pnlNuevo.Visible = true;
            pnlModifica.Visible = false;
        }

        private void btnModificaPro_Click(object sender, EventArgs e)
        {
            if(txbIdProd.TextLength == 0)
            {
                MessageBox.Show("Coloque el ID del producto a modificar", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (verifica(txbIdProd.Text))
                {
                    pnlNuevo.Visible = false;
                    pnlModifica.Visible = true;
                    query = new SqlCommand("SELECT Producto FROM Producto WHERE idProducto = \'" + txbIdProd.Text
                        + "\'", conexion);
                    lector = query.ExecuteReader();
                    lector.Read();
                    txbNombre2.Text = lector.GetValue(0).ToString();
                    
                }
                else
                {
                    MessageBox.Show("ID del producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           
        }

        private bool verifica(string id)
        {
            try
            {
                bool found = false;
                query = new SqlCommand("SELECT idProducto FROM Producto", conexion);
                lector = query.ExecuteReader();
                while (lector.Read())
                {
                    if (id == lector.GetValue(0).ToString())
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

        private void refresh()
        {
            lsProduc.Items.Clear();
            try
            {
                query = new SqlCommand("SELECT * FROM Producto", conexion);
                lector = query.ExecuteReader();
                while (lector.Read())
                {
                    string[] row ={
                        lector.GetValue(0).ToString(),
                        lector.GetValue(1).ToString(),
                        lector.GetValue(2).ToString(),
                        lector.GetValue(3).ToString(),
                        lector.GetValue(4).ToString()
                    };
                    ListViewItem lisItem = new ListViewItem(row);
                    lsProduc.Items.Add(lisItem);
                }
                lector.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txbNombre1.TextLength == 0 || txbPrecio1.TextLength == 0 || txbDec1.TextLength == 0 || cbDispo1.Text == "Seleccionar...")
            {
                MessageBox.Show("Rellena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float precio = Convert.ToInt16(txbPrecio1.Text) + (Convert.ToInt16(txbDec1.Text) / 100);
                bool disp = false;

                if (cbDispo1.Text == "Si")
                    disp = true;
                else
                    disp = false;

                query = new SqlCommand("INSERT INTO Producto(Producto, Precio, Disponible) VALUES (\'" + txbNombre1.Text + "\', " +
                    "\'" + precio.ToString() + "\', \'" + disp + "\')", conexion);
                lector = query.ExecuteReader();

                lector.Close();
                MessageBox.Show("Producto agregado correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                refresh();
            }
        }

        private void btnEliminaPro_Click(object sender, EventArgs e)
        {
            if (txbIdProd.TextLength == 0)
            {
                MessageBox.Show("Coloque el ID del producto a modificar", "Rellena los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (verifica(txbIdProd.Text))
                {
                    query = new SqlCommand("DELETE FROM Producto WHERE idProducto = \'" + txbIdProd.Text + "\'", conexion);
                    lector = query.ExecuteReader();
                    lector.Close();
                    MessageBox.Show("Producto Eliminado", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("ID del producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnAgrega2_Click(object sender, EventArgs e)
        {
            if (txbNombre2.TextLength == 0 || txbPrecio2.TextLength == 0 || txbdec2.TextLength == 0 || cbDispo2.Text == "Seleccionar...")
            {
                MessageBox.Show("Rellena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float precio = Convert.ToInt16(txbPrecio2.Text) + (Convert.ToInt16(txbdec2.Text) / 100);
                bool disp = false;

                if (cbDispo2.Text == "Si")
                    disp = true;
                else
                    disp = false;

                query = new SqlCommand("UPDATE Producto SET Producto = \'" + txbNombre2.Text + "\', Precio = \'" + precio.ToString() + "\', " +
                    "Disponible = \'" + disp + "\' WHERE idProducto = \'" + txbIdProd.Text + "\'", conexion);
                lector = query.ExecuteReader();

                lector.Close();
                MessageBox.Show("Producto modificado correctamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                refresh();
            }
        }
    }
}
