using System;

namespace prototype {

    public class Employee{

        public string Name;
        public Address Address;

        public Employee(string name , Address address){
            Name = name ?? throw new ArgumentNullException(paramName : nameof(name));
            Address = address ?? throw new ArgumentNullException(paramName : nameof(name));            
        }

        public Employee(Employee other){

            Name = other.Name;
            Address = other.Address;
        }

        public override string ToString() {
            return $"{nameof(Name)}: {Name} , {nameof(Address)} : {Address} ";
        }

    }

}