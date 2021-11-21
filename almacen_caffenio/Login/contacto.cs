using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace almacen_caffenio.Login
{
    public partial class contacto : Form
    {
        public contacto()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
