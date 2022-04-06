using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp39.Models
{
    class Orderitem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public  int Count { get; set; }
        public double Totalprice { get; set; }
    }
}
