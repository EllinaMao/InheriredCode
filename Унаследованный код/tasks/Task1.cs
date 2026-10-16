using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace InheritedCode.tasks
{
    public class Task1
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        public static void Run()
        {
            Console.WriteLine("Задание 1");
            MessageBox(IntPtr.Zero, "Оля Пухаленко", "Ин-фа про разработчика", 0);
            MessageBox(IntPtr.Zero, "Город Одесса", "Локация", 0);
            MessageBox(IntPtr.Zero, "Стек: C#, .NET, Python, React Native, С++",  "Навыки", 0);
        }
    }
}
