﻿using System;
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
        private Panel panelMenu = new Panel();
        private Panel panelOrder = new Panel();
        private TreeView orderTree = new TreeView();

        #region TWORZENIE LISTY PRZYCISKÓW KATEGORII
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
        #endregion

        #region ZDARZENIE CLICK DLA PRZYCISKU KATEGORII
        private void menuButtonCategory_Click(object sender, EventArgs e)
        {
            menuButton b = sender as menuButton;
            clickedButton = b.getName;
            addCategoryContentToPanel(panelMenu);
        }
        #endregion

        #region TWORZENIE LISTY PRZYCISKÓW ZAWARTOŚCI KATEGORII
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
        #endregion

        #region ZDARZENIE CLICK DLA PRZYCISKU ZAWARTOŚCI KATEGORII
        private void menuButtonProduct_Click(object sender, EventArgs e)
        {

            menuButton b = sender as menuButton;
            this.order.addNewProduct(b.getProduct);
            this.panelOrder.Controls.Find("totalAmountOfOrder", false).Last().Text= "SUMA: " + Convert.ToString(order.getCostOfOrder)+" PLN";
            updateTreeView(b.getName,b.getPrice, b.getIngredients);
            addCategoriesToPanel(this.panelMenu, this.order);

        }
        #endregion

        #region DODAWANIE PRZYCISKÓW KATEGORII DO PANELU
        public void addCategoriesToPanel(Panel panel, Order order)
        {
            this.panelMenu = panel;
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
        #endregion

        #region DODAWANIE PRZYCISKÓW ZAWARTOŚCI KATEGORII DO PANELU
        public void addCategoryContentToPanel(Panel panel)
        {
            this.panelMenu = panel;
            panel.Controls.Clear();
            Button backToCategory = new normalButton();
            Image back = Image.FromFile(@"../../back_image.png");
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
            position.X = 0;
            position.Y = 520;
            backToCategory.Image = back;
            backToCategory.Location = position;
            backToCategory.Click += BackToCategory_Click;
            panel.Controls.Add(backToCategory);
        }
        #endregion

        #region ZDARZENIE CLICK DLA PRZYCISKU COFANIA DO WYBORU KATEGORII
        private void BackToCategory_Click(object sender, EventArgs e)
        {
            this.panelMenu.Controls.Clear();
            addCategoriesToPanel(this.panelMenu, this.order);
        }
        #endregion

        #region DODAWANIE KONTROLKI TREEVIEW WRAZ Z PRZYCISKAMI DO OBSŁUGI ZAMÓWIONYCH PRODUKTÓW DO PANELU
        public void addTreeViewToPanel(Panel panel)
        {
            
            this.panelOrder = panel;
            Point position = new Point(0, 0);
            Button deleteButton = new Button();
            Label totalAmountOfOrder = new Label();
            Image trash = Image.FromFile(@"../../delete_image.png");
            deleteButton.Image = trash;
            deleteButton.Width = 40;
            deleteButton.Height = 40;
            deleteButton.Location = position;
            deleteButton.Click += DeleteButton_Click;
            position.X += 40;

            Button minusButton = new Button();
            Image minus = Image.FromFile(@"../../minus_image.png");
            minusButton.Image = minus;
            minusButton.Width = 40;
            minusButton.Height = 40;
            minusButton.Location = position;
            minusButton.Click += MinusButton_Click;
            position.X += 40;
            

            Button plusButton = new Button();
            Image plus = Image.FromFile(@"../../plus_image.png");
            plusButton.Image = plus;
            plusButton.Width = 40;
            plusButton.Height = 40;
            plusButton.Location = position;
            plusButton.Click += PlusButton_Click;
            position.X += 40;
            

            Button changeButton = new Button();
            Image change = Image.FromFile(@"../../change_image.png");
            changeButton.Image = change;
            changeButton.Width = 40;
            changeButton.Height = 40;
            changeButton.Location = position;
            changeButton.Click += ChangeButton_Click;
            position.X = 0;
            position.Y += 40;

            orderTree.Location = position;
            orderTree.Width = 180;
            orderTree.Height = 540;
            position.Y += orderTree.Height + 5;
            totalAmountOfOrder.Location = position;
            totalAmountOfOrder.Text = "SUMA: " + Convert.ToString(order.getCostOfOrder)+" PLN";
            totalAmountOfOrder.Name = "totalAmountOfOrder";
            panel.Controls.Add(deleteButton);
            panel.Controls.Add(minusButton);
            panel.Controls.Add(plusButton);
            panel.Controls.Add(changeButton);
            panel.Controls.Add(orderTree);
            panel.Controls.Add(totalAmountOfOrder);


        }
        #endregion

        private void PlusButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            Product selectedProduct = order.getListOfOrderedProducts.Find(x => x.getName.ToUpper().Contains(orderTree.SelectedNode.Text));
            ChangeIngredient Change = new ChangeIngredient(selectedProduct);
            Change.Visible = true;
            while (Change.Visible != true)
            {

            }
            if (Change.getStatus == true)
            {
                
                order.getListOfOrderedProducts.Find(x => x.getName.ToUpper().Contains(orderTree.SelectedNode.Text)).getIngredients = Change.getInput.getIngredients;
                orderTree.SelectedNode.Remove();
                updateTreeView(Change.getInput.getName, Change.getInput.getPrice, Change.getInput.getIngredients);
            }
            
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            try
            {
                orderTree.SelectedNode.Remove();
                orderTree.SelectedNode = null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Nie zaznaczono żadnego składnika. Nie mam co usunąć");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                orderTree.SelectedNode.Remove();
                orderTree.SelectedNode = null;
            }
            catch (NullReferenceException )
            {
                MessageBox.Show("Nie zaznaczono żadnego produktu. Nie mam co usunąć");
            }
               
            
            
        }

        private void updateTreeView(string productName,string productPrice, List<string> ingredients)
        {

            TreeNode node = orderTree.Nodes.Add(productName);
            
            foreach (string ingredient in ingredients)
            {
                    node.Nodes.Add(productName, ingredient.ToUpper());
                
            }
            
        }
    }
}
