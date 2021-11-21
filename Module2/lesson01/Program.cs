using System;

namespace lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            Starter starter = new Starter();
            starter.Run();

            starter.SaveLog();
        }
    }
}
