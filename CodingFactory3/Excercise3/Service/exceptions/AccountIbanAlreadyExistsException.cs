using Excercise3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.Service.exceptions
{
    internal class AccountIbanAlreadyExistsException : Exception
    {
         
        public AccountIbanAlreadyExistsException(Account account) : base($"Account with iban {account.Iban} already exists")
        {
        }
    }
}

