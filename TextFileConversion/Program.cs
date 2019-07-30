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

        public static void CreateOrOpenDirectory() // Метод для выбора пользователем "да/нет" создания или использования уже существующей директории
        {
            Console.WriteLine("Do you want to create a new directory?");
            Console.WriteLine("Y/N");
        }

        public static void CreateNewDirectory()  // Метод создания новой директории, если пользователь ответил "да"
        {
            string answerYDirectory = Console.ReadLine(); // Создаем переменную когда пользователь нажимает "y"

            if (answerYDirectory == "y")
            {
                Console.WriteLine("Enter the path to create a new directory."); // Введите путь для создания новой директории.

                string PathFileDirectoryNew = Console.ReadLine(); // Сахраняем путь директории введенный пользователем

                while (true)

                {
                    if (System.IO.Directory.Exists(PathFileDirectoryNew)) // Если путь верный то выводим сообщение "директория создана"
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
        }

        public static void OpenDirectory() // Метод использования существующей директории, если пользователь ответил "нет"
        {
            string answerNDirectory = Console.ReadLine(); // Создаем переменную когда пользователь нажимает "n"

            if (answerNDirectory == "n")
            {
                Console.WriteLine("Enter the path to the directory where the file with the processed data will be."); // Введите путь к директории, в которой будет файл с обработанными данными.
                Console.ReadLine();

                string PathFileDirectory = Console.ReadLine(); // Сахраняем путь директории введенный пользователем

                while (true)

                {
                    if (System.IO.Directory.Exists(PathFileDirectory)) // Если путь верный то выводим сообщение "введите имя файла, в который сохраняться обработанные данные"
                    {
                        Console.WriteLine("Enter the name of the file to which the processed data is saved."); // "введите имя файла, в который сохраняться обработанные данные"

                    }
                }

            }
        }

        public static void CreateNewFile() // Метод для создания нового файла для записи данных
        {
            Console.WriteLine("Enter the full path and name of the file with the format to create a file in which the processed data will be saved."); // "Введите полный путь и название файла с форматом, чтобы создать файл, в который будут сохранены обработанные данные. "
            Console.WriteLine(@"Example: (c:\Users\evgeny.pitinov\Desktop\requirements\Task.txt)"); // Пример: (c:\Users\evgeny.pitinov\Desktop\requirements\Task.txt)

            string PathNewFile = Console.ReadLine();

            FileInfo fi = new FileInfo(PathNewFile);           

        }

        public static void AppendFile() // Метод, который дополняет файл данными
        {

        }



    }
}
