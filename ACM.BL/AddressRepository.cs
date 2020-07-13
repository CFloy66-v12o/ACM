using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository 
    {
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = address.StreetLine1;
                address.StreetLine2 = address.StreetLine2;
                address.City = address.City;
                address.State = address.State;
                address.PostalCode = address.PostalCode;
                address.Country = address.Country;
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustID(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "1234 Main st",
                StreetLine2 = "apt 2",
                City = "Some City",
                State = "Some State",
                PostalCode = "12345",
                Country = "Europe"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "4321 My st",
                StreetLine2 = "apt 4",
                City = "Some other city",
                State = "Some other state",
                PostalCode = "54321",
                Country = "Non-Europe"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
                    {
                        //call an insert stored procedure
                    }
                    else
                    {
                        //call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
