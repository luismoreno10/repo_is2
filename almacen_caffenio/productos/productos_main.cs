using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace almacen_caffenio.productos
{
    public partial class productos_main : Form
    {
        public productos_main()
        {
            InitializeComponent();
            TextBox txt_ing = new TextBox();
            TextBox txt_preparacion = new TextBox();
            txt_ing.ScrollBars = ScrollBars.Vertical;
            txt_ing.Multiline = true;
            //txt_ing.WordWrap = true;
            txt_ing.AutoSize = false;
            txt_preparacion.Multiline = true;
            //txt_preparacion.WordWrap = true;
            txt_preparacion.AutoSize = false;
            txt_preparacion.ScrollBars = ScrollBars.Vertical;
            pic_frame.Image = null;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pantalla_principal new_windows = new pantalla_principal();
            new_windows.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Producto1")
            {
                pic_frame.Image = Properties.Resources.menu_americano_grande;
                pic_frame.Refresh();
                txt_ing.Text = textos.producto1_ingredientes;
                txt_preparacion.Text = textos.producto1_preparacion;


            } else if (comboBox1.SelectedItem.ToString() == "Producto2")
            {
                pic_frame.Image = Properties.Resources.menu_kfreeze_grande_ni;
                pic_frame.Refresh();
                txt_ing.Text = textos.producto2_ingredientes;
                txt_preparacion.Text = textos.producto2_preparacion;

            } else if (comboBox1.SelectedItem.ToString() == "Producto3")
            {
                pic_frame.Image = Properties.Resources.menu_rockaccino_grande;
                pic_frame.Refresh();
                txt_ing.Text = textos.producto3_ingredientes;
                txt_preparacion.Text = textos.producto3_preparacion;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
