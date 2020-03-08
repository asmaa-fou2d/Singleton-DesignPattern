using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class ThreadSafeSingleton
    {
        private static int NumberOfCreatedInstance = 0;

        private static ThreadSafeSingleton instance = null;
        private static readonly object Instancelock = new object();

        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                //uncomment the following if 
                //if (instance == null)
                //{
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                }
                // }
                return instance;
            }
        }

        private ThreadSafeSingleton()
        {
            NumberOfCreatedInstance++;
            Console.WriteLine("Number of created instance = " + NumberOfCreatedInstance);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
