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

        public static void CreateNewDirectory() // Метод для создания или использования уже существующей директории
        {
            Console.WriteLine("Do you want to create a new directory?");
            Console.WriteLine("Y/N");

            string answerYDirectory = Console.ReadLine (); // Создаем переменную когда пользователь нажимает "y"

            if (answerYDirectory == "y")
            {
                Console.WriteLine("Enter the path to create a new directory."); // Введите путь для создания новой директории.
                Console.ReadLine();

                string PathFileDirectoryNew = Console.ReadLine(); // Сахраняем путь директории введенный пользователем

                while(true)

                {
                    if(System.IO.Directory.Exists(PathFileDirectoryNew)) // Если путь верный то выводим сообщение "директория создана"
                    {
                        Console.WriteLine("Directory created.");
                        Directory.CreateDirectory(PathFileDirectoryNew); // Создаем директорию

                        break;
                    }
                    else
                    {
                        Console.WriteLine("You have indicated the wrong path. Please enter valid data."); // Если путь не верный - выдаем ошибку "Вы указали не верный путь. Пожалуйста введите корректные данные."
                    }
                }
                
            }

            string answerNDirectory = Console.ReadLine(); // Создаем переменную когда пользователь нажимает "n"

            if (answerNDirectory == "n")
            {
                Console.WriteLine("Enter the path to the directory where the file with the processed data will be."); // Введите путь к директории, в которой будет файл с обработанными данными.
                Console.ReadLine();

                string PathFileDirectory = Console.ReadLine(); // Сахраняем путь директории введенный пользователем

                while(true)

                {
                    if(System.IO.Directory.Exists(PathFileDirectory)) // Если путь верный то выводим сообщение "введите имя файла, в который сохраняться обработанные данные"
                    {
                        Console.WriteLine("Enter the name of the file to which the processed data is saved."); // "введите имя файла, в который сохраняться обработанные данные"



                    }
                }

            }

        }



    }
}
