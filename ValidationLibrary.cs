using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE245_LAB5_wamar
{
    class ValidationLibrary
    {
        public static bool GotBadWords(string temp)
        {
            bool result = false;

            string[] strBadWords = { "POOP", "HOMEWORK", "CACA" };

            foreach (string strBW in strBadWords)
                if (temp.Contains(strBW))
                {
                    result = true;
                }

            return result;
        }
        public static bool IsItFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }

            return result;
        }

        public static bool IsValidZip(string temp)
        {
            bool result = false;

            if (temp.Length == 5)
            {
                result = true;
            }

            return result;
        }
        public static bool IsValidPhone(string temp)
        {
            bool result = false;

            if (temp.Length == 10)
            {
                result = true;
            }

            return result;
        }

        public static bool IsValidState(string temp)
        {
            bool result = false;

            if (temp.Length == 2)
            {
                result = true;
            }

            return result;
        }

        public static bool IsValidEmail(string temp)
        {

            bool blnResult = true;

            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation+1);
            int periodLocation = temp.LastIndexOf(".");

            if (temp.Length < 8)
            {
                blnResult = false;
            }
            else if (atLocation < 2)    
            {
                blnResult = false;
            }
            else if (periodLocation + 2 > (temp.Length))    
            {
                blnResult = false;
            }
            return blnResult;
        }

        public static bool IsValidInstagram(string temp)
        {
            bool blnResult = false;

            if (temp.Length < 14 || !(temp.Substring(0,14).Contains("instagram.com/")))
            {
                blnResult = false;
            }
            else
            {
                blnResult = true;
            }
            return blnResult;
        }

        public static bool IsAFutureDate(DateTime temp)
        {
            bool blnResult;

            if (temp <= DateTime.Now)
            {
                blnResult = false;
            }
            else
            {
                blnResult = true;
            }

            return blnResult;
        }

        public static bool IsMinimumAmount(int temp, int min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;
        }

        public static bool IsMinimumAmount(double temp, double min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;
        }

        public static bool IsItFilledInBool(bool temp)
        {
            bool blnResult = false;
            string boolString = temp.ToString();
            if (boolString == "True" || boolString == "False" || boolString == "true" || boolString == "false")
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;
        }

    }
}
