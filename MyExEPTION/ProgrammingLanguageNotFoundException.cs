using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExEPTION
{
    public class ProgrammingLanguageNotFoundException : Exception
    {
        public ProgrammingLanguageNotFoundException()
            : base("PHP is not included! You're right, PHP isn't the best language... It's the most amazing language!") { }
    }
}
