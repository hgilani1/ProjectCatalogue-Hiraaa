using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace CatalogueProject // Note: actual namespace depends on the project name.
{
    public class Program
    {
        //static string cupcakeData;
        //static Catalogue<Cupcake> CupcakeCatalogue;
        //static string ShoeData;
        //static Catalogue<Shoe> ShoeCatalogue;
        static void Main(string[] args)
        {
            //cupcakeData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "CupcakeCatalogue.json"));
            //Catalogue<Cupcake> CupcakeCatalogue = JsonSerializer.Deserialize<Catalogue<Cupcake>>(cupcakeData);
            //ShoeData = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "ShoeCatalogue.json"));
            //ShoeCatalogue = JsonSerializer.Deserialize<Catalogue<Shoe>>(ShoeData);
            Menu.MenuOption();

            //Cupcake project = new Cupcake("Basic", "Vanilla", 2);

            //string jsonObject = JsonSerializer.Serialize(project);
            //Console.WriteLine(jsonObject);

            //string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Project.json");
            //File.WriteAllText(filePath, jsonObject);



            //Console.WriteLine(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
        }
    }
}