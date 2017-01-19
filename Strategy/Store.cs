using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Store 
    {
        public void Pay(IPaymentWallet wallet, double amount)
        {
            wallet.Pay(amount);
        }
    }
}
