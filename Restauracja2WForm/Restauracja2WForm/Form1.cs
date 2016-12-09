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
    public partial class Form1 : Form
    {
        private Order newOrder;
        private DeliveryInfo newDeliveryInfo;
        private DeliveryForm newDelivery;
        public Form1()
        {
            InitializeComponent();
        }


        private void dowozButton_Click(object sender, EventArgs e)
        {
            List<Label> labelList = new List<Label>();
            newDelivery = new DeliveryForm();
            newDelivery.ShowDialog();
            if (newDelivery.getDelivery != null)
            {
                newDeliveryInfo = newDelivery.getDelivery;
                panel1.Visible = false;
                newOrder = null;
                newOrder = new Order();
                newOrder.getDelivery = newDeliveryInfo;
                drawMenuCategory menu = new drawMenuCategory();
                menu.addCategoriesToPanel(panel2, newOrder);
                menu.addTreeViewToPanel(panel4);
                foreach (Label label in panel3.Controls.OfType<Label>())
                {
                    if (label.Text == "NR TELEFONU:") label.Text += " " + newDeliveryInfo.getPhoneNumber;
                    if (label.Text == "ADRES:") label.Text += " " + newDeliveryInfo.getStreet + "   " + newDeliveryInfo.getStreetNumber + " / " + newDeliveryInfo.getFlatNumber;
                    if (label.Text == "FORMA PŁATNOŚCI:") label.Text += " " + newDeliveryInfo.getPayForm;
                    
                    
                }
                panel3.Visible = true;
            }

        }

        private void lokalButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            newOrder = null;
            newOrder = new Order();
            drawMenuCategory menu = new drawMenuCategory();
            menu.addCategoriesToPanel(panel2, newOrder);
            menu.addTreeViewToPanel(panel4);

        }

        private void normalButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void normalButton3_Click(object sender, EventArgs e)
        {

        }

        private void normalButton1_Click(object sender, EventArgs e)
        {

        }

        private void normalButton1_Click_1(object sender, EventArgs e)
        {
            newDelivery.ShowDialog();
            foreach (Label label in panel3.Controls.OfType<Label>())
            {
                newDeliveryInfo = newDelivery.getDelivery;
                if (label.Text.Contains("NR TELEFONU:")) label.Text = "NR TELEFONU: " + newDeliveryInfo.getPhoneNumber;
                if (label.Text.Contains("ADRES:")) label.Text = "ADRES: " + newDeliveryInfo.getStreet + "   " + newDeliveryInfo.getStreetNumber + " / " + newDeliveryInfo.getFlatNumber;
                if (label.Text.Contains("FORMA PŁATNOŚCI:")) label.Text = "FORMA PŁATNOŚCI: " + newDeliveryInfo.getPayForm;
            }
            panel3.Visible = true;
        }
    }
}
