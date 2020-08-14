using Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Value_Object
{
   public class PaymentOption
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
        public PaymentTimeEnum _PaymentTimeEnum { get; set; }


        public int ReturnType
        {
            get { return (int)_PaymentTimeEnum; }
        }

    }
}
