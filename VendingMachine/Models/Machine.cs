using System.Collections.Generic;
using System.IO;

namespace VendingMachine.Models
{
    public class Machine
    {
        public double Wallet { get; set; }
        public Dictionary<Product, int> Products { get; set; } 
        public Dictionary<Coin, int> CoinsInsert { get; set; }
        public Dictionary<double, int> RejectCoins { get; set; }
        

        public Machine()
        {
            Products = new Dictionary<Product, int>();
            CoinsInsert = new Dictionary<Coin, int>();
            RejectCoins = new Dictionary<double, int>();
        }
    }
}