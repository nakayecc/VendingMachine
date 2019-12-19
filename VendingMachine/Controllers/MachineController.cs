using VendingMachine.Models;
using VendingMachine.Services;

namespace VendingMachine
{
    public class MachineController
    {
        private Machine Machine { get; set; }
        private CoinService CoinService { get; set; }
        public MachineServices MachineServices { get; set; }

        public MachineController(Machine machine, CoinService coinService)
        {
            Machine = machine;
            CoinService = coinService;
            MachineServices = new MachineServices(machine,coinService);
        }



        public void BuyItem()
        {
            
        }
        
        
        
    }
}