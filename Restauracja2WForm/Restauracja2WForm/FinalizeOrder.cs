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
    public partial class FinalizeOrder : Form
    {
        Order order;
        public FinalizeOrder(Order order)
        {
            InitializeComponent();
            this.order = order;
            if (order.getTypeOfOrder == "DOWOZ")
            {
                label1.Text = "NR TELEFONU: " + order.getDelivery.getPhoneNumber;
                label2.Text = "ADRES: " + order.getDelivery.getStreet +" "+order.getDelivery.getStreetNumber+" / "+order.getDelivery.getFlatNumber;
                label3.Text = "DODATKOWE INFORMACJE: " + order.getDelivery.getAdditionalInformation;
                var checkedButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Text == order.getDelivery.getPayForm);
                checkedButton.Checked = true;
                
            }
            
        }

        private void FinalizeOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
