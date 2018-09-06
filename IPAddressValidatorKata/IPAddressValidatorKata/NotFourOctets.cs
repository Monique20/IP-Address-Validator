using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPAddressValidatorKata
{
    public class NotFourOctets : IParser
    {
        private IParser _nextParser;

        public void SetSuccessor(IParser nextParser)
        {
            _nextParser = nextParser;
        }

        public bool Parse(string ipAddress)
        {
            var splitValues = SplitValues(ipAddress);
            if (NotInFourGroups(splitValues))
            {
                return false;
            }
            return _nextParser.Parse(ipAddress);
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
