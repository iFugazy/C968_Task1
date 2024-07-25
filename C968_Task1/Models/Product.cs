using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Task1.Models
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }       
        public int Instock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product(int ProductID, string Name, int Instock, decimal Price, int Min, int Max)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.Instock = Instock;
            this.Price = Price;
            this.Min = Min;
            this.Max = Max;
        }

        public void addAssociatedPart(Part associatedPart)
        {
            AssociatedParts.Add(associatedPart);
        }

        public bool removeAssociatedPart(int ProductID)
        {
            return true;
        }

        public Part lookupAssociatedPart(int ProductID)
        { 
            return AssociatedParts[ProductID]; 
        }


    }
}
