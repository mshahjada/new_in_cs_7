using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_in_cs_7
{
    class TupleFeature
    {
        private static void old_format()
        {
            Tuple<string, int> tpl = new Tuple<string, int>("Sagor", 27);
            Console.WriteLine("Tuple Item 1: {0}, Tuple Item 2: {1}", tpl.Item1, tpl.Item2);
        }
        
        private static void new_format()
        {
            //Must have to add package from nuget System.ValueTuple
            //var tpl = ("Hello", "World");
            //Console.WriteLine($"Tuple Item 1: { tpl.Item1}, Tuple Item 2: {tpl.Item2}");

            (string sun, string moon) tpl = ("Hello", "World");
            Console.WriteLine($"Tuple Item 1: { tpl.sun}, Tuple Item 2: {tpl.moon}");
        }

        public void Initialize()
        {
            Console.WriteLine("-----------Tuple Feature-------------");

            old_format();
            new_format();

        }

    }
}
