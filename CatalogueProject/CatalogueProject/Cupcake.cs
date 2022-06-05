using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace CatalogueProject
{
    public class Cupcake : ProductData
    {
        
        public Cupcake(string name, string type, double price)
        {
            
            ProductName = name;
            Type = type;
            ProductPrice = price;
            //_tax = tax;
            //ProductName = name;
            ////ProductFlavour = flavour;
            //ProductPrice = price;
            //ProductTax = tax;
        }


        public static Cupcake BakeCupcake(string name, string type, double price)
        {
            Cupcake newCupcake = new Cupcake(name, type, price);
            return newCupcake;
        }

        public override string ToString()
        {
            return $"Name:{ProductName}\n" +
                   $"Flavour:{Type}\n" +
                   //$"Description:{ProductDescription}\n" +
                   $"Price:${ProductPrice}\n";
                   //$"GST:${ProductTax}\n";
        }

       

    }
}

