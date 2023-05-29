using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.Service.exceptions
{
    internal class SsnNotValidException : Exception
    {
        public SsnNotValidException(string ssn)
            : base($"SSN {ssn} is not valid")
        {
        }
    }
}
