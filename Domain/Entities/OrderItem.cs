using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class OrderItem
    {
        public Guid ID { get; set; }
        public Guid ProductID { get; set; }

        public int Quantity{ get; set; }
    }
}
