using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Singleton
{
    sealed class SingletonV1
    {
        private static int counter = 0;
        private static SingletonV1 instance = null;
        public static SingletonV1 GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonV1();
                return instance;
            }
        }

        private SingletonV1()
        {
            counter++;
            //Console.WriteLine("Counter Value " + counter.ToString());
        }
        public string PrintDetails()
        {
            return "Counter Value SingletonV1 is " + counter.ToString();
        }
    }
}
