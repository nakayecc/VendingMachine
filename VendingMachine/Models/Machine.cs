using System.Collections.Generic;

namespace VendingMachine.Models
{
    public class Machine
    {
        public double Wallet { get; set; }
        public Dictionary<Product, int> Products { get; set; } 
        public Dictionary<Coin, int> Coins { get; set; }
        public Dictionary<double, int> RejectCoins { get; set; }

        public Machine()
        {
            Products = new Dictionary<Product, int>();
            Coins = new Dictionary<Coin, int>();
            RejectCoins = new Dictionary<double, int>();
        }
    }
}