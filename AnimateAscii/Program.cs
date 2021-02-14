using System;
using System.Threading;

namespace AnimateAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            Animate.LoadAscii();
            SetConsole();

            while (true)
            {

                Thread.Sleep(50);
                Animate.UpdateProgress();
            }
            
        }
        private static void SetConsole()
        {
            // Sets Console window 
            Console.WindowHeight = 63;
            Console.WindowWidth = 89;

            Console.SetBufferSize(220, 242);
        }
    }

    
}
