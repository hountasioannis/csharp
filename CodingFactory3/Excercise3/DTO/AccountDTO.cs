using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.DTO
{
    internal class AccountDTO
    {
        public long Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Ssn { get; set; }
        public string Iban { get; set; }
        public double Balance { get; set; }
    }
}
