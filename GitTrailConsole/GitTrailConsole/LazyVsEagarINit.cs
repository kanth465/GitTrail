using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTrailConsole
{
    //Singleton class with Lazy and Eagar Initialization
    public sealed class LazyVsEagarINit
    {
        private static int counter = 0;
        //#region Eagar Init
        //private static readonly LazyVsEagarINit Instance = new LazyVsEagarINit();
        //public static LazyVsEagarINit GetInstance
        //{
        //    get
        //    {
        //        return Instance;
        //    }
        //}
        //#endregion
        #region Lazy Init
        private static readonly Lazy<LazyVsEagarINit> Instance = new Lazy<LazyVsEagarINit>(()=>new LazyVsEagarINit());
        public static LazyVsEagarINit GetInstance
        {
            get
            {
                return Instance.Value;
            }
        }
        #endregion
        private LazyVsEagarINit()
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
