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
        public DateTime InitialTime { get; set; }
        public DateTime DeliverTime { get; set; }
        public Guid UserID { get; set; }
        public  virtual User User{ get; set; }
        public Address Address { get; set; }
        public string Status { get; set; }
        public  int PaymentOptionID{ get; set; }
        public virtual PaymentOption PaymentOption { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }

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
