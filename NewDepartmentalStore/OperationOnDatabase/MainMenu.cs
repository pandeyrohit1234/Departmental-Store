using System;
using System.Collections.Generic;
using System.Text;

namespace OperationOnDatabase
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


                    //AddRole();
                    //AddAddress();
                    //AddStaff();
                    //AddProduct();
                    //AddInventory();
                    //AddSupplier();
                    //AddCategory();
                    //AddProductCategory();
                }
                if (choice.ToUpper() == "2")
                {

                    Console.WriteLine("\t--------------QueryOperation----------- ");
                    Console.WriteLine("");
                    while (true)
                    {
                        
                        Console.WriteLine("You Can Perform Below Query Operation");
                        Console.WriteLine("--------1.Staff Query");
                        Console.WriteLine("--------2.Product Query");
                        Console.WriteLine("--------3.Product Query");
                        Console.WriteLine("--------4.Staff Query");
                        Console.WriteLine("--------5.");
                        Console.WriteLine("--------6");
                        Console.WriteLine("--------7.");
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

                            //Operation.StaffQuery();
                        }
                        if (pchoice.ToUpper() == "5")
                        {

                            //Operation.ProductQuery();

                        }
                        if (pchoice.ToUpper() == "6")
                        {
                            //Operation.SupplierQuery();

                        }
                        if (pchoice.ToUpper() == "7")
                        {

                            //Operation.StaffQuery();
                        }
                        if (pchoice.ToUpper() == "8")
                        {

                            //Operation.ProductQuery();

                        }

                    }
                if (choice.ToUpper() == "3")
                {
                        break;

                }


                

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
