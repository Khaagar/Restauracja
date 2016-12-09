using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja2WForm
{
    public class DeliveryInfo
    {
        private string phoneNumber;
        private string street;
        private string streetNumber;
        private string flatNumber;
        private string additionalInformations;
        private string payForm;
        private Order order;

        public DeliveryInfo(string phoneNumber,string street, string streetNumber, string flatNumber, string additionalInformations, string payForm)
        {
            this.phoneNumber = phoneNumber;
            this.street = street;
            this.streetNumber = streetNumber;
            this.flatNumber = flatNumber;
            this.additionalInformations = additionalInformations;
            this.payForm = payForm;
        }

        public string getPhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string getStreet
        {
            get { return street; }
            set { street = value; }
        }

        public string getStreetNumber
        {
            get { return streetNumber; }
            set { streetNumber = value; }
        }

        public string getFlatNumber
        {
            get { return flatNumber; }
            set { flatNumber = value; }
        }

        public string getAdditionalInformation
                {
                    get { return additionalInformations; }
                    set { additionalInformations = value; }
                }
        public Order getOrder
        {
            get { return order; }
            set { order = value; }
        }

        public string getPayForm
        {
            get { return payForm; }
            set { payForm = value; }
        }


    }
}
