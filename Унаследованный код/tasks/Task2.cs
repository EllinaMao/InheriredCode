using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace InheritedCode.tasks
{
    public class Task2
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_MINIMIZE = 6;

        const uint WM_SETTEXT = 0x000C;
        const uint WM_CLOSE = 0x0010;

        public static void Run()
        {
            Console.Write("Введите заголовок окна: ");
            string? title = Console.ReadLine();
            if (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("Заголовок не может быть пустым.");
                return;
            }
            IntPtr hWnd = FindWindow(null, title);

            if (hWnd != IntPtr.Zero)
            {
                Console.WriteLine("Окно найдено! Выберите действие:");
                Console.WriteLine("1 - Изменить заголовок");
                Console.WriteLine("2 - Закрыть окно");
                Console.WriteLine("3 - Свернуть окно (Собственный вариант)");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите новый заголовок: ");
                        string? newTitle = Console.ReadLine();
     
                        SendMessage(hWnd, WM_SETTEXT, IntPtr.Zero, newTitle);
                        Console.WriteLine("Заголовок изменен.");
                        break;
                    case "2":
                        SendMessage(hWnd, WM_CLOSE, IntPtr.Zero, null);
                        Console.WriteLine("Сигнал на закрытие отправлен.");
                        break;
                    case "3":
                        ShowWindow(hWnd, SW_MINIMIZE);
                        Console.WriteLine("Окно свернуто.");
                        break;
                    default:
                        Console.WriteLine("Неизвестное действие.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Окно не найдено. Убедитесь, что программа запущена.");
            }
        }
    }
}
