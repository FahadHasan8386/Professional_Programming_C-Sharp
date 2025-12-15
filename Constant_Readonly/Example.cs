using System;

namespace Constant_Readonly
{
    public class Example
    {
        // Compile-time Constant
        public const int Num = 0;
    }

    // Runtime Constant
    public class Example2
    {
        public static readonly string Name = "Fahad Hasan";
    }

    // Static readonly with Constructor
    class Config
    {
        public static readonly DateTime AppStartTime;

        static Config()
        {
            AppStartTime = DateTime.Now;
        }
    }

    
}
