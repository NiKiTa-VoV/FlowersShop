using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryFlowersShop
{
    public static class ConsoleCustom
    {

        public static void ConsoleStart()
        {
            Task.Factory.StartNew(Console);
        }
        private static void Console()
        {
            // Запускаем консоль.
            if (AllocConsole())
            {
                System.Console.WriteLine("Для выхода наберите exit.");
                while (true)
                {
                    // Считываем данные.
                    string output = System.Console.ReadLine();
                    if (output == "exit")
                        break;
                    // Выводим данные в textBox
                }
                // Закрываем консоль.
                FreeConsole();
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();
    }
    
}