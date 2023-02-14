using System.Linq;

namespace DelegateGUIs
{
    public static class Utilities
    {
        public static bool IsValidMobileNumber(string number)
        {
            if (string.IsNullOrEmpty(number))
                return false;

            // Mobile number must contain only digits and be 11 digits long
            if (number.Length != 11 || !number.All(char.IsDigit))
                return false;

            // Mobile number must start with a valid prefix
            string[] validPrefixes = { "06", "07", "08", "09" };
            if (!validPrefixes.Any(number.StartsWith))
                return false;

            return true;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            int atIndex = email.IndexOf('@');

            // Email must contain an "@" symbol
            if (atIndex == -1)
                return false;

            string localPart = email.Substring(0, atIndex);
            string domainPart = email.Substring(atIndex + 1);

            // Local part must not be empty and must not start or end with a period
            if (string.IsNullOrEmpty(localPart) || localPart[0] == '.' || localPart[localPart.Length - 1] == '.')
                return false;

            // Domain part must contain at least one period and must not end with a period
            if (domainPart.IndexOf('.') == -1 || domainPart[domainPart.Length - 1] == '.')
                return false;

            return true;
        }
    }
}