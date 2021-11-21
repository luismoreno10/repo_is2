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

    public partial class edit_producto : Form
    {
        public edit_producto()
        {
            InitializeComponent();
            cargaCombo();
            txt_id.Text = agregar_nuevo.id.ToString();
            txt_name.Text = agregar_nuevo.nombre_prod.ToString();
            txt_cantidad.Text = agregar_nuevo.cantidad_prod.ToString();
            fecha_entrada.Value = agregar_nuevo.fecha_entrada_prd;
            txt_precio.Text = agregar_nuevo.precio_unit_prod.ToString();

        }
        public void cargaCombo()
        {
            try
            {
                int proveedor_id = Int32.Parse(agregar_nuevo.id_proveedor_prod.ToString());
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
                    combo_proveedor.Items.Add(reader.GetInt32("id_proveedor"));
                }

                connection.Close();

                combo_proveedor.SelectedIndex = combo_proveedor.Items.IndexOf(proveedor_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            
            String id_proveedor_selected = combo_proveedor.SelectedItem.ToString();
            String date = fecha_entrada.Value.ToString("yyyy-MM-dd");

            try
            {
                String server = "127.0.0.1";
                String user = "root";
                String database = "almacencaffenio";
                MySqlConnection mySqlConnection =
                    new MySqlConnection("server=" + server + "; user=" + user + "; database=" + database + "; SSL mode=none");
                mySqlConnection.Open();
                String query = "update productos set nombre='" + txt_name.Text + "', cantidad= " + txt_cantidad.Text + ", id_proveedor= " + id_proveedor_selected + "" +
                    ", fecha_entrada = '" + date + "', precio_unitario= '" + txt_precio.Text +
                    "' where id_producto=" + txt_id.Text + ";";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Se actualizó el registro.");
                mySqlConnection.Close();
                agregar_nuevo.updated = true;
                this.Close();
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }

    

}


