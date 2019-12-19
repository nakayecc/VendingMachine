using System;
using VendingMachine.Models;

namespace VendingMachine.Services
{
    public class MachineServices
    {
        public Machine Machine { get; set; }
        public CoinService CoinService {get; set; }

        public MachineServices(Machine machine, CoinService coinService)
        {
            Machine = machine;
            CoinService = coinService;
        }

        public void PutCoinToMachine(double coin)
        {
            var actualCoin = CoinService.InsertCoinToMachine(coin);
            
            if ( actualCoin == Coin.BadCoin)
            {
                AddRejectedCoinToWallet(coin);
            }
            else
            {
                AddGoodCoinToWallet(actualCoin);
            }
            
        }
        private void AddRejectedCoinToWallet(double coin)
        {
            if (Machine.RejectCoins.ContainsKey(coin))
            {
                Machine.RejectCoins[coin] += 1;
            }
            else
            {
                Machine.RejectCoins.Add(coin, 1);
            }
        }
        private void AddGoodCoinToWallet(Coin coin)
        {
            if (Machine.CoinsInsert.ContainsKey(coin))
            {
                Machine.CoinsInsert[coin] += 1;
            }
            else
            {
                Machine.CoinsInsert.Add(coin, 1);
            }
        }
        public bool ItemInMachine(Product product)
        {
            return Machine.Products.ContainsKey(product);
        }
        public void BuyItem(double userCoin, Product product)
        {
            if (!(userCoin >= product.Price)) return;
            
            if (Machine.Products[product] == 1)
            {
                Machine.Products.Remove(product);
            }
            else
            {
                Machine.Products[product] -= 1;
            }
        }

        public double ValueInsertCoin()
        {
            var valueInMachine = 0.0;
        
            foreach (var (key, value) in Machine.CoinsInsert)
            {
                valueInMachine += (Convert.ToDouble(key) / 100) * value;
            }


            return valueInMachine;
        }
    }
}