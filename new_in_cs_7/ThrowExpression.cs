using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_in_cs_7
{
    class ThrowExpression
    {

        public ThrowExpression(string fname, string lname)
        {
            Console.WriteLine("-----------Exception Throw-------------");
            //FirstName = fname ?? throw new ArgumentNullException(fname);
            FirstName = fname ?? throw new ArgumentNullException(paramName: nameof(fname), message:"First name shouldn't be null");
            FirstName = lname;
        }

        public double Get_Percentage() => throw new NotImplementedException();

        public string FirstName { get; set; } 
        public string LastName { get; set; }
    }
}
