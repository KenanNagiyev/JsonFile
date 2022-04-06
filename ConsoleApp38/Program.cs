using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using ConsoleApp38.Models;
namespace ConsoleApp38
{
    class Program
    {
        

        static void Main(string[] args)
        {
            #region serialize
            //Product bmw = new Product { Id = 1, Name = "M5", Price = 150.5 };
            //Product audi = new Product { Id = 2, Name = "RS7", Price = 100.5 };
            //Product mercedes = new Product { Id = 3, Name = "Maybach", Price = 50 };
            //Orderitem item1 = new Orderitem { Id = 1, Product = bmw, Count = 1, Totalprice = bmw.Price * 1 };
            //Orderitem item2 = new Orderitem { Id = 2, Product = audi, Count = 1, Totalprice = audi.Price * 1 };
            //Orderitem item3 = new Orderitem { Id = 3, Product = mercedes, Count = 1, Totalprice = mercedes.Price * 1 };
            //item1.Totalprice = Math.Round(bmw.Price * item1.Count, 2);
            //item2.Totalprice = Math.Round(audi.Price * item2.Count, 2);
            //item2.Totalprice = Math.Round(mercedes.Price * item2.Count, 2);
            //List<Orderitem> orderitems1 = new List<Orderitem>();
            //orderitems1.Add(item1);
            //orderitems1.Add(item2);
            //List<Orderitem> orderitems2 = new List<Orderitem>();
            //orderitems2.Add(item3);
            //Order order1 = new Order { Id = 1, Orderitems = orderitems1 };
            //Order order2 = new Order { Id = 2, Orderitems = orderitems2 };
            //var jsonObj = JsonConvert.SerializeObject(order1);
            //using (StreamWriter streamwriter = new StreamWriter(@"C:\Users\hp\Desktop\ders.cs\ConsoleApp38\ConsoleApp38\File\KenanFile.json"))
            //{
            //    streamwriter.WriteLine(jsonObj);
            //}
            //Console.WriteLine(jsonObj);
            #endregion
            #region deserialize
            string result;

            using (StreamReader streamreader = new StreamReader(@"C:\Users\hp\Desktop\ders.cs\ConsoleApp38\ConsoleApp38\File\AbbasFile (1).json"))
            {
                result = streamreader.ReadToEnd();
            }
            Order Orj = JsonConvert.DeserializeObject<Order>(result);
            foreach (var item in Orj.Orderitems)
            {
                Console.WriteLine(item.Product.Name);
            }
            #endregion
        }
    }
}
