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
            if (Machine.Coins.ContainsKey(coin))
            {
                Machine.Coins[coin] += 1;
            }
            else
            {
                Machine.Coins.Add(coin, 1);
            }
        }
    }
}