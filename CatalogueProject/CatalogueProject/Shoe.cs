using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace CatalogueProject
{
	public class Shoe : ProductData
    {
        //       private double _size;
        //       public double Size { get { return _size; } }

        public Shoe (string name, string type, double price)
        {
            ProductName = name;
            Type = type;
            ProductPrice = price;
        }


        public override string ToString()
        {
            return $"Name:{ProductName}\n" +
                   $"Style:{Type}\n" +
                   $"Price:${ProductPrice}\n"; 
        }

        public static Shoe NewProduct(string name, string type, double price)
        {
            Shoe newShoe = new Shoe(name, type, price);
            return newShoe;
        }


    }
}

