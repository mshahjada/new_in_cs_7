using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_in_cs_7
{
    class DiscardFeature
    {
        
        private static (string, int, int, int) ResultGenerator(string name, int from, int to)
        {
            int  result = 0;

            while(from< to)
            {
                if (name == "add")
                {
                    result+= from++;
                }
                else
                {
                    from = to;
                    name = "odvut";
                    result = 10;
                }
            }
            return (name, from, to, result);
        }

        public static void Initialize()
        {
            var (_, from, limit, res) = ResultGenerator("addd", 10, 13);
            Console.WriteLine($"Result : {res}");
        }
    }
}
