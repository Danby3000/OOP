﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Account : Person
    {
        public Account() { }
        public double getAccountBalance()
        {
            return currentAccount;
        }

        public double setAccountBalance(double amount) 
        {
            currentAccount = currentAccount + amount;
            return currentAccount;
        }

        public double withdrawFromAccount(double amount)
        {
            currentAccount = currentAccount - amount;
            return currentAccount;
        }
    }
}
