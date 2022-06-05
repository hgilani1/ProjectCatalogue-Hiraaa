using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace CatalogueProject
{
    public class Catalogue<T> where T : ProductData   
    {

        public Dictionary<string, T> _catalogue = new Dictionary<string, T>();
        public Dictionary<string, T> Dictiion { get => _catalogue; set => _catalogue = value; }
        public void Add(string productName, T product)
        {
            _catalogue.Add(productName, product);
        }
        public void Remove(string productName)
        {
            _catalogue.Remove(productName);
        }
        public void Clear()
        {
            _catalogue.Clear();
        }

        public double CalculateTotal()
        {
            double Total = 0;
            foreach (ProductData item in Dictiion.Values)
            {
                Total += item.CalculateTax();
            }

            return Total;
        }


    }
}

