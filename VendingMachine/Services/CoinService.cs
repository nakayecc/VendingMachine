namespace VendingMachine.Services
{
    public class CoinService
    {
        
        public bool CheckCoin(double coin)
        {
            return coin switch
            {
                0.01 => true,
                0.05 => true,
                0.10 => true,
                0.25 => true,
                0.50 => true,
                1 => true,
                _ => false
            };
        }
    }
}