using System.Collections.Generic;
using VendingMachine.Models;

namespace VendingMachine.Dao
{
    public interface IProductDataFetch
    {
        List<Product> GetAllProduct();
        Product GetProductByName(string name);
    }
}