using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Singleton
{
    sealed class SingletonV2
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private SingletonV2()
        {
            counter++;
            //Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static SingletonV2 instance = null;

        public static SingletonV2 GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonV2();
                        }
                    }
                }
                return instance;
            }
        }
        public string PrintDetails()
        {
            //Console.WriteLine(message);
            return "Counter Value of SingletonV2 is " + counter.ToString();
        }
    }
}
