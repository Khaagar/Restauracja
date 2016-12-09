using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracja2WForm
{
    public class Order
    {
        private DeliveryInfo delivery = null;
        private List<Product> orderedProducts = new List<Product>();
        private double cost=0;
        private bool isRealized=false;

        public void addNewProduct(Product produkt)
        {
            this.orderedProducts.Add(produkt);
            this.cost += Convert.ToDouble(produkt.getPrice);

           
        }

        public void removeProductFromOrder(string name)
        {
            Product productToRemove = orderedProducts.Find(x => x.getName == name);
            this.cost -= Convert.ToDouble(productToRemove.getPrice);
            this.orderedProducts.Remove(productToRemove);

            
        }


        public DeliveryInfo getDelivery
        {
            get { return delivery; }
            set { delivery = value; }
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
