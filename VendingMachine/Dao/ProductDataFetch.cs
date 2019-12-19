using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;
using VendingMachine.Models;

namespace VendingMachine.Dao
{
    public class ProductDataFetch : IProductDataFetch
    {
        private readonly string _productPath;

        public ProductDataFetch()
        {
            _productPath = JObject.Parse(File.ReadAllText(@"..\..\..\appsettings.json")).SelectToken("$..ProductPath")
                .ToString();
        }

        public List<Product> GetAllProduct()
        {
            const int name = 0;
            const int amount = 1;
            const int price = 2;

            var lines = File.ReadAllLines(_productPath).Select(a => a.Split(','));
            return lines.Select(line => new Product(
                    line[name].ToString(),
                    Convert.ToDouble(line[price].Replace(".", ",")),
                    Convert.ToInt32(line[amount])))
                .ToList();
        }

        public Product GetProductByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}