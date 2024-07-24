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
