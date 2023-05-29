using Excercise3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.Service.exceptions
{
    internal class AccountNotFoundException : Exception
    {
        public AccountNotFoundException(string iban) : base($"The account with iban {iban} was not found")
        {
        }

        public AccountNotFoundException(long id) : base($"The account with id {id} was not found")
        {
        }

        public AccountNotFoundException(Account account) : base($"The account {account} was not found")
        {
        }
    }
}
