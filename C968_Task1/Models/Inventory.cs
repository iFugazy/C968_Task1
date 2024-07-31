using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
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

        /// <summary>
        /// Uses the products list and adds the pproducts that is placed within the methods parameter.
        /// </summary>
        /// <param name="part"></param>
        public static void addProduct(Product product) 
        {
            Products.Add(product);
        }
        
        /// <summary>
        /// Uses the Remove method to remove the product that is passed through the method's parameter.
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        public static bool removeProduct(Product product) 
        {
            Products.Remove(product);
            return true; 
        }

        /// <summary>
        /// looks up the product that is based off the productID parameter in the parent class and returns the product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static Product lookUpProduct(int number) 
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == number)
                {
                    return product;
                }
            }           
            return null;
        }

        /// <summary>
        /// Takes the product ID from the method and places it into the lookup product method which will then removed that product
        /// and add the new product.
        /// </summary>
        /// <param name="PartID"></param>
        /// <param name="part"></param>
        public static void updateProduct(int number, Product product) 
        {
            Product productID = lookUpProduct(number);

            removeProduct(productID);
            Products.Add(product);
        }

        /// <summary>
        /// Uses the all parts list and adds the part that is placed within the methods parameter.
        /// </summary>
        /// <param name="part"></param>
        public static void addPart(Part part) 
        {
            AllParts.Add(part);
        }

        /// <summary>
        /// Uses the Remove method to remove the part that is passed through the method's parameter.
        /// </summary>
        /// <param name="part"></param>
        /// <returns></returns>
        public static bool deletePart(Part part) 
        { 
            AllParts.Remove(part);
            return true;
        }

        /// <summary>
        /// looks up the part that is based off the partID parameter in the parent class and returns the part.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static Part lookupPart(int number) 
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == number)
                {
                    return part;
                }
            }
            return null;
        }

        /// <summary>
        /// Takes the part ID from the method and places it into the lookup part methof which will then removed that part and add the new part.
        /// </summary>
        /// <param name="PartID"></param>
        /// <param name="part"></param>
        public static void updatePart(int number, Part part) 
        {    
            Part partID = lookupPart(number);
            
            deletePart(partID);
            AllParts.Add(part);
        }

        /// <summary>
        /// This method is adds exampled data from the GUI to the part datagridview.
        /// </summary>
        public static void GUIExampleItems()
        {
            Part exampleInHouse1 = new Inhouse(1, "Wheel", 15, 12.11m, 5, 25, 1001);
            Part exampleInHouse2 = new Inhouse(2, "Pedal", 11, 8.22m, 5, 25, 1002);
            Part exampleInHouse3 = new Inhouse(3, "Chain", 12, 8.33m, 5, 25, 1003);
            Part exampleOutsourced1 = new Outsourced(4, "Seat", 8, 4.55m, 2, 15, "Icon Biking");


            Product ExampleProduct1 = new Product(1, "Red Bicycle", 15, 11.44m, 1, 25);
            Product ExampleProduct2 = new Product(2, "Yellow Bicycle", 19, 9.66m, 1, 20);
            Product ExampleProduct3 = new Product(3, "Blue Bicycle", 5, 12.77m, 1, 25);

            AllParts.Add(exampleInHouse1);
            AllParts.Add(exampleInHouse2);
            AllParts.Add(exampleInHouse3);
            AllParts.Add(exampleOutsourced1);

            Products.Add(ExampleProduct1);
            Products.Add(ExampleProduct2);
            Products.Add(ExampleProduct3);
        }
    }


}
