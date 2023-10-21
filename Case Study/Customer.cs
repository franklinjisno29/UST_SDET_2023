using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Customer
    {
        public Customer(string? custName, string? contact, int custID)
        {
            CustName = custName;
            Contact = contact;
            CustID = custID;
        }

        public string? CustName { get; set; }
        public string? Contact { get; set; }
        public int CustID { get; set; }
        public void DisplayCustomerDetails()
        {
            Console.WriteLine("Customer Name: {0} \nContact: {1} \nCustomer ID: {2}", CustName, Contact, CustID);
        }
    }
}
