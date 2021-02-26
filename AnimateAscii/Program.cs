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


            while (true)
            {
                Thread.Sleep(50);
                Animate.UpdateProgress();
                if (Console.KeyAvailable)
                {
                    GetUserInput();
                }

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
            Restart:
                try
                { 
                    int userInput = Int32.Parse(Console.ReadLine());
                        if (userInput == 1)
                        {
                            Animate.ChangeAnimation("FirstScene");

                        }
                        if (userInput == 3)
                        {
                            Animate.ChangeAnimation("SecondScene");
                        }
                    
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    goto Restart;
                    throw;
                }

            });
        }

    }


}
