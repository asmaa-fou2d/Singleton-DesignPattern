using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class NotSealedSingleton
    {
        private static int NumberOfCreatedInstance = 0;
        private static NotSealedSingleton instance = null;
        public static NotSealedSingleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new NotSealedSingleton();

                return instance;
            }
        }

        private NotSealedSingleton()
        {
            NumberOfCreatedInstance++;
            Console.WriteLine("Number of created instance = " + NumberOfCreatedInstance);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        // nested class 
        public class DerivedSingleton : NotSealedSingleton
        {

        }

    }


    //is inaccessible due to its protection level
    //public class DerivedSingleton : NotSealedSingleton
    //{
    //}

}
