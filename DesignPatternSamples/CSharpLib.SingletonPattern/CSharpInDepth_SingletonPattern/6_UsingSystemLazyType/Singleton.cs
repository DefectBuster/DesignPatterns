using System;

namespace CSharpLib.SingletonPattern.CSharpInDepth_SingletonPattern._6_UsingSystemLazyType
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        private Singleton()
        { }
    }
}
