using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class LazyLoadingSingleton
    {
        private static int NumberOfCreatedInstance;

        private static readonly Lazy<LazyLoadingSingleton> Instance =
            new Lazy<LazyLoadingSingleton>(() => new LazyLoadingSingleton());

        private LazyLoadingSingleton()
        {
            NumberOfCreatedInstance++;
            Console.WriteLine("Number of created instance = " + NumberOfCreatedInstance);
        }

        public static LazyLoadingSingleton GetInstance
        {
            get
            {
                return Instance.Value;
            }

        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
