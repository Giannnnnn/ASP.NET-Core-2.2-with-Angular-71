using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class OrderItem : Entity
    {
        public Guid ID { get; set; }
        public Guid ProductID { get; set; }

    
        public int Quantity{ get; set; }
        public override void Validate()
        {
            CleanValidationMessages(); ;
            AddCommentary("TODO === VALIDATION");
        }
    }
}
