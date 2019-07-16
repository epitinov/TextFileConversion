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
                
                string PathFile = Console.ReadLine();  // Сахраняем путь к файлу введенный пользователем

                if (System.IO.File.Exists(PathFile))   // Если путь верный то выводим сообщение "обработка файла"
                {
                    Console.WriteLine("File processing.");
                    using (StreamReader sr = new StreamReader(PathFile))  // Создаем объект sr, который открывает файл и начинает работу с ним
                    {
                        string text = sr.ReadToEnd();  // Чтение данных из файла и сохранение их в объект text
                        using ()
                        {

                        }
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("This file does not exist.Please check the correctness of the entered data.");  // Если путь не верный - выдаем ошибку "проверьте корректность ввода"
                    
                }

            }
            Console.ReadLine();
            

        }
    }
}
