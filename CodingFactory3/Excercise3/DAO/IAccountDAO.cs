using Excercise3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.DAO
{
    internal interface IAccountDAO
    {
        Account InsertAccount(Account account);

        Account GetAccountById(long id);

        Account GetAccountByIban(string iban);

        List<Account> GetAll();

        void Delete(string iban);

        void Deposit(string iban, double amount);

        void Withdraw(string iban, double amount, string ssn);

        bool AccountIbanExists(string iban);

        bool AccountIdExists(long id);

        bool IsSsnValid(string iban, string ssn);

        bool IsPositiveAmount(double amount);

        bool IsAmountLessThanBalance(string iban, double amount);
    }
}
