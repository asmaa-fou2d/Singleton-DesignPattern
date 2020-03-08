using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    //The Eager loading in singleton design pattern is nothing a process in which we need to initialize the singleton object at the time of application start-up rather than on-demand and keep it ready in memory to be used in the future. 
    public class EagerLoadingSingleton
    {
        private static int NumberOfCreatedInstance = 0;

        private static readonly EagerLoadingSingleton eagerLoadingSingleton = new EagerLoadingSingleton();

        private EagerLoadingSingleton()
        {
            NumberOfCreatedInstance++;
            Console.WriteLine("Number of created instance = " + NumberOfCreatedInstance);
        }

        public static EagerLoadingSingleton GetInstance
        {
            get
            {
                return eagerLoadingSingleton;
            }

        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}