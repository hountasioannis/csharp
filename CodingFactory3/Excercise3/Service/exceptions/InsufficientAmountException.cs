using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.Service.exceptions
{
    internal class InsufficientAmountException : Exception
    {
        public InsufficientAmountException(double amount) : base($"Amount {amount} is insufficient")
        {
        }
    }
}
