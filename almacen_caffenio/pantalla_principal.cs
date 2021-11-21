using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace almacen_caffenio
{
    public partial class pantalla_principal : Form
    {
        public pantalla_principal()
        {
            InitializeComponent();
        }

        private void pantalla_principal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            login ventana = new login();
            ventana.Show();
            this.Hide();
        }

        private void cambiar_imagen()
        {
            
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            inventario.Inventarios ventana = new inventario.Inventarios();
            ventana.Show();
            this.Close();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            productos.productos_main new_windows = new productos.productos_main();
            new_windows.Show();
            this.Close();
        }

        private void btn_equipoTrabajo_Click(object sender, EventArgs e)
        {
            equipos_trabajo.equipo_trabajo new_windows = new equipos_trabajo.equipo_trabajo();
            new_windows.Show();
            this.Close();
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            reportes.reportes_inventarios new_windows = new reportes.reportes_inventarios();
            new_windows.Show();
            this.Close();
        }
    }
}
