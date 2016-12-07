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
        private Order order;

        public DeliveryInfo(string phoneNumber,string street, string streetNumber, string flatNumber, string additionalInformations)
        {
            this.phoneNumber = phoneNumber;
            this.street = street;
            this.streetNumber = streetNumber;
            this.flatNumber = flatNumber;
            this.additionalInformations = additionalInformations;
        }

        private string getPhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        private string getStreet
        {
            get { return street; }
            set { street = value; }
        }

        private string getStreetNumber
        {
            get { return streetNumber; }
            set { streetNumber = value; }
        }

        private string getFlatNumber
        {
            get { return flatNumber; }
            set { flatNumber = value; }
        }

        private string getAdditionalInformation
                {
                    get { return additionalInformations; }
                    set { additionalInformations = value; }
                }
        public Order getOrder
        {
            get { return order; }
            set { order = value; }
        }


    }
}
