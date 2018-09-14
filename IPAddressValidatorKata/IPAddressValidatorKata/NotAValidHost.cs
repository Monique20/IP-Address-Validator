using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPAddressValidatorKata
{
    public class NotAValidHost : IValidator
    {
        private IValidator _nextValidator;

        public void SetSuccessor(IValidator nextValidator)
        {
            _nextValidator = nextValidator;
        }

        public bool ValidateIPAddress(string ipAddress)
        {
            var splitValues = SplitValues(ipAddress);
            if (NotValidHostAddress(splitValues))
            {
                return false;
            }

            return true;
        }

        private static bool NotValidHostAddress(string[] splitValues)
        {
            return splitValues[3] == "0" || splitValues[3] == "255";
        }

        private static string[] SplitValues(string ipAddress)
        {
            return ipAddress.Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
