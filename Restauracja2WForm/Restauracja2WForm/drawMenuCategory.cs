using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Restauracja2WForm
{
    class drawMenuCategory
    {
        private List<menuButton> buttons = new List<menuButton>();
        private Order order = new Order();
        private List<string> menuCategories = new menuCategory().getListOfCategories();
        private string clickedButton;
        private Panel panel = new Panel();


        public List<menuButton> getListOfMenuButtons()
        {
            buttons.Clear();
            foreach (string category in menuCategories)
            {
                buttons.Add(new menuButton(category));
                buttons.Last().Click += menuButtonCategory_Click;
            }
            return buttons;
        }

        private void menuButtonCategory_Click(object sender, EventArgs e)
        {
            menuButton b = sender as menuButton;
            clickedButton = b.getName;
            addCategoryContentToPanel(panel);

        }

        public List<menuButton> getListOfMenuContentButtons()
        {
            buttons.Clear();
            List<Product> products = new menuCategory().getListOfCategoryContent(clickedButton);

            foreach (Product product in products)
            {
                buttons.Add(new menuButton(product));
                buttons.Last().Click += menuButtonProduct_Click;
            }
            return buttons;
        }

        private void menuButtonProduct_Click(object sender, EventArgs e)
        {

            menuButton b = sender as menuButton;
            order.addNewProduct(b.getProduct);
            
        }

        public void addCategoriesToPanel(Panel panel, Order order)
        {
            this.panel = panel;
            this.order = order;
            panel.Controls.Clear();
            Point position = new Point(5, 0);
            this.getListOfMenuButtons();
            foreach (menuButton button in buttons)
            {
                button.Location = position;
                panel.Controls.Add(button);
                position.X += 85;
                if (position.X > 515)
                {
                    position.Y += 85;
                    position.X = 5;
                }

            }
        }

        public void addCategoryContentToPanel(Panel panel)
        {
            this.panel = panel;
            panel.Controls.Clear();
            Point position = new Point(5, 0);
            this.getListOfMenuContentButtons();
            foreach (menuButton button in buttons)
            {
                button.Location = position;
                panel.Controls.Add(button);
                position.X += 85;
                if (position.X > 515)
                {
                    position.Y += 85;
                    position.X = 5;
                }
            }
        }
    }
}
