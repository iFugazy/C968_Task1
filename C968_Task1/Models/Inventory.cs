using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Task1.Models
{
    public class Inventory
    {
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }    
        
        public void addProduct() { }
        public bool removeProduct() { return false; }
        public Product lookUpProduct() {  return null; }
        public void updateProduct(int number, Product product) { }
        public void addPart(Part part) { }
        public bool deletePart(Part part) { return false; }
        public int lookupPart(int number) { return 0; }
        public void updatePart(int number, Part part) { }
    }


}
