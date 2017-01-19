﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FreeCharge:IPaymentWallet
    {        
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid ${amount} through FreeCharge");
        }
    }
}