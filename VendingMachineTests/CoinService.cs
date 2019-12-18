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
            
            Assert.AreEqual(Coin.Cent, coinService.InsertCoinToMachine(0.01));
            Assert.AreEqual(Coin.Nickel, coinService.InsertCoinToMachine(0.05));
            Assert.AreEqual(Coin.Dime, coinService.InsertCoinToMachine(0.10));
            Assert.AreEqual(Coin.QuarterDollar, coinService.InsertCoinToMachine(0.25));
            Assert.AreEqual(Coin.HalfDollar, coinService.InsertCoinToMachine(0.50));
            Assert.AreEqual(Coin.Dollar, coinService.InsertCoinToMachine(1));
            Assert.AreEqual(Coin.BadCoin, coinService.InsertCoinToMachine(1.1));
            Assert.AreEqual(Coin.BadCoin, coinService.InsertCoinToMachine(-1));
        }
    }
}