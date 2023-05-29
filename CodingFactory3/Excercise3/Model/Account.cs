using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.Model
{
    public class Account : AbstractEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Ssn { get; set; }
        public string Iban { get; set; }
        public double Balance { get; set; }

        public override string ToString()
        {
            return "Account{" +
                "firstname='" + Firstname + '\'' +
                ", lastname='" + Lastname + '\'' +
                ", ssn='" + Ssn + '\'' +
                ", iban='" + Iban + '\'' +
                ", balance=" + Balance +
                '}';
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (obj == null || GetType() != obj.GetType()) return false;

            Account account = (Account)obj;

            if (Balance.CompareTo(account.Balance) != 0) return false;
            if (Firstname != null ? !Firstname.Equals(account.Firstname) : account.Firstname != null) return false;
            if (Lastname != null ? !Lastname.Equals(account.Lastname) : account.Lastname != null) return false;
            if (!Ssn.Equals(account.Ssn)) return false;
            return Iban.Equals(account.Iban);
        }

        public override int GetHashCode()
        {
            int result;
            long temp;
            result = Firstname != null ? Firstname.GetHashCode() : 0;
            result = 31 * result + (Lastname != null ? Lastname.GetHashCode() : 0);
            result = 31 * result + Ssn.GetHashCode();
            result = 31 * result + Iban.GetHashCode();
            temp = BitConverter.DoubleToInt64Bits(Balance);
            result = 31 * result + (int)(temp ^ (temp >> 32));
            return result;
        }
    }
}
