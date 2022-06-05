using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace CatalogueProject
{
	internal class SaveData
	{
        public static string serialise<T>(Catalogue<T> catalogue) where T : ProductData
        {

            return JsonSerializer.Serialize(catalogue);

        }
    }
}

