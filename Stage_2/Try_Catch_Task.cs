using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2
{
    internal class Class1
    {
        public static void MyMethod(int a)
        {
            try
            {
                int b = 100 / a;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw e;
                return;
            }

            MyMethod(--a);
        }
        static void Main()
        {
            int a = 30;
            MyMethod(a);
        }
    }
}
