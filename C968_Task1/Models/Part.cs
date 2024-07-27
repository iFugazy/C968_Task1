using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Task1.Models
{
    /// <summary>
    /// This class is used to house the properties used within the parts side of the 
    /// application. This is the parent class that the Inhouse and Outsourced classes use.
    /// </summary>
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }

        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
