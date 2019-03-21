using System;
using System.Collections.Generic;
using System.Text;


namespace ParkinApp.Model
{
    /// <summary>
    /// This class is the model that represents a car which will use the parking lot.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// This property represents the Car ID
        /// </summary>
        public string LicensePlate { get; set; }
        /// <summary>
        /// Time 
        /// </summary>
        public DateTime InputTime { get; set; }
        public DateTime OutputTime { get; set; }
    }
}
