using Excercise3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.DAO
{
    public class AccountDAOImpl : IAccountDAO
    {
        private static readonly Dictionary<long, Account> accounts = new Dictionary<long, Account>();

        public Account InsertAccount(Account account)
        {
            accounts[account.Id] = account;
            return account;
        }

        public Account GetAccountById(long id)
        {
            if (accounts.TryGetValue(id, out Account account))
            {
                return account;
            }
            return null;
        }

        public Account GetAccountByIban(string iban)
        {
            return accounts.Values.FirstOrDefault(acc => acc.Iban == iban);
        }

        public List<Account> GetAll()
        {
            return accounts.Values.ToList();
        }

        public void Delete(string iban)
        {
            var itemsToRemove = accounts.Where(x => x.Value.Iban == iban).ToList();
            foreach (var item in itemsToRemove)
            {
                accounts.Remove(item.Key);
            }
        }

        public void Deposit(string iban, double amount)
        {
            Account account = GetAccountByIban(iban);
            account.Balance += amount;
        }

        public void Withdraw(string iban, double amount, string ssn)
        {
            Account account = GetAccountByIban(iban);
            account.Balance -= amount;
        }

        public bool AccountIbanExists(string iban)
        {
            return accounts.Values.Any(account => account.Iban == iban);
        }

        public bool AccountIdExists(long id)
        {
            return accounts.ContainsKey(id);
        }

        public bool IsSsnValid(string iban, string ssn)
        {
            Account account = GetAccountByIban(iban);
            return account.Ssn == ssn;
        }

        public bool IsPositiveAmount(double amount)
        {
            return amount > 0;
        }

        public bool IsAmountLessThanBalance(string iban, double amount)
        {
            Account account = GetAccountByIban(iban);
            return account.Balance >= amount;
        }

        private long GetIndexById(long id)
        {
            return accounts.Keys.FirstOrDefault(key => accounts[key].Id == id);
        }

        private long GetIndexByIban(string iban)
        {
            return accounts.Keys.FirstOrDefault(key => accounts[key].Iban == iban);
        }
    }
}

