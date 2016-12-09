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
    public partial class ChangeIngredient : Form
    {
        private Product input;
        private bool status;
        private List<menuButton> buttons = new List<menuButton>();
        private ingredientsFileReader fs = new ingredientsFileReader();
        private List<string> ingredients;

        public ChangeIngredient(Product input)
        {
            this.input = input;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChangeIngredient_Load(object sender, EventArgs e)
        {
            #region DODAWANIE PRZYCISKÓW AKTUALNYCH SKŁADNIKÓW PIZZY
            Point position = new Point(0, 0);
            foreach (string item in input.getIngredients)
            {
                    menuButton button = new menuButton(item.ToUpper());
                    button.Location = position;
                    button.Click += InputButton_Selected;
                    position.X += 85;
                    panel1.Controls.Add(button);

            }
           
            #endregion

            #region DODAWANIE PRZYCISKÓW WSZYSTKICH DOSTEPNYCH SKŁADNIKÓW PIZZY
            position = new Point(0, 0);
            Color color = Color.White;
            ingredients = fs.getFileContent();
            foreach (string item in ingredients)
            {
                if (item.Contains("Color.")==true)
                {
                    string tmpStr = item.Remove(0, 6);
                    color = Color.FromName(tmpStr);
                }
                else
                {
                    menuButton button = new menuButton(item);
                    button.getColor = color;
                    button.Location = position;
                    button.Click += OutputButton_Selected;
                    position.X += 85;
                    if (position.X > 800)
                    {
                        position.Y += 85;
                        position.X = 0;
                    }
                    panel2.Controls.Add(button);
                }
            }
            position = new Point(0, 0);
            #endregion


        }

        private void InputButton_Selected(object sender, EventArgs e)
        {
            menuButton b = sender as menuButton;
            
            if (b.getColor != Color.OrangeRed)
            {
                input.getIngredients.Remove(input.getIngredients.Find(x => x.ToUpper()==b.getName));
                
                b.getColor = Color.OrangeRed;
            }
            else
            {
                input.getIngredients.Add(b.getName);
                b.getColor = Color.LightYellow;
            }

        }

        private void OutputButton_Selected(object sender, EventArgs e)
        {

            
            menuButton b = sender as menuButton;
            if (b.getColor != Color.Green)
            {
                
                input.getIngredients.Add(b.getName);
                b.getColor = Color.Green;
            }
            else
            {

                input.getIngredients.Remove(b.getName);
                b.getColor = Color.LightYellow;
            }

        }

        public Product getInput
        {
            get { return input; }

        }

        private void normalButton2_Click(object sender, EventArgs e)
        {
            status = false;
            this.Close();
        }

        private void normalButton1_Click(object sender, EventArgs e)
        {
            this.status = true;
            this.Close();
        }

        public bool getStatus
        {
            get { return status; }

        }

    }
}
