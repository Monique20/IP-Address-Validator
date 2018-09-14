using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPAddressValidatorKata
{
    public interface IValidator
    {
        bool ValidateIPAddress(string ipAddress);
        void SetSuccessor(IValidator nextValidator);
    }
}
