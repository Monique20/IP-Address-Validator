using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPAddressValidatorKata
{
    public class NotFourOctets : IValidator
    {
        private IValidator _nextValidator;

        public void SetSuccessor(IValidator nextValidator)
        {
            _nextValidator = nextValidator;
        }

        public bool ValidateIPAddress(string ipAddress)
        {
            var splitValues = SplitValues(ipAddress);
            if (NotInFourGroups(splitValues))
            {
                return false;
            }
            return _nextValidator.ValidateIPAddress(ipAddress);
        }

        private static bool NotInFourGroups(string[] splitValues)
        {
            return splitValues.Length != 4;
        }

        private static string[] SplitValues(string ipAddress)
        {
            return ipAddress.Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
