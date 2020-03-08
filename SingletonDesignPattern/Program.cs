using System;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region NoThreadSafeSingleton
            //NoThreadSafeSingleton instance_1 = NoThreadSafeSingleton.GetInstance;
            //instance_1.PrintDetails("create first instance");

            //NoThreadSafeSingleton instance_2 = NoThreadSafeSingleton.GetInstance;
            //instance_1.PrintDetails("create second instance");

            //Console.ReadLine();
            #endregion


            #region NotSealedSingleton
            //by removing the sealed keyword we can inherit the singleton class and also possible to create multiple objects of the singleton class. This violates singleton design principles.
            //NotSealedSingleton instance_1 = NotSealedSingleton.GetInstance;
            //instance_1.PrintDetails("create first instance");

            //NotSealedSingleton instance_2 = NotSealedSingleton.GetInstance;
            //instance_1.PrintDetails("create second instance");

            //NotSealedSingleton.DerivedSingleton Derivedinstance = new NotSealedSingleton.DerivedSingleton();
            //Derivedinstance.PrintDetails("create derived instance");

            //Console.ReadLine();
            #endregion

            #region ThreadSafeSingleton
            Parallel.Invoke(
               () => PrintDetailsForInstanc_1(),
               () => PrintDetailsForInstanc_2()
               );
            Console.ReadLine();
            #endregion
        }


        #region ThreadSafeSingleton
        //private static void PrintDetailsForInstanc_1()
        //{
        //    ThreadSafeSingleton instance_1 = ThreadSafeSingleton.GetInstance;
        //    instance_1.PrintDetails("create first instance");
        //}

        //private static void PrintDetailsForInstanc_2()
        //{
        //    ThreadSafeSingleton instance_2 = ThreadSafeSingleton.GetInstance;
        //    instance_2.PrintDetails("create second instance");
        //}
        #endregion

        #region EagerLoadingSingleton
        //private static void PrintDetailsForInstanc_1()
        //{
        //    EagerLoadingSingleton instance_1 = EagerLoadingSingleton.GetInstance;
        //    instance_1.PrintDetails("create first instance");
        //}

        //private static void PrintDetailsForInstanc_2()
        //{
        //    EagerLoadingSingleton instance_2 = EagerLoadingSingleton.GetInstance;
        //    instance_2.PrintDetails("create second instance");
        //}
        #endregion

        #region LazyLoadingSingleton
        private static void PrintDetailsForInstanc_1()
        {
            LazyLoadingSingleton instance_1 = LazyLoadingSingleton.GetInstance;
            instance_1.PrintDetails("create first instance");
        }

        private static void PrintDetailsForInstanc_2()
        {
            LazyLoadingSingleton instance_2 = LazyLoadingSingleton.GetInstance;
            instance_2.PrintDetails("create second instance");
        }
        #endregion


    }


}
