using InheritedCode.tasks;


class Program
{

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Меню заданий ===");
            Console.WriteLine("1. Задание 1 MessageBox");
            Console.WriteLine("2. Задание 2: FindWindow / SendMessage (Управление окном)");
            Console.WriteLine("3. Задание 3: Beep / MessageBeep");
            Console.WriteLine("4. Задание 4: Замена элементов управления");
            Console.WriteLine("0. Выход");
            Console.Write("\nВыберите пункт меню: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task1.Run();
                    break;
                case "2":
                    Task2.Run();
                    break;
                case "3":
                    Task3.Run();
                    break;
                case "4":
                    Task4.Run();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неправильний выбор.");
                    break;
            }

            Console.WriteLine("\nНажмите любую клавишу для возвращения в меню...");
            Console.ReadKey();
        }
    }
}