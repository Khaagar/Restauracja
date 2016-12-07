using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracja2WForm
{
    public partial class DeliveryForm : Form
    {
        DeliveryInfo delivery = null;
        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            
        }

        private void normalButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void normalButton1_Click(object sender, EventArgs e)
        {
            delivery = new DeliveryInfo(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            Close();
        }
        public DeliveryInfo getDelivery
        {
            get { return delivery; }
        }
    }
}
