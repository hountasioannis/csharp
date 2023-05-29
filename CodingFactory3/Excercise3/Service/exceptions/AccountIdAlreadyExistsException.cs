using Excercise3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.Service.exceptions
{
    internal class AccountIdAlreadyExistsException : Exception
    {
        public AccountIdAlreadyExistsException(Account account) : base($"Account with id {account.Id} already exists")
        {
        }
    }
}
