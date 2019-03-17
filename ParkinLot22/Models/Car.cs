using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ParkinLot22.Models
{
    public class Car
    {
        
        public int ID { get; set; }
        public string LicensePlate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime InputTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime OutputTime { get; set; }
    }
}
