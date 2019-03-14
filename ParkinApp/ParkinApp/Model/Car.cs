using System;
using System.Collections.Generic;
using System.Text;

namespace ParkinApp.Model
{
    public class Car
    {
        public string LicensePlate { get; set; }
        public DateTime InputTime { get; set; }
        public DateTime OutputTime { get; set; }
    }
}
