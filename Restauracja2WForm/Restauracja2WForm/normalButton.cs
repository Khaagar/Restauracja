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
    class normalButton : Button
    {
        public normalButton() :base()
        {
            this.Width = 80;
            this.Height = 80;

           

        }

        //metoda rysujaca przycisk
        protected override void OnPaint(PaintEventArgs e)
        {
            TextFormatFlags flags = new TextFormatFlags();

            Rectangle rectBackground = new Rectangle(0, 0, 80, 80);
            Rectangle rectBackgroundUp = new Rectangle(3,3, 74, 40);
            Rectangle rectBackgroundDown = new Rectangle(3, 35, 74, 42);
            Rectangle rectId = new Rectangle(0, 0, 80, 15);
            Rectangle rectName = new Rectangle(0, 20, 80, 40);
            Rectangle rectCena = new Rectangle(0, 65, 80, 15);
            Graphics g = e.Graphics;

            
            g.FillRectangle(Brushes.Black, rectBackground);
            g.FillRectangle(Brushes.White, rectBackgroundUp);
            g.FillRectangle(Brushes.WhiteSmoke, rectBackgroundDown);
            flags = TextFormatFlags.WordBreak |
                TextFormatFlags.HorizontalCenter | 
                TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(g, Text, new Font("Arial", 8), rectName, Color.Black, flags);
            
        }

    }


}
