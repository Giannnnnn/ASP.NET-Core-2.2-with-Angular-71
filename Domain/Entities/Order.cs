using Domain.Value_Object;
using Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Entities
{
   public class Order : Entity
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

        public override void Validate()
        {

            //validações todas aqui
            //toda entidade tem uma validação

            CleanValidationMessages();
            if (!OrderItems.Any())
                AddCommentary("xxx");

            if(DeliverTime > DateTime.Now)
            {
                AddCommentary("n vai rolar cpx");
            }
        }
    }
}
