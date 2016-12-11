using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracja2WForm
{
    class orderButton : normalButton
    {
        private Order order;
        private string typeOfOrder = null;
        private string name;
        private Color color;
        private string time;
        private int id = 0;
        

        //konstruktory
        public orderButton(Order order)
        {

            this.Width = 80;
            this.Height = 80;
            this.order = order;
            this.typeOfOrder = order.getTypeOfOrder;
            if (this.typeOfOrder == "LOKAL")
            {
                this.color = Color.LightYellow;
            } else if (this.typeOfOrder == "DOWOZ")
            {
                this.color = Color.LightGreen;
            } else if (this.typeOfOrder == "WYNOS")
            {
                this.color = Color.LightBlue;
            }

            if (this.typeOfOrder == "DOWOZ")
            {
                this.name = order.getDelivery.getStreet + " " + order.getDelivery.getStreetNumber + " / " + order.getDelivery.getFlatNumber;
            }
            else this.name = order.getTypeOfOrder;

            this.time = DateTime.Now.TimeOfDay.Hours.ToString()+":"+ DateTime.Now.TimeOfDay.Minutes.ToString();

        }

        //metody get, set

        public int getId
        {
            get { return id; }
            set { id = value; }
        }
        public string getName
        {
            get { return name; }
            set { name = value; Invalidate(); }
        }

        public string getTypeOfOrder
        {
            get { return typeOfOrder; }

        }

        public string getTime
        {
            get { return time; }
        }

        public Order getOrder
        {
            get { return order; }
            set {order = value; Invalidate(); }
        }

        public Color getColor
        {
            get { return color; }
            set { color = value; Invalidate(); }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            TextFormatFlags flags = new TextFormatFlags();

            Rectangle rectBackground = new Rectangle(0, 0, 80, 80);
            Rectangle rectBackgroundUp = new Rectangle(3, 3, 74, 40);
            Rectangle rectBackgroundDown = new Rectangle(3, 35, 74, 42);
            Rectangle rectId = new Rectangle(5, 5, 74, 15);
            Rectangle rectName = new Rectangle(5, 12, 74, 40);
            Rectangle rectTime = new Rectangle(5, 52, 74, 15);
            Rectangle rectCost = new Rectangle(5, 60, 74, 15);
            Graphics g = e.Graphics;

            
            g.FillRectangle(Brushes.Black, rectBackground);
            g.FillRectangle(new SolidBrush(color), rectBackgroundUp);
            g.FillRectangle(new SolidBrush(color), rectBackgroundDown);
            flags =
                TextFormatFlags.Left |
                TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(g, Convert.ToString(id), new Font("Arial", 7), rectId, Color.Black, flags);
            

            flags =
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter |
                TextFormatFlags.WordBreak;
            TextRenderer.DrawText(g, name, new Font("Arial", 7), rectName, Color.Black, flags);

            flags =
                TextFormatFlags.Left |
                TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(g, time, new Font("Arial", 7, FontStyle.Italic), rectTime, Color.Black, flags);

            flags =
                TextFormatFlags.Right|
                TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(g, Convert.ToString(order.getCostOfOrder)+" PLN", new Font("Arial", 7, FontStyle.Bold), rectCost, Color.Black, flags);
        }
        }
            
    }

