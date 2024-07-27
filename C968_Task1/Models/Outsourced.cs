using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Task1.Models
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        /// <summary>
        /// This constructor is used to take in information from other classes and add them to the Part class for use. This 
        /// is used for the outsourced parts.
        /// </summary>
        /// <param name="PartID"></param>
        /// <param name="Name"></param>
        /// <param name="Inventory"></param>
        /// <param name="Price"></param>
        /// <param name="Min"></param>
        /// <param name="Max"></param>
        /// <param name="CompanyName"></param>
        public Outsourced(int PartID, string Name, int Inventory, decimal Price, int Min, int Max, string CompanyName)
        {
            this.PartID = PartID;
            this.Name = Name;
            InStock = Inventory;
            this.Price = Price;
            this.Min = Min;
            this.Max = Max;
            this.CompanyName = CompanyName;
        }
    }
}
