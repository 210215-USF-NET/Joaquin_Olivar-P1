using System;
using System.Collections.Generic;
namespace GRModels
{
    public class Customer
    {
        public int ID {get; set;}
        private string firstName;
        public string FirstName 
        {
            get {return firstName;}
            set
            {
            if (value.Equals(null)){
                throw new ArgumentNullException("Customer must have first name.");
            }
            firstName = value;
            }
        }
        public string LastName {get; set;}
        public string Email {get; set;}

        public string Address {get;set;}

        public int ZipCode {get; set;}
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Order> Orders { get; set; }
        

        public override string ToString() => $"Customer Details: \n\t Name: {this.FirstName} {this.LastName} \n\t {this.Email} \n\t Address: {this.Address}, {this.ZipCode} \n\t Customer ID: {this.ID}";
        

    }
}