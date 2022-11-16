using System;
namespace AddressProject
{
    public class Address
    {
        private int number;
        private string street;
        private string city;
        private string postcode;
        public Address(string address)
        {
            string[] tokens = address.Split(";");
            string firstLine = tokens[0];
            string[] firstLineTokens = firstLine.Split(" ");
            number = Convert.ToInt32(firstLineTokens[0]);
            street = firstLineTokens[1];
            city = tokens[1];
            postcode = tokens[2];
            // checks isValid and raise an error in case
        }
        // should check whether it is a valid address
        // always returns true for now
        private bool IsValid()
        {
            return true;
        }
        public override string ToString()
        {
            return $"Number: {number}, Street: {street}, City: {city}, Postcode: {postcode}\n";
        }
    }
}

// To make a project reference, right click over the project and click "Add" then click "Project Reference" and click the project you'd like tor reference
// Additionally the namespace that the data is being cross referenced from would need to be explicity referenced "using *namespace*".
