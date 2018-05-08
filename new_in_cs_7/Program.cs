using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_in_cs_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*---------1. Out varibale----------*/
            OutVariable outvar = new OutVariable();
            outvar.Initialize();

            /*---------2. Tuple ----------*/
            TupleFeature tf = new TupleFeature();
            tf.Initialize();

            /*---------3. Discard ----------*/
            DiscardFeature.Initialize();

            /*---------4. Throw Exception----------*/
            try
            {
                ThrowExpression te = new ThrowExpression(null, "");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            /*---------Task Type In C# 6----------*/
            var res = AsyncReturn.GetNotification();
            res.Wait();

            Console.Write($"{AsyncReturn.GetGPA().Result}\n");


            /*---------5. Generalized async return types and ValueTask----------*/
            //Install packages from nuget
            //System.Threading.Tasks.Extensions
            //light weight implementation for returning value
            var obj = AsyncReturn.GeneralizedAsync().GetAwaiter();
            Console.WriteLine($"Random value: {obj.GetResult()}");

            //*---------6. Numeric literal syntax improvements----------*/

            //digit separator '_' is used for 10 base number as thousand separator
            //works with int, double, decimal, float
            //100_000_000

            //for binary representation use 0b as prefix as digit separator '_' is used.
            // const int one = 0b0001
            // const int eleven = 0b1011
            // const int thiryone = 0b0001_1111
            // const int thiryone = 0b0010_0000


            Console.ReadKey();
        }



    }
}
