namespace CSharpLib.SingletonPattern.CSharpInDepth_SingletonPattern._5_FullyLazyInstantiation
{
    public sealed class Singleton
    {
        private Singleton()
        { }

        public static Singleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            /// <summary>
            /// Explicit static-constructor to tell C# compiler
            /// not to mark type as beforefieldinit <seealso cref="http://csharpindepth.com/Articles/General/BeforeFieldInit.aspx"/>
            /// </summary>
            static Nested()
            { }

            internal static readonly Singleton instance = new Singleton();
        }
    }
}
