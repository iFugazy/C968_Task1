using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Task1.Models
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }

        public decimal Price { get; set; }   
        public int Min { get; set; }
        public int Max { get; set; }

        /// <summary>
        /// This constructor is used to take in information from another class and use the information
        /// within this class.
        /// </summary>
        /// <param name="ProductID"></param>
        /// <param name="Name"></param>
        /// <param name="Instock"></param>
        /// <param name="Price"></param>
        /// <param name="Min"></param>
        /// <param name="Max"></param>
        public Product(int ProductID, string Name, int Instock, decimal Price, int Min, int Max)
        {
            this.ProductID = ProductID;
            this.Name = Name;
            this.InStock = Instock;
            this.Price = Price;
            this.Min = Min;
            this.Max = Max;
        }

        /// <summary>
        /// This method adds the associated part from the parts list to this associated parts lits within this class.
        /// </summary>
        /// <param name="part"></param>
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        /// <summary>
        /// This method removes the associated from the list using the product ID.
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public bool removeAssociatedPart(int ProductID)
        {
            foreach (Part assocpart in AssociatedParts)
            {
                if (assocpart.PartID == ProductID)
                {
                    AssociatedParts.Remove(assocpart);
                }                        
            }
            return true;
        }

        /// <summary>
        /// This method is used to lookup the associated part within the list and return it back
        /// to you as a part.
        /// </summary>
        /// <param name="ProductID"></param>
        /// <returns></returns>
        public Part lookupAssociatedPart(int ProductID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == ProductID)
                {
                    return part;
                }
            }
            return null;
        }


    }
}
