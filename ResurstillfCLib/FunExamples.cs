using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurstillf
{
    public class FunExamples
    {
        public static bool ContainsCoffee(string value)
        {
            const string search = "coffee";

            if (value == null)
                throw new ArgumentNullException();

            value = value.ToLowerInvariant();

            /*
            if (!value.Contains(search))
                return false;
            return true;
            /**/

            /**/
            int index = 0;
            value = " " + value;

            for (int n = 0; n < value.Length; n++)
            {
                if (value[n] == search[index])
                {
                    
                        if (!Char.IsLetter(value[n - 1]))
                        {
                            for (; index < search.Length; )
                            {
                                index++;
                                n++;


                                if (value[n] != search[index])
                                    break;

                                if (index + 1 == search.Length)
                                    return true;
                                if (n + 1 == value.Length)
                                    break;
                            }
                        
                    }
                    index = 0;

                }
            }

            return false;
            /**/
        }
    }
}
