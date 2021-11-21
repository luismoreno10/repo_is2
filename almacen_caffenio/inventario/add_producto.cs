using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace almacen_caffenio.inventario
{
    public partial class add_producto : Form
    {
        public add_producto()
        {
            InitializeComponent();
            cargaCombo();
            int  ultimo = 0;
            txt_id.Text = getLastID(ultimo).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargaCombo()
        {
            try
            {
                String server = "127.0.0.1";
                String user = "root";
                String database = "almacencaffenio";
                MySqlConnection connection = new MySqlConnection("server=" + server + "; user=" + user + "; database=" + database + "; SSL mode=none");
                connection.Open();
                string query = "select * from proveedores";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    combo_proveedor.Items.Add(reader.GetString("nombre"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void save_Click(object sender, EventArgs e)
        {
            String date = fecha_entrada.Value.ToString("yyyy-MM-dd");
            int id = Int32.Parse(txt_id.Text);
            String name = txt_name.Text;
            int cant = Int32.Parse(txt_cantidad.Text);
            String nombre_proveedor = combo_proveedor.SelectedItem.ToString();
            Double precio_un = Double.Parse(txt_precio.Text);
            String server = "127.0.0.1";
            String user = "root";
            String database = "almacencaffenio";
            MySqlConnection mySqlConnection =
                new MySqlConnection("server=" + server + "; user=" + user + "; database=" + database + "; SSL mode=none");
            mySqlConnection.Open();
            String query = "insert into productos (`id_producto`, `nombre`, `cantidad`, `id_proveedor`, `fecha_entrada`, `precio_unitario`) " +
                "values ('"+id+"', '"+ name + "', '"+ cant+ "', '"+ nombre_proveedor + "', '"+ date+ "', '"+precio_un+ "')";
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            MessageBox.Show("Se agregó el registro.");
            mySqlConnection.Close();
            agregar_nuevo.updated = true;
            this.Close();
        }

        private int getLastID(int ultimo)
        {
            try
            {
                String server = "127.0.0.1";
                String user = "root";
                String database = "almacencaffenio";
                MySqlConnection connection = new MySqlConnection("server=" + server + "; user=" + user + "; database=" + database + "; SSL mode=none");
                connection.Open();
                string query = "SELECT * FROM productos ORDER BY id_producto DESC LIMIT 1;";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    ultimo = reader.GetInt32("id_producto")+1;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ultimo;
        }



    }
}
