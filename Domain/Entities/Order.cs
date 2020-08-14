using Domain.Value_Object;
using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
   public class Order
    {   
        public Guid ID { get; set; }
        public DateTime InitialTime { get; }
        public DateTime DeliverTime { get; }
        public Guid CostumerID { get; }
        public Address Address { get; set; }
        public string Status { get; }
        public int PaymentOptionID{ get; set; }
        public PaymentOption PaymentOption { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
