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
        private List<Order> listOrder = new List<Order>();
        private DeliveryInfo newDeliveryInfo;
        private DeliveryForm newDelivery;
        private FinalizeOrder newFinalizeOrder;
        private int clickedOrder = 0;
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
                Order order = new Order();
                listOrder.Add(order);
                listOrder.Last().getTypeOfOrder = "DOWOZ";
                listOrder.Last().getDelivery = newDeliveryInfo;
                drawMenuCategory menu = new drawMenuCategory(listOrder.Last());
                menu.addCategoriesToPanel(panelOfMenuContent);
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
            Order order = new Order();
            listOrder.Add(order);
            listOrder.Last().getTypeOfOrder = "LOKAL";
            drawMenuCategory menu = new drawMenuCategory(listOrder.Last());
            menu.addCategoriesToPanel(panelOfMenuContent);
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
            
            panelOfOrderForms.Visible = true;
            panelOfMenuContent.SendToBack();
            panelOfMenuContent.Controls.OfType<menuButton>().Where(i => i.Tag == "CATEGORY").ToList().ForEach(i => panelOfMenuContent.Controls.Remove(i));
            panelOfMenuContent.Controls.OfType<menuButton>().Where(i => i.Tag == "PRODUCT").ToList().ForEach(i => panelOfMenuContent.Controls.Remove(i));

            panelDeliveryInfo.Visible = false;
            panelOrderTree.Visible = false;
            panelOrderTree.Controls.Clear();
            panelAllOrders.Visible = true;
            panelAllOrders.BringToFront();
            Point position = new Point(0, 0);
            if (listOrder.Last().getToEdit == false)
            {
                orderButton button = new orderButton(listOrder.Last());
                button.getId = listOrder.IndexOf(listOrder.Last());
                position.X = panelAllOrders.Controls.Count * 85;
                if (position.X > 580)
                {
                    position.Y = (panelAllOrders.Controls.Count / 10) * 85;
                }
                button.Location = position;
                button.Click += OrderButton_Click;
                panelAllOrders.Controls.Add(button);
                listOrder.Last().getToEdit = true;
                
            }
            else
            {
                orderButton button = new orderButton(listOrder.ElementAt(clickedOrder));
                position.X = panelAllOrders.Controls[clickedOrder].Location.X;
                position.Y = panelAllOrders.Controls[clickedOrder].Location.Y;
                button.Location = position;
                button.getId = clickedOrder;
                button.Click += OrderButton_Click;
                panelAllOrders.Controls.RemoveAt(clickedOrder);
                panelAllOrders.Controls.Add(button);
                panelAllOrders.Controls.SetChildIndex(button, clickedOrder);
            }

            

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            orderButton b = sender as orderButton;
            panelOfOrderForms.Visible = false;
            panelAllOrders.Visible = false;
            panelOfMenuContent.Visible = true;
            panelOrderTree.Visible = true;
            drawMenuCategory menu = new drawMenuCategory(b.getOrder);
            menu.updateTreeViewForExistingOrder(b.getOrder);
            menu.addCategoriesToPanel(panelOfMenuContent);
            menu.addTreeViewToPanel(panelOrderTree);
            clickedOrder = b.getId;
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz skasować zamówienie?", "UWAGA!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                panelOfOrderForms.Visible = true;
                panelOfMenuContent.SendToBack();
                panelOfMenuContent.Controls.OfType<menuButton>().Where(i => i.Tag == "CATEGORY").ToList().ForEach(i => panelOfMenuContent.Controls.Remove(i));
                panelOfMenuContent.Controls.OfType<menuButton>().Where(i => i.Tag == "PRODUCT").ToList().ForEach(i => panelOfMenuContent.Controls.Remove(i));

                panelDeliveryInfo.Visible = false;
                panelOrderTree.Visible = false;
                panelOrderTree.Controls.Clear();
                panelAllOrders.Visible = true;
                panelAllOrders.BringToFront();
                panelAllOrders.Controls.RemoveAt(clickedOrder);
                listOrder.RemoveAt(clickedOrder);
                Point position = new Point(0, 0);
                foreach (orderButton button in panelAllOrders.Controls)
                {
                    if (button.getId > clickedOrder)
                    {
                        position.X = button.Location.X - 85;
                        button.Location = position;
                        button.getId--;
                    }
                }
            }
            
            
        }

        private void normalButton5_Click(object sender, EventArgs e)
        {
            newFinalizeOrder = new FinalizeOrder(listOrder.ElementAt(clickedOrder));
            newFinalizeOrder.ShowDialog();
        }
    }
}
