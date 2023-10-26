using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Customer
    {
        public Customer(int customerId, string? name, string? phoneNumber, double balance)
        {
            CustomerId = customerId;
            Name = name;
            PhoneNumber = phoneNumber;
            Balance = balance;
        }

        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public double Balance { get; set; }

        public static Dictionary<int, Customer> cust = new Dictionary<int, Customer>();
        public static void searchcust(string phnum)
        {
            foreach (var i in cust.Values)
            {
                if (phnum == i.PhoneNumber)
                {
                    Console.WriteLine("Customer Found:");
                    Console.WriteLine(i.Name);
                    Console.WriteLine(i.Balance);
                    break;
                }
                else
                {
                    Console.WriteLine("customer not found");
                }
            }
        }
        public static void DisplayCustomers()
        {
            foreach (var i in cust.Values)
            {
                Console.WriteLine("Id:{0}\tName:{1}\tPhoneNumber:{2}\tBalance:{3}", i.CustomerId, i.Name, i.PhoneNumber, i.Balance);
            }
        }

    }
}
