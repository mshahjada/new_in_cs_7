using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace new_in_cs_7
{
    class AsyncReturn
    {
        public static async Task GetNotification()
        {
            Console.WriteLine("-----------Task Feature in C# 6-------------");
            await Task.Delay(5000);
            Console.WriteLine("I'm free");
        }

        public static async Task<double> GetGPA()
        {
            await Task.Delay(2000);
            Console.WriteLine("Showing your GPA: ");
            return 4.63;
        }

        public static async ValueTask<int>  GeneralizedAsync()
        {
            Console.WriteLine("-----------Generalized Value Task-------------");
            Random rd = new Random();
            return rd.Next(10,999);
        }
    }
}
