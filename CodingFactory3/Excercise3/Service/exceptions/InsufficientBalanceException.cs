using Excercise3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.Service.exceptions
{
    internal class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(Account account, double amount)
            : base($"Insufficient balance {account.Balance} for amount {amount}")
        {
        }
    }
}
