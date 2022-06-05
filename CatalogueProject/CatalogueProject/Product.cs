using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace CatalogueProject
{
	
	public abstract class ProductData
	{
		public string _productName;
		public string ProductName { get { return _productName; } set { _productName = value; } }

		//private string _productDescription;
		//public string ProductDescription { get { return _productDescription; } set { _productDescription = value; } }

		public string _type;
		public string Type { get => _type; set { } }
		
		public double _productPrice;
		public double ProductPrice { get { return _productPrice; } set { _productPrice = value; } }

		//private bool _plusGST;
		//public bool PlusGST { get { return _plusGST; } set { _plusGST = value; } }

		//private double _tax;
		//public double ProductTax {  get { return _tax; } set { _tax = 0.1; } }


        //public ProductData(string productName, string productDescription, double productPrice, double tax)
        //{
        //    _productName = productName;
        //    _productDescription = productDescription;
        //    _productPrice = productPrice;
        //    _tax = tax;
        //}


		//public ProductData(string name, string type, double price)
		//{
		//	_productName = name;
		//	_type = type;
		//	//_productDescription = description;
		//	_productPrice = price;
		//	//_tax = tax;
		//}


		public virtual double CalculateTax()
		{
			return Math.Round(_productPrice + (_productPrice * 0.1));
		}
	}
}
