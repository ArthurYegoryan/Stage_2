using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Stage_2
{
    class Variables           // By default class-ը ընդունում է internal modifire-ը, եթե այն չի գտնվում որևէ class-ի կամ struct-ի մեջ
    {
        class MyClass         // Եթե class-ը կամ struct-ը ներդրված են, ապա by default ստանում են private modifire-ը
        {
            string str = "My Class";
            public void PrintMyClass(string str)
            {
                Console.WriteLine(str);
            }
        }

        int a = 5;                        // By default field-ը ընդունում է private modifire-ը
        public int b = 6;                 // Հասանելի է project-ի և այլ project-ի ամբողջ տիրույթում
        private int c = 7;                // Հասանելի է միայն calss-ի տիրույթում
        protected int d = 8;              // Հասանելի է class-ի և տվյալ կամ այլ project-ներում ժառանգ class-ների տիրույթներում  
        internal int e = 9;               // Հասանելի է տվյալ project-ի ամբողջ տարածքում
        private protected int f = 10;     // Հասանելի է տվյալ project-ում class-ի և ժառանգ class-ների տիրույթներում
        protected internal int g = 11;    // Հասանելի է տվյալ project-ի ամբողջ տիրույթում և այլ project-ների ժառանգ class-ներում
    }

    class Variables1 : Variables
    {
        public void PrintVariables()
        {
            //a = 10;        // Error     // By default private
            b = 11;                       // Public
            //c = 12;        // Error     // Private
            d = 13;                       // Protected
            e = 14;                       // Internal
            f = 15;                       // Private protected
            g = 16;                       // Protected internal
        }
    }

    internal class Lesson_2_Access_Modifiress
    {
        static void Main()
        {
            Variables variables = new Variables();

            //Console.WriteLine(variables.a);  // Error   // By default private
            Console.WriteLine(variables.b);               // Public
            //Console.WriteLine(variables.c);  // Error   // Private
            //Console.WriteLine(variables.d);  // Error   // Protected
            Console.WriteLine(variables.e);               // Internal
            //Console.WriteLine(variables.f);  // Error   // Private protected
            Console.WriteLine(variables.g);               // Protected internal
        }
    }
}*/
