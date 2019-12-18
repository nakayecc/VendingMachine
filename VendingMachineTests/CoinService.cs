using NUnit.Framework;

namespace VendingMachineTests
{
    public class CoinService
    {
        [Test]
        public void AcceptingOnlyCorrectCoins()
        {
            var coinService = new VendingMachine.Services.CoinService();
            
            Assert.AreEqual(true, coinService.CheckCoin(0.01));
            Assert.AreEqual(true, coinService.CheckCoin(0.05));
            Assert.AreEqual(true, coinService.CheckCoin(0.25));
            Assert.AreEqual(true, coinService.CheckCoin(0.50));
            Assert.AreEqual(true, coinService.CheckCoin(1));
            Assert.AreEqual(false, coinService.CheckCoin(1.1));
            Assert.AreEqual(false, coinService.CheckCoin(-1));
        }
    }
}