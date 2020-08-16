using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObject
{
    public class Address : Entity
    {
        public Address(int postalCode, string street, string city, string state,int number)
        {
            PostalCode = postalCode;
            Street = street;
            City = city;
            State = state;
            Number = number;
        }

        public int PostalCode { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Number { get; set; }

        public override void Validate()
        {
            CleanValidationMessages(); ;
            AddCommentary("TODO === VALIDATION");
        }
    }
}
