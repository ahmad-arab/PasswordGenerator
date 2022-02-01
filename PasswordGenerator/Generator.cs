
using System;
using System.Collections.Generic;

namespace PasswordGenerator
{
    public static class Generator
    {
        public static Random r = new Random();
        public static int Length = 5;

        private static List<char> CapitalLetters = new List<char> { 'A','B','C','D','E','F','G','H',
                                                                    'I','G','K','L','M','N','O','P',
                                                                    'Q','R','S','T','U','V','W','X',
                                                                    'Y','Z'};
        private static List<char> SmallLetters = new List<char> { 'a','b','c','d','e','f','g','h',
                                                                  'i','j','k','l','m','n','o','p',
                                                                  'q','r','s','t','u','v','w','x',
                                                                  'y','z'};

        private static List<char> Numbers = new List<char> { '1','2','3','4','5','6','7','8','9'};

        private static List<char> Symbols = new List<char> { '!', '#', '@', '%', '$', '-', '_', '&' };


        public static string Generate(IncludeOptions op)
        {
            List<char> picks = new List<char>();

            if(op.IncludeCapitalLetters)
            {
                for (int i = 0; i < op.WeightCapitalLetters; i++)
                    picks.AddRange(CapitalLetters);
            }
            if (op.IncludeSmallLetters)
            {
                for (int i = 0; i < op.WeightSmallLetters; i++)
                    picks.AddRange(SmallLetters);
            }
            if (op.IncludeNumbers)
            {
                for (int i = 0; i < op.WeightNumbers; i++)
                    picks.AddRange(Numbers);
            }
            if (op.IncludeSymbols)
            {
                for (int i = 0; i < op.WeightSymbols; i++)
                    picks.AddRange(Symbols);
            }

            string ans = "";
            for(int i =0; i <Length;i++)
            {
                ans += picks[r.Next(0, picks.Count - 1)];
            }

            return ans;
        }

    }
}
