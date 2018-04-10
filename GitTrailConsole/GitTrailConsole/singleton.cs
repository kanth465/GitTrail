using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrailConsole
{
    public sealed class singleton
    {
        private static int counter = 0;
        private static readonly object obj = new object();
        private static singleton Instance = null;
        public static singleton GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    lock (obj)
                    {
                        if (Instance == null)
                            Instance = new singleton();
                    }
                }
                return Instance;
            }
        }
        private singleton()
        {
            counter++;
            Console.WriteLine("counter value " + counter);
        }
        public void printdetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
