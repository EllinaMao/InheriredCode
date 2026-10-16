using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace InheritedCode.tasks
{
    public class Task3
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(uint dwFreq, uint dwDuration);

        [DllImport("user32.dll")]
        public static extern bool MessageBeep(uint uType);

        public static void Run()
        {
            Console.WriteLine("Звуковые сигналы...");

            Beep(500, 600);
            Thread.Sleep(500);

            MessageBeep(0x00000000);
            Thread.Sleep(500);

            Beep(1000, 300);

            Console.WriteLine("Завершено.");
        }
    }
}
