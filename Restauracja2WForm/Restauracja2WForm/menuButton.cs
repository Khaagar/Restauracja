using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracja2WForm
{
    class menuButton : normalButton
    {
        private Product product;
        private string id = null;
        private string name = null;
        private string price = null;
        private string typeOfButton = null;
        Color color = new Color();

        //konstruktory
        public menuButton(Product product)
        {

            this.Width = 80;
            this.Height = 80;

            this.color = Color.FromName(product.getColor);

            this.id = Convert.ToString(product.getId);

            this.name = product.getName.ToUpper();

            this.price = Convert.ToString(product.getPrice) + " PLN";

            this.typeOfButton = product.getCategory;
            this.product = product;

        }

        public menuButton(string kategoria) : base()
        {
            this.Width = 80;
            this.Height = 80;
            //this.BackColor = Color.FromName(kolor);

            this.name = kategoria;
            this.color = Color.LightYellow;
            this.typeOfButton= "KATEGORIA";
        }

        //metody get, set
        public string getId
        {
            get { return id; }
            set { id = value; Invalidate(); }
        }

        public string getName
        {
            get { return name; }
            set { name = value; Invalidate(); }
        }

        public string getPrice
        {
            get { return price; }
            set { price = value; Invalidate(); }
        }

        public string getTypeOfButton
        {
            get { return typeOfButton; }
            set { typeOfButton = value; Invalidate(); }
        }

        public Product getProduct
        {
            get { return product; }
            set {product = value; Invalidate(); }
        }




        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            TextFormatFlags flags = new TextFormatFlags();

            Rectangle rectBackground = new Rectangle(0, 0, 80, 80);
            Rectangle rectBackgroundUp = new Rectangle(3, 3, 74, 40);
            Rectangle rectBackgroundDown = new Rectangle(3, 35, 74, 42);
            Rectangle rectId = new Rectangle(5, 5, 74, 15);
            Rectangle rectName = new Rectangle(5, 20, 74, 40);
            Rectangle rectCena = new Rectangle(5, 60, 74, 15);
            Graphics g = e.Graphics;

            
            g.FillRectangle(Brushes.Black, rectBackground);
            g.FillRectangle(new SolidBrush(color), rectBackgroundUp);
            g.FillRectangle(new SolidBrush(color), rectBackgroundDown);
            flags =
                TextFormatFlags.Left |
                TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(g, id, new Font("Arial", 9), rectId, Color.Black, flags);

            flags =
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.WordBreak;
            TextRenderer.DrawText(g, name, new Font("Arial", 7), rectName, Color.Black, flags);
            if (price != null){
                flags =
                TextFormatFlags.Right |
                TextFormatFlags.VerticalCenter;
                TextRenderer.DrawText(g, price, new Font("Arial", 7, FontStyle.Italic), rectCena, Color.Black, flags);
            }
        }
            
    }
}
