using System;
using MySqlConnector;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace almacen_caffenio.inventario
{
    public partial class Inventarios : Form
    {
        public Inventarios()
        {
            InitializeComponent();
            cargarProductos();
            tabla_inventarios.Columns.Clear();
            tabla_inventarios.DataSource = null;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pantalla_principal new_windows = new pantalla_principal();
            new_windows.Show();
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                if (comboBox1.SelectedItem.ToString() == "Productos")
                {
                    inventario.add_producto nueva_ventana = new inventario.add_producto();
                    nueva_ventana.Show();
                }
                else
                if (comboBox1.SelectedItem.ToString() == "Proveedores")
                {
                    inventario.add_proveedor nueva_ventana = new inventario.add_proveedor();
                    nueva_ventana.Show();
                }

                    
            } else
            {
                MessageBox.Show("Seleccione tabla.");
            }
                
        }

        public void cargarProductos()
        {
            try
            {
                DataTable dt = new DataTable();

                String server = "127.0.0.1";
                String user = "root";
                String database = "almacencaffenio";
                MySqlConnection mySqlConnection =
                    new MySqlConnection("server=" + server + "; user=" + user + "; database=" + database + "; SSL mode=none");
                mySqlConnection.Open();
                String query = "select * from productos";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                dt.Load(mySqlDataReader);
                if (dt.Rows.Count > 0)
                {
                    tabla_inventarios.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        public void cargarProveedores()
        {
            try
            {
                DataTable dt = new DataTable();

                String server = "127.0.0.1";
                String user = "root";
                String database = "almacencaffenio";
                MySqlConnection mySqlConnection =
                    new MySqlConnection("server=" + server + "; user=" + user + "; database=" + database + "; SSL mode=none");
                mySqlConnection.Open();
                String query = "select * from proveedores";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                dt.Load(mySqlDataReader);
                if (dt.Rows.Count > 0)
                {
                    tabla_inventarios.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                mySqlConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            tabla_inventarios.DataSource = null;
            if (selected == "Productos")
            {
                cargarProductos();
            } else 
            if (selected == "Proveedores")
            {
                cargarProveedores();
            }

        }

        private void edit_Click(object sender, EventArgs e)
        {
            
            if (tabla_inventarios.SelectedRows.Count > 0)
            {
                if(comboBox1.SelectedItem.ToString() == "Productos")
                {
                    agregar_nuevo.id = 0;
                    agregar_nuevo.nombre_prod = "";
                    agregar_nuevo.cantidad_prod = 0;
                    agregar_nuevo.id_proveedor_prod = 0;
                    agregar_nuevo.fecha_entrada_prd = DateTime.Now;
                    agregar_nuevo.precio_unit_prod = 0.00;
                    int selectedrowIndex = tabla_inventarios.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = tabla_inventarios.Rows[selectedrowIndex];
                    //ID_producto
                    String id_prod = Convert.ToString(selectedRow.Cells["id_producto"].Value);
                    agregar_nuevo.id = Int32.Parse(id_prod);
                    //nombre
                    agregar_nuevo.nombre_prod = Convert.ToString(selectedRow.Cells["nombre"].Value);
                    //cantidad
                    agregar_nuevo.cantidad_prod = Convert.ToInt32(selectedRow.Cells["cantidad"].Value);
                    //id_proveedor
                    agregar_nuevo.id_proveedor_prod = Convert.ToInt32(selectedRow.Cells["id_proveedor"].Value);
                    //nombre_proveedor
                    agregar_nuevo.fecha_entrada_prd = Convert.ToDateTime(selectedRow.Cells["fecha_entrada"].Value);
                    //precio unitario
                    agregar_nuevo.precio_unit_prod = Convert.ToDouble(selectedRow.Cells["precio_unitario"].Value);

                    inventario.edit_producto nueva_ventana = new inventario.edit_producto();
                    nueva_ventana.Show();

                } else if (comboBox1.SelectedItem.ToString() == "Proveedores")
                {
                    agregar_nuevo.id_proveedor = 0;
                    agregar_nuevo.nombre_proveedor = "";
                    agregar_nuevo.telefono_prov = 0;
                    agregar_nuevo.correo_prov = "";
                    int selectedrowIndex = tabla_inventarios.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = tabla_inventarios.Rows[selectedrowIndex];
                    //ID proveedor
                    String id_prov = Convert.ToString(selectedRow.Cells["id_proveedor"].Value);
                    agregar_nuevo.id = Int32.Parse(id_prov);
                    //nombre proveedor
                    agregar_nuevo.nombre_proveedor = Convert.ToString(selectedRow.Cells["nombre"].Value);
                    //telefono 
                    agregar_nuevo.telefono_prov = Convert.ToInt32(selectedRow.Cells["telefono"].Value);
                    //correo
                    agregar_nuevo.correo_prov = Convert.ToString(selectedRow.Cells["correo"].Value);

                    inventario.edit_proveedor nueva_ventana = new inventario.edit_proveedor();
                    nueva_ventana.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Seleccione registro a editar.");
            }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (tabla_inventarios.SelectedRows.Count > 0)
            {
                if (comboBox1.SelectedItem.ToString() == "Productos")
                {
                    try
                    {
                        int selectedrowIndex = tabla_inventarios.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = tabla_inventarios.Rows[selectedrowIndex];
                        //ID_producto
                        String id_prod = Convert.ToString(selectedRow.Cells["id_producto"].Value);
                        String server = "127.0.0.1";
                        String user = "root";
                        String database = "almacencaffenio";
                        MySqlConnection mySqlConnection =
                            new MySqlConnection("server=" + server + "; user=" + user + "; database=" + database + "; SSL mode=none");
                        mySqlConnection.Open();
                        String query = "delete from productos where id_producto="+id_prod+";";
                        MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Se borró el registro.");
                        mySqlConnection.Close();
                        cargarProductos();


                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString());
                    }
                } else 
                if (comboBox1.SelectedItem.ToString() == "Proveedores")
                {
                    try
                    {
                        int selectedrowIndex = tabla_inventarios.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = tabla_inventarios.Rows[selectedrowIndex];
                        //ID proveedor
                        String id_prov = Convert.ToString(selectedRow.Cells["id_proveedor"].Value);
                        String server = "127.0.0.1";
                        String user = "root";
                        String database = "almacencaffenio";
                        MySqlConnection mySqlConnection =
                            new MySqlConnection("server=" + server + "; user=" + user + "; database=" + database + "; SSL mode=none");
                        mySqlConnection.Open();
                        String query = "delete from proveedores where id_proveedor=" + id_prov + ";";
                        MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Se borró el registro.");
                        mySqlConnection.Close();
                        cargarProveedores();


                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione registro a borrar.");
            }
        }

        private void Inventarios_Activated(object sender, EventArgs e)
        {
            if (agregar_nuevo.updated == true)
            {
                if (comboBox1.SelectedItem.ToString() == "Productos")
                {
                    cargarProductos();
                    agregar_nuevo.updated = false;
                    this.Show();
                }
                else if (comboBox1.SelectedItem.ToString() == "Proveedores")
                {
                    cargarProveedores();
                    agregar_nuevo.updated = false;
                    this.Show();
                }
            }
        }

        private void Inventarios_Load(object sender, EventArgs e)
        {

        }
    }
}
