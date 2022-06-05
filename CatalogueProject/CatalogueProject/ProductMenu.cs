using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace CatalogueProject
{

    public class ProductMenu : ProductData
    {
        static string cupcakeData;
        static Catalogue<Cupcake> CupcakeCatalogue;
        static string ShoeData;
        static Catalogue<Shoe> ShoeCatalogue;


        // Add product to catalogue


        public static void ViewCatalogue()
        {
            Console.WriteLine("Which catalogue would you like to view?");
            Console.WriteLine("1. Cupcake");
            Console.WriteLine("2. Shoe");
            string ViewInput = Console.ReadLine();

            if (ViewInput == "1")
            {
                cupcakeData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "CupcakeCatalogue.json"));
                Catalogue<Cupcake> CupcakeCatalogue = JsonSerializer.Deserialize<Catalogue<Cupcake>>(cupcakeData);
                foreach (KeyValuePair<string, Cupcake> pair in CupcakeCatalogue.Dictiion)
                {

                    Console.WriteLine($"Cupcake:{pair.Key} - {pair.Value}");
                }
            }
            if (ViewInput == "2")
            {
                ShoeData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "ShoeCatalogue.json"));
                ShoeCatalogue = JsonSerializer.Deserialize<Catalogue<Shoe>>(ShoeData);
                foreach (KeyValuePair<string, Shoe> pair in ShoeCatalogue.Dictiion)
                {

                    Console.WriteLine($"Shoe:{pair.Key} - {pair.Value}");

                }
            }
        }


        public static void CreateProduct()
        {
            cupcakeData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "CupcakeCatalogue.json"));
            Catalogue<Cupcake> CupcakeCatalogue = JsonSerializer.Deserialize<Catalogue<Cupcake>>(cupcakeData);
            ShoeData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "ShoeCatalogue.json"));
            ShoeCatalogue = JsonSerializer.Deserialize<Catalogue<Shoe>>(ShoeData);
            // Catalogue options displayed to add product to
            Console.WriteLine("Which Catalogue would you like to add your product to?");
            Console.WriteLine("1. Cupcakes");
            Console.WriteLine("2. Shoes");

            // User selects option
            string CatalogueInput = Console.ReadLine();

            // Option select by user action
            if (CatalogueInput == "1")
            {
                //Catalogue<Cupcake> CupcakeCatalogue = new Catalogue<Cupcake>();
               
                // do something - input -> store -> save -> display
                Console.WriteLine("Let's Bake a Cupcake");

                Console.WriteLine("What is the name of this Cupcake?");
                string name = Console.ReadLine();

                Console.WriteLine("What is the flavour of this Cupcake?");
                string type = Console.ReadLine();

                Console.WriteLine("What is the price of this Cupcake?");

                double price = Convert.ToInt32(Console.ReadLine());

                Cupcake.BakeCupcake(name, type, price);
                CupcakeCatalogue.Add(name, Cupcake.BakeCupcake(name, type, price));
                Console.WriteLine($"You have added {name} to the Cupcake Catalogue");
                Console.WriteLine($"This is a {type} flavour cupcake");
                Console.Write($"Note:Price {price} is inclusive of tax:");
                Console.WriteLine(Cupcake.BakeCupcake(name, type, price).CalculateTax());

                string filepath = Path.Combine(Directory.GetCurrentDirectory(), "CupcakeCatalogue.json");
                File.WriteAllText(filepath, SaveData.serialise(CupcakeCatalogue));

            }
            if (CatalogueInput == "2")
            {
                Catalogue<Shoe> ShoeCatalogue = new Catalogue<Shoe>();
                // do something - input -> store -> save -> display
                Console.WriteLine("Let's add a Shoe");

                Console.WriteLine("What is the name of this Shoe?");
                string name = Console.ReadLine();

                Console.WriteLine("What is the type of this Shoe?");
                string type = Console.ReadLine();

                Console.WriteLine("What is the price of this Shoe?");

                double price = Convert.ToInt32(Console.ReadLine());

                Shoe.NewProduct(name, type, price);
                ShoeCatalogue.Add(name, Shoe.NewProduct(name, type, price));
                Console.WriteLine($"You have added {name} to the Shoe Catalogue");
                Console.WriteLine($"This is a {type} type of shoe");
                Console.Write($"Note:Price {price} is inclusive of tax:");
                Console.WriteLine(Shoe.NewProduct(name, type, price).CalculateTax());

                string filepath = Path.Combine(Directory.GetCurrentDirectory(), "ShoeCatalogue.json");
                File.WriteAllText(filepath, SaveData.serialise(ShoeCatalogue));

            }
            //else
            //{
            //    Console.WriteLine("Incorrect Input! Please select an option between 1 - 2.");
            //}
        }

        // Remove product from catalogue
        public static void RemoveProduct()
        {
            Console.WriteLine("Which catalogue would you like to remove the product from?");
            Console.WriteLine("1. Cupcakes");
            Console.WriteLine("2. Shoes");

            string CatalogueInputRemoval = Console.ReadLine();

            if (CatalogueInputRemoval == "1")
            {
                // do something - input -> locate -> remove -> save
                Catalogue<Cupcake> CupcakeCatalogue = new Catalogue<Cupcake>();
                Console.WriteLine("Enter the Cupcake to Remove:");
                string name = Console.ReadLine();
                CupcakeCatalogue.Remove(name);
                string filepath = Path.Combine(Directory.GetCurrentDirectory(), "CupcakeCatalogue.json");
                File.WriteAllText(filepath, SaveData.serialise(CupcakeCatalogue));
            }
            if (CatalogueInputRemoval == "2")
            {
                // do something - input -> locate -> remove -> save
                Catalogue<Shoe> ShoeCatalogue = new Catalogue<Shoe>();
                Console.WriteLine("Enter the Cupcake to Remove:");
                string name = Console.ReadLine();
                ShoeCatalogue.Remove(name);

                string filepath = Path.Combine(Directory.GetCurrentDirectory(), "ShoeCatalogue.json");
                File.WriteAllText(filepath, SaveData.serialise(ShoeCatalogue));
            }
            else
            {
                Console.WriteLine("Incorrect Input! Please select an option between 1 - 2.");
            }
        }

        public static void RemoveCatalogue()
        {
            Console.WriteLine("Which catalogue would you like to remove?");
            Console.WriteLine("1. Cupcakes");
            Console.WriteLine("2. Shoes");
            string CatalogueRemoval = Console.ReadLine();

            if (CatalogueRemoval == "1")
            {
                // Catalogue<Cupcake> CupcakeCatalogue = new Catalogue<Cupcake>();
                cupcakeData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "CupcakeCatalogue.json"));
                CupcakeCatalogue = JsonSerializer.Deserialize<Catalogue<Cupcake>>(cupcakeData);
                CupcakeCatalogue.Clear();
                string filepath = Path.Combine(Directory.GetCurrentDirectory(), "CupcakeCatalogue.json");
                File.WriteAllText(filepath, SaveData.serialise(CupcakeCatalogue));
                Console.WriteLine("You have deleted the Cupcake catalogue and all products within this catalogue");
            }
            if (CatalogueRemoval == "2")
            {
                ShoeData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "ShoeCatalogue.json"));
                ShoeCatalogue = JsonSerializer.Deserialize<Catalogue<Shoe>>(ShoeData);
                ShoeCatalogue.Clear();
                string filepath = Path.Combine(Directory.GetCurrentDirectory(), "ShoeCatalogue.json");
                File.WriteAllText(filepath, SaveData.serialise(ShoeCatalogue));
                Console.WriteLine("You have deleted the Shoe catalogue and all products within this catalogue");
            }
        }
        
    }
}

