using Excercise3.DAO;
using Excercise3.DTO;
using Excercise3.Service.exceptions;
using Excercise3.Service;
using Excercise3.Model;

namespace Excercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountDAOImpl dao = new AccountDAOImpl();
            AccountServiceImpl accountService = new AccountServiceImpl(dao);

            AccountDTO accountDTO = new AccountDTO
            {
                Id = 1,
                Balance = 500.0,
                Firstname = "a",
                Lastname = "a",
                Iban = "123",
                Ssn = "123"
            };
            AccountDTO accountDTO1 = new AccountDTO
            {
                Id = 1,
                Balance = 500.0,
                Firstname = "a",
                Lastname = "a",
                Iban = "123",
                Ssn = "123"
            };
            AccountDTO accountDTO2 = new AccountDTO
            {
                Id = 2,
                Balance = 600.0,
                Firstname = "b",
                Lastname = "b",
                Iban = "1234",
                Ssn = "1234"
            };
            AccountDTO accountDTO3 = new AccountDTO
            {
                Id = 2,
                Balance = 600.0,
                Iban = "1234"
            };

            try
            {
                Console.WriteLine(accountService.InsertAccount(accountDTO));
                // Console.WriteLine(accountService.InsertAccount(accountDTO1));
                Console.WriteLine(accountService.InsertAccount(accountDTO2));
                // Console.WriteLine(accountService.InsertAccount(accountDTO3));
            }
            catch (AccountIbanAlreadyExistsException  e)
            {
                Console.WriteLine(e.Message);
            }
             catch (AccountIdAlreadyExistsException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            try
            {
                Console.WriteLine(accountService.GetAccountById(1));
                 //Console.WriteLine(accountService.GetAccountById(3));
                Console.WriteLine(accountService.GetAccountByIban("1234"));
                // Console.WriteLine(accountService.GetAccountByIban("7"));
            }
            catch (AccountNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            List<Account> accountList = accountService.GetAll();
            Console.Write('[');
            foreach (Account account in accountList)
            {
                Console.Write('{');
                Console.Write("Id: " + account.Id);
                Console.Write(" Balance: " + account.Balance);
                Console.Write(" Firstname: " + account.Firstname);
                Console.Write(" Lastname: " + account.Lastname);
                Console.Write(" Iban: " + account.Iban);
                Console.Write(" Ssn: " + account.Ssn);
                Console.Write('}');

            }
            Console.Write(']');

            Console.WriteLine();

            try
            {
                accountService.Delete("1234");
                 //accountService.Delete("12");
            }
            catch (AccountNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            List<Account> accountList2 = accountService.GetAll();
            Console.Write('[');
            foreach (Account account in accountList2)
            {
                Console.Write('{');
                Console.Write("Id: " + account.Id);
                Console.Write(" Balance: " + account.Balance);
                Console.Write(" Firstname: " + account.Firstname);
                Console.Write(" Lastname: " + account.Lastname);
                Console.Write(" Iban: " + account.Iban);
                Console.Write(" Ssn: " + account.Ssn);
                Console.Write('}');

            }
            Console.Write(']');

            Console.WriteLine();

            try
            {
                accountService.Deposit("123", 400.0);
                // accountService.Deposit("123", -200.0);
                // accountService.Deposit("89", 100);
            }
            catch (InsufficientAmountException e)
            {
                Console.WriteLine(e.Message);
            }
            catch ( AccountNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            List<Account> accountList3 = accountService.GetAll();
            Console.Write('[');
            foreach (Account account in accountList3)
            {
                Console.Write('{');
                Console.Write("Id: " + account.Id);
                Console.Write(" Balance: " + account.Balance);
                Console.Write(" Firstname: " + account.Firstname);
                Console.Write(" Lastname: " + account.Lastname);
                Console.Write(" Iban: " + account.Iban);
                Console.Write(" Ssn: " + account.Ssn);
                Console.Write('}');

            }
            Console.Write(']');
            Console.WriteLine();

            try
            {
                accountService.Withdraw("123", 250.0, "123");
                // accountService.Withdraw("123", 200.0, "456");
                // accountService.Withdraw("89", 100, "123");
                // accountService.Withdraw("123", 5000, "123");
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch ( SsnNotValidException  e)
            {
                Console.WriteLine(e.Message);
            }
            catch (AccountNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
            Console.Write('[');
            foreach (Account account in accountList3)
            {
                Console.Write('{');
                Console.Write("Id: " + account.Id);
                Console.Write(" Balance: " + account.Balance);
                Console.Write(" Firstname: " + account.Firstname);
                Console.Write(" Lastname: " + account.Lastname);
                Console.Write(" Iban: " + account.Iban);
                Console.Write(" Ssn: " + account.Ssn);
                Console.Write('}');

            }
            Console.Write(']');
            Console.WriteLine();
         }
     }
}
    
