using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib.SingletonPattern.CSharpInDepth_SingletonPattern._3_ThreadSafeDoubleCheckLock
{
    // Bad code! Do not use!
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padLock = new object();

        Singleton()
        { }

        public Singleton GetInstance
        {
            get
            {
                // Attempts to be thread safe without the necessity of taking out a lock very time.
                if(instance == null) // First Check
                {
                    lock(padLock)
                    {
                        if(instance == null) // Double Check
                        {
                            instance = new Singleton();
                        }
                    }
                }

                return instance;
            } // get
        } // GetInstance
    } // Singleton
}
