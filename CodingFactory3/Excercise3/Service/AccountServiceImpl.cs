using Excercise3.DAO;
using Excercise3.DTO;
using Excercise3.Model;
using Excercise3.Service.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.Service
{
    internal class AccountServiceImpl : IAccountService
    {
        private readonly IAccountDAO dao;

        public AccountServiceImpl(IAccountDAO dao)
        {
            this.dao = dao;
        }

        public Account InsertAccount(AccountDTO accountDTO)
        {
            Account account;
            try
            {
                account = new Account();
                MapAccount(account, accountDTO);

                if (dao.AccountIbanExists(accountDTO.Iban))
                {
                    throw new AccountIbanAlreadyExistsException(account);
                }
                if (dao.AccountIdExists(accountDTO.Id))
                {
                    throw new AccountIdAlreadyExistsException(account);
                }

                return dao.InsertAccount(account);
            }
            catch (AccountIbanAlreadyExistsException e )
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            }
            catch (AccountIdAlreadyExistsException e)
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            } 
        }

            public Account GetAccountById(long id)
            {
                Account account;
                try
                {
                    account = dao.GetAccountById(id);

                    if (account == null)
                    {
                        throw new AccountNotFoundException(id);
                    }

                    return dao.GetAccountById(id);
                }
                catch (AccountNotFoundException e)
                {
                    Console.WriteLine(e.StackTrace);
                    throw e;
                }
            }

            public Account GetAccountByIban(string iban)
            {
                Account account;
                try
                {
                    account = dao.GetAccountByIban(iban);

                    if (account == null)
                    {
                        throw new AccountNotFoundException(iban);
                    }

                    return dao.GetAccountByIban(iban);
                }
                catch (AccountNotFoundException e)
                {
                    Console.WriteLine(e.StackTrace);
                    throw e;
                }
            }

            public List<Account> GetAll()
            {
                return dao.GetAll();
            }

            public void Delete(string iban)
            {
                Account account;
                try
                {
                    account = new Account();
                    if (!dao.AccountIbanExists(iban))
                    {
                        throw new AccountNotFoundException(iban);
                    }

                    dao.Delete(iban);
                }
                catch (AccountNotFoundException e)
                {
                    Console.WriteLine(e.StackTrace);
                    throw e;
                }
            }

            public void Deposit(string iban, double amount)
            {
                Account account;
                try
                {
                    account = dao.GetAccountByIban(iban);

                    if (account == null)
                    {
                        throw new AccountNotFoundException(iban);
                    }

                    if (!dao.IsPositiveAmount(amount))
                    {
                        throw new InsufficientAmountException(amount);
                    }

                    dao.Deposit(account.Iban, amount);
                }
                catch (InsufficientAmountException  e)
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            }
              catch ( AccountNotFoundException e)
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            }
            }

        public void Withdraw(string iban, double amount, string ssn)
        {
            Account account;
            try
            {
                account = dao.GetAccountByIban(iban);

                if (account == null)
                {
                    throw new AccountNotFoundException(iban);
                }

                if (!dao.IsSsnValid(account.Iban, ssn))
                {
                    throw new SsnNotValidException(ssn);
                }
                if (!dao.IsAmountLessThanBalance(account.Iban, amount))
                {
                    throw new InsufficientBalanceException(account, amount);
                }

                dao.Withdraw(account.Iban, amount, ssn);
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            }
             catch ( SsnNotValidException e)
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            }
             catch (AccountNotFoundException e)
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            }
            }

            private void MapAccount(Account account, AccountDTO accountDTO)
            {
                account.Id = accountDTO.Id;
                account.Firstname = accountDTO.Firstname;
                account.Lastname = accountDTO.Lastname;
                account.Ssn = accountDTO.Ssn;
                account.Iban = accountDTO.Iban;
                account.Balance = accountDTO.Balance;
            }
        }
    }

