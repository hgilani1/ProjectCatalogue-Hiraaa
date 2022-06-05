using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatalogueProject;


namespace CatalogueProject
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]

        public void View_ViewCatalogue()
        {
            Assert.AreEqual("basic", "vanilla", "2");

        }
    }
}

