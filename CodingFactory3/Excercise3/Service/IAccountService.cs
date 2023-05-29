using Excercise3.DTO;
using Excercise3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.Service
{
    internal interface IAccountService
    {
        /**
     * Εισάγει ένα νέο αντικείμενο Account στην πηγή δεδομένων.
     * @param accountDTO το αντικείμενο AccountDTO που περιέχει τα δεδομένα του λογαριασμού.
     * @return το αποτέλεσμα του λογαριασμού
     * @throws AccountIbanAlreadyExistsException αν το iban του accountDTO υπάρχει ήδη.
     * @throws AccountIdAlreadyExistsException αν το id του accountDTO υπάρχει ήδη.
     */
        public Account InsertAccount(AccountDTO accountDTO);

        /**
         * Επιστρέφει ένα αντικείμενο Account με βάση το ID.
         * @param id το ID του λογαριασμού που θέλουμε να επιστρέψουμε.
         * @return το αντικείμενο Account.
         * @throws AccountNotFoundException αν το ID του λογαριασμού δεν υπάρχει.
         */
        public  Account GetAccountById(long id);

        /**
         * Επιστρέφει ένα αντικείμενο Account με βάση το IBAN.
         * @param iban το IBAN του λογαριασμού που θέλουμε να επιστρέψουμε.
         * @return το αντικείμενο Account.
         * @throws AccountNotFoundException αν το IBAN του λογαριασμού δεν υπάρχει.
         */
         public  Account GetAccountByIban(string iban);

        /**
         * Επιστρέφει όλα τα αντικείμενα Account από την πηγή δεδομένων.
         * @return μια λίστα με τα αντικείμενα Account.
         */
          public  List<Account> GetAll();

        /**
         * Διαγράφει το αντικείμενο Account από την πηγή δεδομένων.
         * @param iban το IBAN του λογαριασμού που θέλουμε να διαγράψουμε.
         * @throws AccountNotFoundException αν το IBAN του λογαριασμού δεν υπάρχει.
         */
         public void Delete(string iban);

        /**
         * Καταθέτει κεφάλαια στον λογαριασμό του Account στην πηγή δεδομένων.
         * @param iban το IBAN του λογαριασμού που θέλουμε να καταθέσουμε.
         * @param amount το ποσό που θα κατατεθεί στον λογαριασμό.
         * @throws InsufficientAmountException αν το ποσό είναι ανεπαρκές.
         * @throws AccountNotFoundException αν το IBAN του λογαριασμού δεν υπάρχει.
         */
        public void Deposit(string iban, double amount);

        /**
         * Αναλαμβάνει ανάληψη κεφαλαίου από τον λογαριασμό.
         * @param iban το IBAN του λογαριασμού που θέλουμε να αναλάβουμε κεφάλαιο.
         * @param amount το ποσό που θα αναληφθεί από τον λογαριασμό.
         * @param ssn το ΑΦΜ του λογαριασμού που αναλαμβάνει την ανάληψη.
         * @throws InsufficientBalanceException αν το υπόλοιπο είναι ανεπαρκές.
         * @throws SsnNotValidException αν το ΑΦΜ δεν είναι έγκυρο.
         * @throws AccountNotFoundException αν το IBAN του λογαριασμού δεν υπάρχει.
         */
         public void Withdraw(string iban, double amount, string ssn);
    }
}

