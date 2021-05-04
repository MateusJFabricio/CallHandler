using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CallHandler
{
    class Program
    {
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        static void Main(string[] args)
        {
            var handle = GetConsoleWindow();

            if (args.Length != 1)
            {
                Log("Está faltando o caminho da aplicacao como argumento!");
                return;
            }

            if (args[0] == "Listar")
            {
                ListarProcessos();
                return;
            }

            // Hide
            ShowWindow(handle, SW_HIDE);

            if (!File.Exists(args[0]))
            {
                Log("O comando expecificado não existe. Comando: " + args[0]);
                return;
            }
                

            bool encontrado = false;
            var processos = Process.GetProcesses();

            foreach (var proc in processos)
            {
                if (proc.MainWindowHandle.ToInt32() != 0 && proc.MainWindowTitle.Length > 0)
                {
                    try
                    {
                        if (proc.MainModule.FileName == args[0])
                        {
                            encontrado = true;
                            ShowWindowAsync(proc.MainWindowHandle, SW_SHOWMINIMIZED);
                            ShowWindowAsync(proc.MainWindowHandle, SW_SHOWNORMAL);
                            break;
                        }
                    }
                    catch
                    {

                    }


                }
            }

            if (!encontrado)
            {
                Process.Start(args[0]);
            }
        }

        private static void ListarProcessos()
        {
            var processos = Process.GetProcesses();

            foreach (var proc in processos)
            {
                if (proc.MainWindowHandle.ToInt32() != 0 && proc.MainWindowTitle.Length > 0)
                {
                    try
                    {
                        Console.WriteLine(proc.MainModule.FileName);
                    }
                    catch
                    {

                    }
                }
            }
            Console.WriteLine("Finalizado... Aperte enter");
            Console.ReadLine();
        }

        public static void Log(string mensagem)
        {
            MessageBox.Show("Houve um erro ao executar o comando! (Digite \"Listar\" como argumento) " + Environment.NewLine +
                "Mensagem: " + Environment.NewLine + 
                mensagem, "Erro ao executar o comando", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
