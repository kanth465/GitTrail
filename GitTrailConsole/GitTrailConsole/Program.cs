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

            Parallel.Invoke(
                () => PrintEmpDetails(),
                () => PrintStudentDetails()
                );           
                
            Console.ReadLine();
        }

        private static void PrintStudentDetails()
        {
            singleton fromStudent = singleton.GetInstance;
            fromStudent.printdetails("From Student");
        }

        private static void PrintEmpDetails()
        {
            singleton fromEmp = singleton.GetInstance;
            fromEmp.printdetails("From Emp");
        }
        public static string ShowName(string Name)
        {
            return Name;
        }
    }
}
