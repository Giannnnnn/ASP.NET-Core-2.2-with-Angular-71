using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObject
{
    public class Address
    {
        public Address(int postalCode, string street, string city, string state,int number)
        {
            PostalCode = postalCode;
            Street = street;
            City = city;
            State = state;
            Number = number;
        }

        public int PostalCode { get;  }
        public string Street { get;  }
        public string City { get;  }
        public string State { get;  }
        public int Number { get;  }

    }
}
