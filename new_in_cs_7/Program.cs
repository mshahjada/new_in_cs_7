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
            //1. Out varibale 
            //OutVariable outvar = new OutVariable();
            //outvar.Initialize();

            //2. Tuple 
            //TupleFeature tf = new TupleFeature();
            //tf.Initialize();

            //3. Discard 
            //DiscardFeature.Initialize();

            //4. Throw Exception
            try
            {
                ThrowExpression te = new ThrowExpression(null, "");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            


            Console.ReadKey();
        }
    }
}
