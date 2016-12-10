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
        private drawMenuCategory menu;
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
                panelOfOrderForms.Visible = false;
                panelOfMenuContent.Visible = true;
                panelDeliveryInfo.Visible = true;
                panelOrderTree.Visible = true;
                newOrder = null;
                newOrder = new Order();
                newOrder.getTypeOfOrder = "DOWOZ";
                newOrder.getDelivery = newDeliveryInfo;
                menu = new drawMenuCategory();
                menu.addCategoriesToPanel(panelOfMenuContent, newOrder);
                menu.addTreeViewToPanel(panelOrderTree);
                foreach (Label label in panelDeliveryInfo.Controls.OfType<Label>())
                {
                    if (label.Text == "NR TELEFONU:") label.Text += " " + newDeliveryInfo.getPhoneNumber;
                    if (label.Text == "ADRES:") label.Text += " " + newDeliveryInfo.getStreet + "   " + newDeliveryInfo.getStreetNumber + " / " + newDeliveryInfo.getFlatNumber;
                    if (label.Text == "FORMA PŁATNOŚCI:") label.Text += " " + newDeliveryInfo.getPayForm;
                }
                panelDeliveryInfo.Visible = true;
                panelAllOrders.Visible = false;
            }

        }

        private void lokalButton_Click(object sender, EventArgs e)
        {
            panelOfOrderForms.Visible = false;
            panelAllOrders.Visible = false;
            panelOfMenuContent.Visible = true;
            panelOrderTree.Visible = true;
            newOrder = null;
            newOrder = new Order();
            newOrder.getTypeOfOrder = "LOKAL";
            menu = new drawMenuCategory();
            menu.addCategoriesToPanel(panelOfMenuContent, newOrder);
            menu.addTreeViewToPanel(panelOrderTree);

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
            foreach (Label label in panelDeliveryInfo.Controls.OfType<Label>())
            {
                newDeliveryInfo = newDelivery.getDelivery;
                if (label.Text.Contains("NR TELEFONU:")) label.Text = "NR TELEFONU: " + newDeliveryInfo.getPhoneNumber;
                if (label.Text.Contains("ADRES:")) label.Text = "ADRES: " + newDeliveryInfo.getStreet + "   " + newDeliveryInfo.getStreetNumber + " / " + newDeliveryInfo.getFlatNumber;
                if (label.Text.Contains("FORMA PŁATNOŚCI:")) label.Text = "FORMA PŁATNOŚCI: " + newDeliveryInfo.getPayForm;
            }
            panelDeliveryInfo.Visible = true;
            
        }

        private void EndOfTheOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KURWA JESTEM");
            panelOfOrderForms.Visible = true;
            panelOfMenuContent.SendToBack();
            
            panelDeliveryInfo.Visible = false;
            panelOrderTree.Visible = false;
            panelAllOrders.Visible = true;
            panelAllOrders.BringToFront();
            Point position = new Point(0, 0);
            
            orderButton button = new orderButton(newOrder);

            position.X = panelAllOrders.Controls.Count * 85;
            if (position.X > 580)
            {
                position.Y = (panelAllOrders.Controls.Count / 10) * 85;
            }
            button.Location = position;
            panelAllOrders.Controls.Add(button);
            
        }
    }
}
