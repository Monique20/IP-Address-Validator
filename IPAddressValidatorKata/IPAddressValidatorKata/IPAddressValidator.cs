using System;
using System.Net;

namespace IPAddressValidatorKata
{
    public class IPAddressValidator
    {
        public bool ValidateIpv4Address(string ipAddress)
        {
            //if (IsNullOrEmpty(ipAddress))
            //{
            //    return false;
            //}

            //var splitValues = SplitValues(ipAddress);
            //if (NotInFourGroups(splitValues))
            //{
            //    return false;
            //}
            //if (NotValidHostAddress(splitValues))
            //{
            //    return false;
            //}
            return true;
        }

        //private static string[] SplitValues(string ipAddress)
        //{
        //    return ipAddress.Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);
        //}

        //private static bool NotValidHostAddress(string[] splitValues)
        //{
        //    return splitValues[3] == "0" || splitValues[3] == "255";
        //}

        //private static bool NotInFourGroups(string[] splitValues)
        //{
        //    return splitValues.Length != 4;
        //}

        //private static bool IsNullOrEmpty(string ipAddress)
        //{
        //    return string.IsNullOrWhiteSpace(ipAddress);
        //}
    }
}
