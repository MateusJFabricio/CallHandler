using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CallHandlerConfigurator
{
    class CallHandler
    {
        IniFile ini;
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
        public CallHandler(string iniPath)
        {
            if (!File.Exists(iniPath))
                throw new Exception("O arquivo inicializador não existe. Abra o Configurador em modo tela e crie um inicializador");

            ini = new IniFile(iniPath);
        }

        public CallHandler()
        {

        }
        public void Start()
        {
            if (!AbrirProcesso())
                AbrirAtalho();
        }
        public bool AbrirProcesso()
        {
            return AbrirProcesso(ini.Read("NOMEPROCESSO"), ini.Read("ESTADO") == "MAXIMIZADO");
        }
        public bool AbrirProcesso(string nomeProcesso, bool maximizado)
        {

            bool encontrado = false;
            var processos = Process.GetProcesses();

            foreach (var proc in processos)
            {
                if (proc.MainWindowHandle.ToInt32() != 0 && proc.MainWindowTitle.Length > 0)
                {
                    try
                    {
                        if (proc.ProcessName == nomeProcesso)
                        {
                            encontrado = true;
                            ShowWindowAsync(proc.MainWindowHandle, SW_SHOWMINIMIZED);
                            if (maximizado)
                                ShowWindowAsync(proc.MainWindowHandle, SW_SHOWMAXIMIZED);
                            else
                                ShowWindowAsync(proc.MainWindowHandle, SW_SHOWNORMAL);

                            break;
                        }
                    }
                    catch
                    {
                    }
                }
            }

            return encontrado;
        }
        public void AbrirAtalho()
        {
            AbrirAtalho(ini.Read("ATALHO"));
        }
        public void AbrirAtalho(string path)
        {
            Process.Start(path);
        }
    }


}
