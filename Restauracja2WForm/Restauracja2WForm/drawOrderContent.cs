using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracja2WForm
{
    public partial class drawOrderContent : UserControl
    {
        private Point positionInPanel = new Point(600, 5);
        private Order currentOrder = new Order();
        private TreeView orderTree = new TreeView();

        public void addProductToTreeView(Product product)
        {
            TreeNode productNode = orderTree.Nodes.Add(product.getName);
            foreach (string item in product.getIngredients)
            {
                productNode.Nodes.Add(item);
            }

        }



        public Order getActualOrder
        {
            get {return this.currentOrder; }
            set { this.currentOrder = value; }
        }
    }
}
