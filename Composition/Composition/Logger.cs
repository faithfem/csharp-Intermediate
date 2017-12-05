using System;

namespace Composition //A kind of rltnshp btw 2 classes that allows one to contain the other. Benefits: code reuse, flexibility, loose-coupling
{
    public class Logger //Connects to diff files instead of each file having its own logger. This shared class is a private fied in the class that encompasses it.
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
