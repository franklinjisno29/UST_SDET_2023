﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal class Order
    {
        //public BookType[] books = new BookType[10];
        //public string? Date { get; set; }
        //public int TotalCost { get; set; }
        ////public void OrderBook()
        ////{

        ////}
        //public int CalculateTotal()
        //{
        //    if (books != null)
        //    {
        //        foreach (var book in books)
        //        {
        //            TotalCost += book.Price;
        //        }
        //    }
        //    return TotalCost;
        //}

        
            public int OrderID { get; set; }
            public int ProductID { get; set; }
            public int Quantity { get; set; }
            public decimal TotalAmount { get; set; }
            public DateTime OrderDate { get; set; }
            public string? Status { get; set; }

        public static Dictionary<int, Product> products = new Dictionary<int, Product>();
        public Dictionary<int, List<Order>> customerOrders = new Dictionary<int, List<Order>>();

        public void AddProduct(Product product)
        {
            if (!products.ContainsKey(product.ProductId))
            {
                products.Add(product.ProductId, product);
            }
            else
            {
                Console.WriteLine($"Product with ID {product.ProductId} already exists in the collection.");
            }
        }

        public void AddOrder(int customerID, Order order)
        {
            if (!customerOrders.ContainsKey(customerID))
            {
                customerOrders.Add(customerID, new List<Order>());
            }
            customerOrders[customerID].Add(order);
        }

        public Product GetProduct(int productID)
        {
            if (products.ContainsKey(productID))
            {
                return products[productID];
            }
            else
            {
                Console.WriteLine($"Product with ID {productID} does not exist in the collection.");
                return null;
            }
        }

        public List<Order> GetCustomerOrders(int customerID)
        {
            if (customerOrders.ContainsKey(customerID))
            {
                return customerOrders[customerID];
            }
            else
            {
                Console.WriteLine($"No orders found for customer with ID {customerID}.");
                return new List<Order>();
            }
        }
        public static void CreateReport()
        {
            FileStream fs = new FileStream("Files\\Report.txt", FileMode.Create, FileAccess.Write);
        }

        public static void AddReport(Order order)
        {
            FileInfo fi = new FileInfo("D:\\UST_SDET_2023\\Case Study\\Files\\Report.txt");
            if (!fi.Exists)
                CreateReport();
            else
            {
                using StreamWriter stw = fi.AppendText();
                stw.Write(order.OrderID + "\t");
                stw.Write(order.ProductID + "\t");
                stw.Write(order.Quantity + "\t");
                stw.Write(order.TotalAmount + "\t");
                stw.Write(order.OrderDate + "\t");
                stw.Write(order.Status + "\t");
                stw.WriteLine(" ");
                stw.Flush();
                stw.Close();
            }
        }
    }
}
