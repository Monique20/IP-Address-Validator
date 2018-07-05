using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IPAddressValidatorKata
{
    public class IPAddressValidator
    {
        public bool ValidateIpv4Address(string ipAddress)
        {
            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                return false;
            }

            var splitValues = ipAddress.Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);

            if(splitValues.Length != 4)
            {
                return false;
            }
            if (splitValues[3] == "0" || splitValues[3] == "255")
            {
                return false;
            }
            return true;
        }

    }
}
