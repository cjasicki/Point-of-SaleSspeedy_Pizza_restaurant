using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Project
{
    class Custermer
    {
        private string custphone;
        private string custname;
        private string address1;
        private string address2;
        private string city;
        private string state;
        private string zip;
        private string qty;
        private string ordernu;
        private string total;

        public string Custphone
        {
            get { return custphone; }
            set { custphone = value;}
        }
        public string Custname
        {
            get { return custname; }
            set { custname = value; }
        }
        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }
        public string Address2
        {
            get { return address2 ; }
            set { address2 = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return State; }
            set { state = value; }
        }
        public string Zip
        {
            get { return Zip; }
            set { zip = value; }
        }
        public string Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        public string Ordernu
        {
            get { return ordernu; }
            set { ordernu = value; }
        }
        public string Total
        {
            get { return total; }
            set { total = value; }
        }

        public Custermer() { }    //Constructor with no parameter

        public Custermer (string phone, string cust, string add1, string add2, string city, string state, string zip, string qty, string ordernu, string total)
        {

            this.custphone = phone;
            this.custname = cust;
            this.address1 = add1;
            this.address2 = add2;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.qty = qty;
            this.ordernu = ordernu;
            this.total = total;

        }

    }
}
