using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib.SingletonPattern.CSharpInDepth_SingletonPattern._4_ThreadSafeWithoutUsingLock
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        // Private Constructor: restrict class from being instanciate in other class.
        Singleton()
        { }

        /// <summary>
        /// Explicit static constructor to tell C# compiler not to 
        /// mark type as beforefieldinit <seealso cref="http://csharpindepth.com/articles/general/beforefieldinit.aspx"/>
        /// </summary>
        static Singleton()
        { }

        public static Singleton GetInstance
        {
            get
            {
                return instance;
            }
        }

        public int Value { get; set; }

        public void DisplayValue()
        {
            System.Console.WriteLine("Value: " + Value);
        }
    }
}
