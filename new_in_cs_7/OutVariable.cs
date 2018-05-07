using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace new_in_cs_7
{
    class OutVariable
    {
        private static void old_format(string val)
        {
            int res = 0;
            if (Int32.TryParse(val, out res))
                Console.WriteLine("Result: {0}", res);
            else
                Console.WriteLine("Unable to parse");

        }

        private static void new_format(string val)
        {
            if (Int32.TryParse(val, out int res))
                Console.WriteLine($"Result: {res}");
            else
                Console.WriteLine("Unable to parse");
        }

        public void Initialize()
        {
            Console.WriteLine("-----------Out Variable-------------");

            Console.Write("Enter a value: ");
            string val = Console.ReadLine();

            old_format(val);
            new_format(val);

        }


    }
}
