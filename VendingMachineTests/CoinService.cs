using NUnit.Framework;
using VendingMachine.Models;
using VendingMachine.Services;

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

        [Test]

        public void AddMoneyToCorrectWallet()
        {
            var machine = new Machine();
            var coinService = new VendingMachine.Services.CoinService();
            var machineServices = new MachineServices(machine,coinService);
            
            
            machineServices.PutCoinToMachine(0.50);
            Assert.AreEqual(machineServices.Machine.Coins[Coin.HalfDollar],1);
            machineServices.PutCoinToMachine(0.50);
            Assert.AreEqual(machineServices.Machine.Coins[Coin.HalfDollar],2);
            machineServices.PutCoinToMachine(0.60);
            Assert.AreEqual(machineServices.Machine.RejectCoins[0.60], 1);


        }
    }
}