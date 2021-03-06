﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class User : Entity
    {
        public Guid ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Double Avaliation { get; set; } 
        public virtual ICollection<Order> Orders { get; set; }

        public override void Validate()
        {
            CleanValidationMessages();;
            AddCommentary("TODO === VALIDATION");
        }
    }
}
