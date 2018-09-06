using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPAddressValidatorKata
{
    public class NullOrEmpty : IParser
    {
        private IParser _nextParser;

        public void SetSuccessor(IParser nextParser)
        {
            _nextParser = nextParser;
        }

        public bool Parse(string ipAddress)
        {
            if (IsNullOrEmpty(ipAddress))
            {
                return false;
            }
            return _nextParser.Parse(ipAddress);
        }

        private static bool IsNullOrEmpty(string ipAddress)
        {
            return string.IsNullOrWhiteSpace(ipAddress);
        }
    }
}
