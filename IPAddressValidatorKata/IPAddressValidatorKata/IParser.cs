using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPAddressValidatorKata
{
    public interface IParser
    {
        bool Parse(string ipAddress);
        void SetSuccessor(IParser nextParser);
    }
}
