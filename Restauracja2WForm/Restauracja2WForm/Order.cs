using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracja2WForm
{
    class Order
    {
        
        private List<Product> orderedProducts = new List<Product>();
        private double cost=0;
        private bool isRealized=false;

        public Order()
        {

        }
        public void addNewProduct(Product produkt)
        {
            this.orderedProducts.Add(produkt);
            this.cost += Convert.ToDouble(produkt.getPrice);

           
        }

        public void removeProductFromOrder(int i)
        {
            this.cost -= Convert.ToDouble(orderedProducts.ElementAt(i).getPrice);
            this.orderedProducts.RemoveAt(i);

            
        }

        public void editProductIngredients(int i)
        {
            List<string> ingredients = orderedProducts.ElementAt(i).getIngredients;
            
            
        }

        public List<Product> getListOfOrderedProducts
        {
            get { return orderedProducts; }
            set { orderedProducts = value; }
        }

        public double getCostOfOrder
        {
            get { return cost; }
            set { cost = value; }
        }

        public bool getIsRealized
        {
            get { return isRealized; }
            set { isRealized = value; }
        }
    }
}
