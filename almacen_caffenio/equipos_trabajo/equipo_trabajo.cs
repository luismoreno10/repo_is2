using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace almacen_caffenio.equipos_trabajo
{
    public partial class equipo_trabajo : Form
    {
        public equipo_trabajo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pantalla_principal new_windows = new pantalla_principal();
            new_windows.Show();
            this.Close();
        }
    }
}
