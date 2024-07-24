using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Task1.Models
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }
        public Inhouse() { }

        public Inhouse (int PartID, string Name, int Inventory, decimal Price, int Min, int Max, int MachineID)
        {
            this.PartID = PartID;
            this.Name = Name;
            InStock = Inventory;
            this.Price = Price;
            this.Min = Min;
            this.Max = Max;
            this.MachineID = MachineID;
        }

    }
}
