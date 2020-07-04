using System;

namespace prototype{

    public class Address{
        public string StreetAddress, City, Country;

        public Address(string streetAddress, string city, string country){
            StreetAddress = streetAddress ?? throw new ArgumentException(paramName : nameof(streetAddress));
            City = city ?? throw new ArgumentException(paramName : nameof(city));
            Country = country ?? throw new ArgumentException(paramName : nameof(country));
        }

        public Address(Address other){
            StreetAddress = other.StreetAddress;
            City = other.City;
            Country = other.Country;
        }

        public override ToString() {
            return $"{nameof(StreetAddress)}: {StreetAddress} , {nameof(City)}: { City } , {nameof(Country)}: {Country}  ";
        }

    }


}