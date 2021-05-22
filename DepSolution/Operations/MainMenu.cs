using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class MainMenu
    {
        public static void Menu()
        {

            Console.WriteLine("\t--------------Your Are Welcome----------- ");
            Console.WriteLine("");
            while (true)
            {

                Console.WriteLine("You Can Perform Below Operation");
                Console.WriteLine("--------1.Insertion Of Data");
                Console.WriteLine("--------2.Query Operation");
                Console.WriteLine("--------3.Exit");
                string choice = Console.ReadLine();
                Console.WriteLine("");

                if (choice.ToUpper() == "1")
                {

                     
                    //DataInsert.AddRole();
                    //DataInsert.AddAddress();
                   // DataInsert.AddStaff();
                    //DataInsert.AddProduct();
                    //DataInsert.AddInventory();
                    //DataInsert.AddSupplier();
                    //DataInsert.AddCategory();
                    //DataInsert.AddProductCategory();
                }
                if (choice.ToUpper() == "2")
                {
                    Console.Clear();
                    Console.WriteLine("\t--------------QueryOperation----------- ");
                    Console.WriteLine("");
                    while (true)
                    {
                        //Console.Clear();
                        Console.WriteLine("You Can Perform Below Query Operation");
                        Console.WriteLine("--------1.Staff Query");
                        Console.WriteLine("--------2.Product Query");
                        Console.WriteLine("--------3.Supplier Query");
                        Console.WriteLine("--------4.NumberOfProduct That are out of stock");
                        Console.WriteLine("--------5.Filteration Based on Seeling Price");
                        Console.WriteLine("--------6.Number of Product Within a Category");
                        Console.WriteLine("--------7.Fileration Based On Highest To Lowest");
                        Console.WriteLine("--------8.");
                        string pchoice = Console.ReadLine();
                        Console.WriteLine("");

                        if (pchoice.ToUpper() == "1")
                        {

                            Operation.StaffQuery();
                        }
                        if (pchoice.ToUpper() == "2")
                        {

                            Operation.ProductQuery();

                        }
                        if (pchoice.ToUpper() == "3")
                        {
                            Operation.SupplierQuery();

                        }
                        if (pchoice.ToUpper() == "4")
                        {

                            Operation.NumberOfProductOutOfStock();
                        }
                        if (pchoice.ToUpper() == "5")
                        {

                            Operation.filterOnSellingPriceforProduct();

                        }
                        if (pchoice.ToUpper() == "6")
                        {
                            Operation.NumberofProductswithinacategory();

                        }
                        if (pchoice.ToUpper() == "7")
                        {

                            Operation.filterProductBasedOnHighestToLowest();
                        }
                        if (pchoice.ToUpper() == "8")
                        {

                            //Operation.ProductQuery();

                        }

                    }
                   




                }
                if (choice.ToUpper() == "3")
                {
                    break;

                }

            }







            //Console.ReadLine();
            //  while()
            //Operation.StaffQuery();
            //Operation.ProductQuery();
            //Operation.SupplierQuery();
            //Console.WriteLine("helloe");
            // string name = "Bill";






        }
    }
}
