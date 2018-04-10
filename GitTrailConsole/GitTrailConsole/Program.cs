using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrailConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(ShowName("Ramakanth Kota"));
            singleton fromEmp = singleton.GetInstance;
            fromEmp.printdetails("From Emp");
            singleton fromStudent = singleton.GetInstance;
            fromStudent.printdetails("From Student");
            Console.ReadLine();
        }
        public static string ShowName(string Name)
        {
            return Name;
        }
    }
}
