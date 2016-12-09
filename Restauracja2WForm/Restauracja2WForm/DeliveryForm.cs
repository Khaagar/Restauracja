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

        public DeliveryForm(DeliveryInfo delivery)
        {
            textBox1.Text = delivery.getPhoneNumber;
            textBox2.Text = delivery.getStreet;
            textBox3.Text = delivery.getStreetNumber;
            textBox4.Text = delivery.getFlatNumber;
            textBox5.Text = delivery.getAdditionalInformation;
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

            try
            {
                
                var checkedButton = this.Controls.OfType<RadioButton>()
                                                      .FirstOrDefault(r => r.Checked);
                delivery = new DeliveryInfo(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, checkedButton.Text);
                if (delivery.getPhoneNumber == null) throw new ArgumentNullException();
                if (delivery.getStreet == null) throw new ArgumentNullException();
                if (delivery.getPayForm == null) throw new ArgumentNullException();
                Close();
            }
            catch
            {
                MessageBox.Show("Wprowadź wymagane dane! ");
            }
            
        }
        public DeliveryInfo getDelivery
        {
            get { return delivery; }
        }
    }
}
