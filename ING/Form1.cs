using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ING
{
    public partial class Mesas : Form
    {
        public Mesas()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void abrirmesasform(object mesasform)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form nuevo = mesasform as Form;
            nuevo.TopLevel = false;
            nuevo.Dock = DockStyle.Fill;
            this.panel.Controls.Add(nuevo);
            this.panel.Tag = nuevo;
            nuevo.Show();
        }

            private void button1_Click(object sender, EventArgs e)
        {
            abrirmesasform(new mesasform());
        }

        private void articulos_bt_Click(object sender, EventArgs e)
        {

        }
    }
}
