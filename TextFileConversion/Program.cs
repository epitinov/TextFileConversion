using System;
using System.IO;

namespace TextFileConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, we are pleased to welcome you! Thank you for choosing our app.");

            while (true)
            {
                Console.WriteLine("Please enter the file path and file name to process.");
                
                var PathFile = Console.ReadLine();

                if (System.IO.File.Exists(PathFile))
                {
                    Console.WriteLine("File processing.");
                    using (StreamReader sr = new StreamReader(PathFile))
                    {
                        string text = sr.ReadToEnd();
                        using () 
                        {

                        }
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("This file does not exist.Please check the correctness of the entered data.");
                    
                }

            }
            Console.ReadLine();
            

        }
    }
}
