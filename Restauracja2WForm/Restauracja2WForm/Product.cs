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
    public class Product
    {
        //class variables
        private string color;
        private string category;
        private string id;
        private string name;
        private string price;
        private List<string> ingredients = new List<string>();

        //constructors
        public Product(string category, string color, string id, string name, string price, List<string> ingredients)
        {
            this.color = color;
            this.category = category;
            this.id = id;
            this.name = name;
            this.price = price;
            foreach (string ingredient in ingredients)
            {
                this.ingredients.Add(ingredient);
            }
            
        }


        //get/set methods
        public string getColor
        {
            get { return color; }
            set { color = value; }
        }

        public string getCategory
        {
            get { return category; }
            set { category = value; }
        }

        public string getId
        {
            get { return id; }
            set { id = value; }
        }
        
        public string getName
        {
            get { return name; }
            set { name = value; }
        }

        public string getPrice
        {
            get { return price; }
            set { price = value; }
        }        


        public List<string> getIngredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

    }
}