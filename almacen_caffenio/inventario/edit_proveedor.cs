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

    public partial class edit_proveedor : Form
    {
        public edit_proveedor()
        {
            InitializeComponent();
   
            txt_id.Text = agregar_nuevo.id.ToString();
            txt_name.Text = agregar_nuevo.nombre_proveedor.ToString();
            txt_telefono.Text = agregar_nuevo.telefono_prov.ToString();
            txt_correo.Text = agregar_nuevo.correo_prov.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                String server = "127.0.0.1";
                String user = "root";
                String database = "almacencaffenio";
                MySqlConnection mySqlConnection =
                    new MySqlConnection("server=" + server + "; user=" + user + "; database=" + database + "; SSL mode=none");
                mySqlConnection.Open();
                String query = "update proveedores set nombre='" + txt_name.Text + "', telefono= '" + txt_telefono.Text + "', correo= '" + txt_correo.Text +
                    "' where id_proveedor=" + txt_id.Text + ";";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MessageBox.Show(query);
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


