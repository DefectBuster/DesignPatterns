namespace CSharpLib.SingletonPattern.CSharpInDepth_SingletonPattern._1_NotThreadSafe
{
    // Bad Code! Do not use!
    public sealed class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        { }

        public static Singleton GetInstance
        {
            get
            {
                // Two different threads can pass the condition found it true, then both create instances.
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            } // get
        } // GetInstance


        public int Value { get; set; }

        public void DisplayValue()
        {
            System.Console.WriteLine("Value: " + Value);
        }
    } // Singleton
}
