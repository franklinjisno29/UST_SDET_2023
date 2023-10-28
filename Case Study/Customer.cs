using Case_Study.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Case_Study
{
    //internal class Customer
    //{
    //    public Customer(string? custName, string? contact, int custID)
    //    {
    //        CustName = custName;
    //        Contact = contact;
    //        CustID = custID;
    //    }

    //    public string? CustName { get; set; }
    //    public string? Contact { get; set; }
    //    public int CustID { get; set; }
    //    public void DisplayCustomerDetails()
    //    {
    //        Console.WriteLine("Customer Name: {0} \nContact: {1} \nCustomer ID: {2}", CustName, Contact, CustID);
    //    }
    //}
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public List<Order>? PlacedOrders { get; set; }

        public void PlaceOrder(Order order)
        {
            {
                if (PlacedOrders == null)
                    PlacedOrders = new List<Order>();

                PlacedOrders.Add(order);
                Console.WriteLine($"Order placed successfully for product ID: {order.ProductID}");
            }
        }

        public void ProcessPayment()
        {
            if (PlacedOrders != null && PlacedOrders.Count > 0)
            {
                foreach (var order in PlacedOrders)
                {
                    if (order.Status == "Pending")
                    {
                        // Process payment for pending orders
                        Console.WriteLine($"Processing payment for order ID: {order.OrderID}");
                        order.Status = "Paid";
                    }
                }
            }
        }

        public void ViewOrderHistory()
        {
            if (PlacedOrders != null && PlacedOrders.Count > 0)
            {
                Console.WriteLine($"Order History for Customer {Name}:");
                foreach (var order in PlacedOrders)
                {
                    Console.WriteLine($"Order ID: {order.OrderID}, Product ID: {order.ProductID}, Status: {order.Status}");
                }
            }
            else
            {
                Console.WriteLine("No order history found for this customer.");
            }
        }

        public void ContactSupport()
        {
            Console.WriteLine("Contacting customer support...");
        }
    }
}
