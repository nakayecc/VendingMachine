using NUnit.Framework;
using VendingMachine.Models;

namespace VendingMachineTests
{
    public class CoinService
    {
        [Test]
        public void AcceptingOnlyCorrectCoins()
        {
            var coinService = new VendingMachine.Services.CoinService();
            
            Assert.AreEqual(Coin.Cent, coinService.CheckCoin(0.01));
            Assert.AreEqual(Coin.Nickel, coinService.CheckCoin(0.05));
            Assert.AreEqual(Coin.Dime, coinService.CheckCoin(0.10));
            Assert.AreEqual(Coin.QuarterDollar, coinService.CheckCoin(0.25));
            Assert.AreEqual(Coin.HalfDollar, coinService.CheckCoin(0.50));
            Assert.AreEqual(Coin.Dollar, coinService.CheckCoin(1));
            Assert.AreEqual(Coin.BadCoin, coinService.CheckCoin(1.1));
            Assert.AreEqual(Coin.BadCoin, coinService.CheckCoin(-1));
        }
    }
}