using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AnimateAscii
{
    static class Animate
    {
        // List of List form multiple animations 
        private static List<List<string>> mettatonAnimations = new List<List<string>>();

        public static int _currentFrame { get; set; }
        public static int _animationNum { get; set; }

        public static void UpdateProgress()
        {

            // Current Animation Frame Count
            int AnimationLength = mettatonAnimations[_animationNum].Count;

            // Store the current position of the cursor
            var originalX = Console.CursorLeft;
            var originalY = Console.CursorTop;

            // Hide cursor to improve the visuals (note: we should re-enable at some point)
            Console.CursorVisible = false;

            // Writes text(Animation) to screen 
            //  Console.Write($"{mettatonAnimations[_animationNum][_currentFrame]} {Message._message}");
            Console.Write($"{mettatonAnimations[_animationNum][_currentFrame]} ");


            // Keep looping around all the animation frames
            _currentFrame++;
            if (_currentFrame == AnimationLength)
            {
                _currentFrame = 0;
            }
            // Restore cursor to original position to the top
            Console.SetCursorPosition(originalX, originalY);

        }
        public static void LoadAscii(string fileName = "MettatonToAscii.txt")
        {

            string inputLine;
            string temp = "";
            List<string> mettatonCurrentAnimation = new List<string>();

            using (StreamReader reader = new StreamReader($"../../../AsciiText/{fileName}"))
            {
                while ((inputLine = reader.ReadLine()) != null)
                {
                    if (!inputLine.Contains("@//"))
                    {
                        temp += inputLine + "\n";
                    }

                    else if (inputLine.Contains("@//"))
                    {
                        mettatonCurrentAnimation.Add(temp);
                        temp = "";
                    }
                }
                mettatonAnimations.Add(mettatonCurrentAnimation);
            }


            if (mettatonAnimations.Count == 1)
            {
                LoadAscii("MettatonToAsciiQuestioning.txt");
            }

        }
    }
}
