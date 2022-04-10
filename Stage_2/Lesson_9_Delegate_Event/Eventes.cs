using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Stage_2.Lesson_9_Delegate_Event
{
    class Account
    {
        public delegate void MyAccount(string message);
        public event MyAccount? Notify;                   // Creates delegate MyAccount event        

        int sum;
        public Account(int sum)
        {
            this.sum = sum;
        }

        public void Add(int sum)
        {
            this.sum += sum;
            Notify?.Invoke($"Input on account {sum}$");
            Notify?.Invoke($"Your balance is {this.sum}$");
        }

        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                Notify?.Invoke($"Taken from account {sum}$");
                Notify?.Invoke($"Your balance is {this.sum}$");
            }
            else
            {
                Notify?.Invoke("Insufficient resources");
                Notify?.Invoke($"Your balance is {this.sum}$");
            }
        }
    }

    internal class Eventes
    {        
        static void Main()
        {
            void DisplayMessage(string message)
            {
                Console.WriteLine(message);
            }

            Account account = new Account(200);
            account.Notify += DisplayMessage;
            account.Add(100);
            Console.WriteLine("======================");
            account.Take(200);
            Console.WriteLine("======================");
            account.Take(150);
        }

        //  Creating events is possible especially if we don't need to do console, but for example we want to send email or sms
        // or do graffic picture of operations
    }
}*/
