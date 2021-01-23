using System;
using System.IO;

namespace ReadWriteToTextFile
{

    class Program
    {
        private static string userInput = null;
        private static bool menuIsActive = true;
        private static Random random = new Random();
        static void Main(string[] args)
        {



            while (menuIsActive)
            {
                Console.Clear();
                Console.WriteLine("1) Write TO File \n2) Read File \n3) Look Up");
                userInput = Console.ReadLine();
                int number;

                if (int.TryParse(userInput, out number))
                {
                    Menu(number);
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Number");
                    Console.ReadKey();
                }

            }
        }
        static void Menu(int number)
        {
            switch (number)
            {
                case 1:
                    WriteTxt();
                    Console.ReadKey();
                    break;
                case 2:
                    ReadTxt();
                    Console.ReadKey();
                    break;
                case 3:
                    ReadSpecific();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Please Enter a Valid Number");
                    Console.ReadKey();
                    break;

            }
        }
        static void WriteTxt()
        {
            // Overrides File unless true which will append to the document 
            Console.WriteLine("Writting....");
            StreamWriter sw = new StreamWriter("../../../textFile.txt", true);
            sw.WriteLine($"Line {random.Next(1, 99)}");
            sw.WriteLine($"Line {random.Next(1, 99)}");

            sw.Close();

            var sb = new System.Text.StringBuilder();

            sb.Append("First Line");
            sb.AppendLine();
            sb.Append("Second Line");
            Console.WriteLine(sb.ToString());
        }
        static void ReadTxt()
        {

            string inputLine;
            using (StreamReader reader = new StreamReader("../../../textFile.txt"))
            {
                while ((inputLine = reader.ReadLine()) != null)
                {
                    Console.WriteLine(inputLine);
                }
            }

            // OR 

            //Console.WriteLine("Reading.....");
            //StreamReader sr = new StreamReader("../../../textFile.txt");
            //string line = sr.ReadLine(); //  will just get first line 

            //while (line != null)
            //{
            //    Console.WriteLine(line);
            //    line = sr.ReadLine();
            //}
            //sr.Close();
        }

        static void ReadSpecific()
        {

            Console.WriteLine("Search: ");
            string userInput = Console.ReadLine();
            StreamReader sr = new StreamReader("../../../textFile.txt");
            string line = sr.ReadLine(); //  will just get first line 

            while (line != null)
            {
                if (line.Contains(userInput))
                {
                    Console.WriteLine(line);
                }
                line = sr.ReadLine();
            }
            sr.Close();
        }

    }
}
