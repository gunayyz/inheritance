namespace Extension
{
    public static class ExtensionMethods
    {

        public static bool CustomContains(this string word, string str)
        {
            if (word.Contains(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CustomContains(this string word, char part)
        {
            if (word.Contains(part))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
            public static bool IsPrime(this int number)
            {
                int count = 0;
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
    }
}

