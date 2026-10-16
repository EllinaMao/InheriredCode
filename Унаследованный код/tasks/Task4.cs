using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace InheritedCode.tasks
{
    public class Task4
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        const int GWL_STYLE = -16;
        const int WS_BORDER = 0x00800000;

        public static void Run()
        {
            Console.Write("Введите заголовок приложения: ");
            string targetTitle = Console.ReadLine();

            IntPtr hWnd = FindWindow(null, targetTitle);
            if (hWnd != IntPtr.Zero)
            {
                IntPtr hEdit = FindWindowEx(hWnd, IntPtr.Zero, null, "TargetText");

                if (hEdit != IntPtr.Zero)
                {
                    int currentStyle = GetWindowLong(hEdit, GWL_STYLE);

                    SetWindowLong(hEdit, GWL_STYLE, currentStyle ^ WS_BORDER);

                    Console.WriteLine("Стиль текстового поля успешно изменен!");
                }
                else
                {
                    Console.WriteLine("Текстовое поле не найдено в целевом окне.");
                }
            }
            else
            {
                Console.WriteLine("Главное окно не найдено.");
            }
        }
    }
}