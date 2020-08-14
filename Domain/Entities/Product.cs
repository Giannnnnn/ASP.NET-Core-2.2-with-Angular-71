﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
   public class Product : Entity
    {

            public Guid ID { get; set; }
            public string Name { get; set; }
            public Double Avaliation { get; set; }

        public override void Validate()
        {
            CleanValidationMessages(); ;
            AddCommentary("TODO === VALIDATION");
        }
    }
}
