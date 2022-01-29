
using System;
using System.Collections.Generic;

namespace PasswordGenerator
{
    public static class Generator
    {
        public static Random r = new Random();
        public static int Length = 5;

        public static string GenerateUsername()
        {
            List<char> picks = new List<char> {'A','B','C','D','E','F',  'd','e','f','g','h','g',
                                               'G','H','I','J','K','L',  'm','l','k','j','i','h',
                                               'R','Q','P','O','N','M',  'n','o','p','q','r','s',
                                               'S','T','U','V','W','X',  'y','x','w','v','u','t',
                                               'c','b','a','A','Z','Y',  'z','B','C','D','E','F',};
            string ans = "";
            for(int i =0; i <Length;i++)
            {
                ans += picks[r.Next(0, picks.Count - 1)];
            }

            return ans;
        }

        public static string GeneratePassword()
        {
            List<char> picks = new List<char> {'A','B','C','D','E','F',  'd','e','f','g','h','g',  '1','2','3','4','5','6',
                                               'G','H','I','J','K','L',  'm','l','k','j','i','h',  '1','0','0','9','8','7',
                                               'R','Q','P','O','N','M',  'n','o','p','q','r','s',  '2','3','4','5','6','7',
                                               'S','T','U','V','W','X',  'y','x','w','v','u','t',  'd','e','f','g','h','8',
                                               'c','b','a','A','Z','Y',  'z','B','C','D','E','F',  '3','2','1','0','0','9',

                                               '4','5','6','7','8','9',  '@','@','#','#','_','_',  '2','3','4','5','6','7',
                                               '%','#','#','@','@','0',  'y','x','w','v','u','t',  'd','e','f','g','h','8',
                                               '%','$','$','-','-','!',  'z','B','C','D','E','F',  '3','2','1','0','0','9',
                                                                                                                          };
            string ans = "";
            for (int i = 0; i < Length; i++)
            {
                ans += picks[r.Next(0, picks.Count - 1)];
            }

            return ans;
        }
    }
}
