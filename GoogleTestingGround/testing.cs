using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTestingGround
{
    class testing
    {
        public static char[] ToCharReverse(string s)
        {
            var charArray = s.ToCharArray();

            Array.Reverse(charArray);

            return charArray;
        }

        public static string Testing(string S, int K)
        {
            var keyArray = ToCharReverse(S.Replace("-", "").ToUpper());
            var tempKey = "";
            
            for (int i = 0; i < keyArray.Length ; i++)
            {
                if (i % (K) == 0 && i != 0 )
                {
                    tempKey = tempKey + "-";
                }

                tempKey += keyArray[i] ;
            }

            return new string(ToCharReverse(tempKey));
        }

        /*public static void Main(string[] args)
        {
            //"2-5g-3-J"
            //2
            var key = Testing("2-5g-3-J", 2);
            Console.WriteLine(key);
            Console.ReadKey();
        }*/
    }
}
