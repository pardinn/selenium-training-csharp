using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermExam
{
    class Receipt
    {
        //variables declaration
        private int receiptNumber;
        private string dateOfPurchase;
        private int customerNumber;
        private string customerFirstName;
        private string customerLastName;
        private string customerAddress;
        private string customerPhoneNumber;
        private int itemNumber;
        private string itemDescription;
        private decimal unitPrice;
        private int quantityPurchased;

        //constructor
        public Receipt(int rNum, string purchaseDate, int cNum, string cFName, string cLName,
            string cAddress, string cPhone, int iNum, string iDesc, decimal uPrice, int qty)
        {
            ReceiptNumber = rNum;
            DateOfPurchase = purchaseDate;
            CustomerNumber = cNum;
            CustomerFirstName = cFName;
            CustomerLastName = cLName;
            CustomerAddress = cAddress;
            CustomerPhoneNumber = cPhone;
            ItemNumber = iNum;
            ItemDescription = iDesc;
            UnitPrice = uPrice;
            QuantityPurchased = qty;
        }

        //properties
        public int ReceiptNumber
        {
            get { return receiptNumber; }
            set
            {
                if (value > 0)
                {
                    receiptNumber = value;
                }
            }
        }
        public string DateOfPurchase { get => dateOfPurchase; set => dateOfPurchase = value; }
        public int CustomerNumber
        {
            get { return customerNumber; }
            set
            {
                if (value > 0)
                {
                    customerNumber = value;
                }
            }
        }
        public string CustomerFirstName { get => customerFirstName; set => customerFirstName = value; }
        public string CustomerLastName { get => customerLastName; set => customerLastName = value; }
        public string CustomerAddress { get => customerAddress; set => customerAddress = value; }
        public string CustomerPhoneNumber { get => customerPhoneNumber; set => customerPhoneNumber = value; }
        public int ItemNumber
        {
            get { return itemNumber; }
            set
            {
                if (0 < value && value < 9999)
                {
                    itemNumber = value;
                }
            }
        }
        public string ItemDescription { get => itemDescription; set => itemDescription = value; }
        public decimal UnitPrice
        {
            get { return unitPrice; }
            set
            {
                if (0 < value && value < 9999)
                {
                    unitPrice = value;
                }
            }
        }
        public int QuantityPurchased
        {
            get { return quantityPurchased; }
            set
            {
                if (value > 0)
                {
                    quantityPurchased = value;
                }
            }
        }

        //methods
        public decimal GetTotalCost()
        {
            return QuantityPurchased * UnitPrice;
        }

        public override string ToString()
        {
            return "Customer " + CustomerFirstName + " " + CustomerLastName +
                "\nPhone: " + CustomerPhoneNumber +
                "\nTotal Purchases: " + GetTotalCost().ToString("C");
        }
    }
}
