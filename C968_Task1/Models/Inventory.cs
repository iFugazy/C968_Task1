using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Task1.Models
{
    
    public class Inventory
    {
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static BindingList<Product> Products = new BindingList<Product>();
        
        // Start of the product inventory methods
        public static void addProduct() { }
        public static bool removeProduct() { return false; }
        public static Product lookUpProduct() {  return null; }
        public static void updateProduct(int number, Product product) { }

        // Start of Part inventory Methods

        // Uses the all parts list and adds the part that is placed within the methods parameter.
        public static void addPart(Part part) 
        {
            AllParts.Add(part);
        }

        // Uses the Remove method to remove the part that is passed through the method's parameter.
        public static bool deletePart(Part part) 
        { 

            AllParts.Remove(part);
            return true;
        }

        // looks up the part that is based off the partID parameter in the parent class and returns the part.
        public static Part lookupPart(int number) 
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == number)
                {
                    return part;
                }
            }
            Part emptyPart = new Inhouse();
            return emptyPart;
        }

        // Takes the part ID from the method and places it into the lookup part methof which will then removed that part and add the new part.
        public static void updatePart(int partID, Part part) 
        {
            mainForm main = new mainForm();
       
            Part part1 = lookupPart(partID);

            
            deletePart(part1);

            AllParts.Add(part);

        }

        public static void ExampleItems()
        {
            Part exampleInHouse = new Inhouse(1, "Darren", 1, 1.22m, 1, 1);
            Part exampleInHouse2 = new Inhouse(2, "Cody", 1, 1.22m, 1, 1);
            Part exampleInHouse3 = new Inhouse(3, "Zach", 1, 1.22m, 1, 1);
            AllParts.Add(exampleInHouse);
            AllParts.Add(exampleInHouse2);
            AllParts.Add(exampleInHouse3);
        }
    }


}
