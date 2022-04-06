using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp39.Models
{
    class Order
    {
        public int Id { get; set; }
        public List<Orderitem> Orderitems{ get; set; }
    }
}
