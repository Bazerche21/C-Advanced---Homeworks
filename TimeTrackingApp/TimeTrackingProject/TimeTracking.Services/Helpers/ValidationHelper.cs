using System.Text.RegularExpressions;

namespace TimeTracking.Services.Helpers
{
    public static class ValidationHelper
    {
       public static bool ValidatePassword(string password)
       { 
            if(password.Length < 6)
            {
                return false;
            }
            Regex capitalLetterRegex = new("[A-Z]");
            if (!capitalLetterRegex.IsMatch(password))
                return false;
            bool isNum = false;
            foreach (char ch in password)
            {
                isNum = int.TryParse(ch.ToString(), out int num);
                if (isNum)
                    break;
            }
            if (!isNum)
                return false;

            return true;
       }

       public static bool ValidateUsername(string username) 
        {
            if (username.Length < 5)
                return false;
            return true;
        }

        public static bool ValidateFirstAndLastName(string firstName, string lastName)
        {
            bool isNum = false;
            foreach (char ch in firstName)
            {
                isNum = int.TryParse(ch.ToString(), out int num);
                if (!isNum)
                    break;
            }
            if (isNum)
                return true;

            if (!(firstName.Length < 2 || lastName.Length < 2))
                return true;

            return false;
        }

        public static bool ValidateAge(int age)
        {
            if (age < 18 || age > 120)
                return false;
            return true;
        }

        public static bool ValidateNumberOfGuess(string username, string password)
        {
            int attempts = 0;
            const int maxAttempts = 3;
            while (attempts < maxAttempts)
            {
                if (ValidateUsername(username) && ValidatePassword(password))
                {
                    return true;
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"Invalid username or password. Attempts remaining: {maxAttempts - attempts}");
                }
            }
            return false;
        }
    }
}
