using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallHandlerConfigurator
{
    public partial class FormMain : Form
    {
        List<Process> processosList = new List<Process>();
        Process processo;
        public FormMain()
        {
            InitializeComponent();

            ListarProcessos();
        }

        private void ListarProcessos()
        {
            var processos = Process.GetProcesses();
            listBoxProcessos.Items.Clear();
            processosList.Clear();
            foreach (var proc in processos)
            {
                if (proc.MainWindowHandle.ToInt32() != 0 && proc.MainWindowTitle.Length > 0)
                {
                    try
                    {
                        listBoxProcessos.Items.Add(proc.ProcessName);
                        processosList.Add(proc);
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ListarProcessos();
        }

        private void listBoxProcessos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProcessos.SelectedItem != null)
                txtProcessoExibir.Text = listBoxProcessos.SelectedItem.ToString();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtInicializar.Text = openFileDialog.FileName;
        }

        private void btnProcurarAtalho_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            if (txtInicializar.Text == "")
            {
                MessageBox.Show("Selecione um atalho de inicializacao");
                return;
            }
            if (txtProcessoExibir.Text == "")
            {
                MessageBox.Show("Selecione um processo a exibir");
                return;
            }

            var call = new CallHandler();
            if (!call.AbrirProcesso(txtProcessoExibir.Text, rbMaximizado.Checked))
            {
                call.AbrirAtalho(txtInicializar.Text);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtInicializar.Text == "")
            {
                MessageBox.Show("Selecione um atalho de inicializacao");
                return;
            }
            if (txtProcessoExibir.Text == "")
            {
                MessageBox.Show("Selecione um processo a exibir");
                return;
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IniFile ini = new IniFile(saveFileDialog.FileName);
                    ini.Write("NOMEPROCESSO", txtProcessoExibir.Text);
                    ini.Write("ATALHO", txtInicializar.Text);
                    if (rbMaximizado.Checked)
                        ini.Write("ESTADO", "MAXIMIZADO");
                    else
                        ini.Write("ESTADO", "NORMAL");

                    MessageBox.Show("Salvo com sucesso");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Houve um erro: " + ex.Message);
                }
                

                
            }
        }
    }
}
