using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    //the above example is not to thread-safe.It means in a multithreaded environment, it will able to create multiple instances of 
    //the singleton class.

    public sealed class NoThreadSafeSingleton
    {
        private static int NumberOfCreatedInstance = 0;

        private static NoThreadSafeSingleton instance = null;

        public static NoThreadSafeSingleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new NoThreadSafeSingleton();

                return instance;
            }
        }

        private NoThreadSafeSingleton()
        {
            NumberOfCreatedInstance++;
            Console.WriteLine("Number of created instance = " + NumberOfCreatedInstance);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    // can't derive form sealed class
    //public class DerivedSingleton : NoThreadSafeSingleton
    //{
    //}
}
