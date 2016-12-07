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
        public Form1()
        {
            InitializeComponent();
        }


        private void dowozButton_Click(object sender, EventArgs e)
        {
            
            DeliveryForm newDelivery = new DeliveryForm();
            newDelivery.ShowDialog();
            if (newDelivery.getDelivery != null)
            {
                panel1.Visible = false;
                newOrder = null;
                newOrder = new Order();
                drawMenuCategory menu = new drawMenuCategory();
                menu.addCategoriesToPanel(panel2, newOrder);
                menu.addTreeViewToPanel(panel4);
            }
            
        }

        private void lokalButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            newOrder = null;
            newOrder = new Order();
            drawMenuCategory menu = new drawMenuCategory();
            menu.addCategoriesToPanel(panel2,newOrder);
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
    }
}
