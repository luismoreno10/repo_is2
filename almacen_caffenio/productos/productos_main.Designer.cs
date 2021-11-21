
namespace almacen_caffenio.productos
{
    partial class productos_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productos_main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_frame = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ing = new System.Windows.Forms.TextBox();
            this.txt_preparacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_frame)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::almacen_caffenio.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(906, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(36, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 56);
            this.panel1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Producto1",
            "Producto2",
            "Producto3"});
            this.comboBox1.Location = new System.Drawing.Point(247, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(662, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione un producto";
            // 
            // pic_frame
            // 
            this.pic_frame.BackColor = System.Drawing.Color.Transparent;
            this.pic_frame.Image = global::almacen_caffenio.Properties.Resources.menu_rockaccino_grande;
            this.pic_frame.Location = new System.Drawing.Point(36, 251);
            this.pic_frame.Name = "pic_frame";
            this.pic_frame.Size = new System.Drawing.Size(233, 300);
            this.pic_frame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_frame.TabIndex = 3;
            this.pic_frame.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(302, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingredientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(635, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preparación";
            // 
            // txt_ing
            // 
            this.txt_ing.AcceptsReturn = true;
            this.txt_ing.AcceptsTab = true;
            this.txt_ing.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ing.Location = new System.Drawing.Point(302, 251);
            this.txt_ing.Multiline = true;
            this.txt_ing.Name = "txt_ing";
            this.txt_ing.ReadOnly = true;
            this.txt_ing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ing.Size = new System.Drawing.Size(310, 350);
            this.txt_ing.TabIndex = 7;
            // 
            // txt_preparacion
            // 
            this.txt_preparacion.AcceptsReturn = true;
            this.txt_preparacion.AcceptsTab = true;
            this.txt_preparacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_preparacion.Location = new System.Drawing.Point(635, 251);
            this.txt_preparacion.Multiline = true;
            this.txt_preparacion.Name = "txt_preparacion";
            this.txt_preparacion.ReadOnly = true;
            this.txt_preparacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_preparacion.Size = new System.Drawing.Size(310, 350);
            this.txt_preparacion.TabIndex = 8;
            // 
            // productos_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::almacen_caffenio.Properties.Resources.ventana1;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.txt_preparacion);
            this.Controls.Add(this.txt_ing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic_frame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "productos_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_frame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_frame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ing;
        private System.Windows.Forms.TextBox txt_preparacion;
    }
}