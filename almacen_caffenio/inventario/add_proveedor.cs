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
    public partial class add_proveedor : Form
    {
        public add_proveedor()
        {
            InitializeComponent();
            int ultimo = 0;
            txt_id.Text = getLastID(ultimo).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void save_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txt_id.Text);
            String name = txt_name.Text;
            String tel = txt_telefono.Text;
            String correo = txt_correo.Text;

            String server = "127.0.0.1";
            String user = "root";
            String database = "almacencaffenio";
            MySqlConnection mySqlConnection =
                new MySqlConnection("server=" + server + "; user=" + user + "; database=" + database + "; SSL mode=none");
            mySqlConnection.Open();
            String query = "insert into proveedores (`id_proveedor`, `nombre`, `telefono`, `correo`) values " +
                "('"+ id + "','"+ name + "','"+ tel + "','"+ correo + "')";
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
                string query = "SELECT * FROM proveedores ORDER BY id_proveedor DESC LIMIT 1;";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ultimo = reader.GetInt32("id_proveedor") + 1;
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
