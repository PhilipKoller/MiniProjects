using System;
using System.Threading;
using System.Threading.Tasks;

namespace AnimateAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            Animate.LoadAscii();
            SetConsole();
            GetUserInput();

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
        public static async void GetUserInput()
        {
            // Allows user to type whithout freexing the UI 
            var t = Task.Run(async delegate
            {
                int userNumber = Int32.Parse(Console.ReadLine());
                if (userNumber == 1)
                {
                    //CHANGES AND RESETS ANIMATION FRAME COUNTER
                    Animate._currentFrame = 0;
                    Animate._animationNum = 1;
                }
            });
        }
        
        }

    
}
