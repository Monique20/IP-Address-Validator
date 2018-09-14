using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPAddressValidatorKata
{
    public class NullOrEmpty : IValidator
    {
        private IValidator _nextValidator;

        public void SetSuccessor(IValidator nextValidator)
        {
            _nextValidator = nextValidator;
        }

        public bool ValidateIPAddress(string ipAddress)
        {
            if (IsNullOrEmpty(ipAddress))
            {
                return false;
            }
            return _nextValidator.ValidateIPAddress(ipAddress);
        }

        private static bool IsNullOrEmpty(string ipAddress)
        {
            return string.IsNullOrWhiteSpace(ipAddress);
        }
    }
}
