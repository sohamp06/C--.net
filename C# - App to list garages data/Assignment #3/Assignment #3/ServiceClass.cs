/*
 * SOHAM PATEL
 * November 4, 2023
 * Assignment 3
 * A class of the Service file
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__3
{
    internal class ServiceClass
    {
    }
    public class ServiceInformation
    {
        public int ID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public bool EngineOilChange { get; set; }
        public bool TransOilChange { get; set; }
        public bool AirFilterChange { get; set; }
        public decimal Cost { get; }

        public ServiceInformation(int id, string firstName, string lastName, string phoneNumber, string make, string model, int year, string colour, bool engineOilChange, bool transOilChange, bool airFilterChange, decimal cost)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;
            EngineOilChange = engineOilChange;
            TransOilChange = transOilChange;
            AirFilterChange = airFilterChange;
            Cost = cost;
        }
    }

}
