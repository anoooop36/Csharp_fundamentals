using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate string MyDle(string str);
    class EventProgram
    {
        event MyDle MyEvent;
        public EventProgram()
        {
            this.MyEvent += new MyDle(this.WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
        static void Main(string[] args)
        {
            EventProgram ep = new EventProgram();
            string result = ep.MyEvent("Tutorials Point");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
