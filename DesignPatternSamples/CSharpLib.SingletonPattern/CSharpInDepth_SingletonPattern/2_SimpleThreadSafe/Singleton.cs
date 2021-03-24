using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib.SingletonPattern.CSharpInDepth_SingletonPattern._2_SimpleThreadSafe
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        /// <summary>
        /// Restrict the class from being instanciate in other classes
        /// </summary>
        Singleton()
        { }

        public static Singleton Instance
        {
            get
            {
                // 1. The thread takes out a lock on a shared object, and then checks whether or not
                // the instance has been created before creating the instance.
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }
}
