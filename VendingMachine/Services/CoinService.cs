using VendingMachine.Models;

namespace VendingMachine.Services
{
    public class CoinService
    {
        public CoinService()
        {
        }

        public Coin CheckCoin(double coin)
        {
            return coin switch
            {
                0.01 => Coin.Cent,
                0.05 => Coin.Nickel,
                0.10 => Coin.Dime,
                0.25 => Coin.QuarterDollar,
                0.50 => Coin.HalfDollar,
                1 => Coin.Dollar,
                _ => Coin.BadCoin
            };
        }
    }
}