using System;

namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Insert spaces before each capital letter in a string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }

            result = result.Trim();
            return result;
        }

        public static string FormatPersonsName(string firstName, string lastName)
        {
            string fullName =lastName;
            if (!string.IsNullOrWhiteSpace(firstName))
            {
                if (!string.IsNullOrWhiteSpace(fullName))
                {
                    fullName += ", ";
                }
                fullName += firstName;
            }
            return fullName;
        }
    }
}
