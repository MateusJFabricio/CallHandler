
namespace CallHandlerConfigurator
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxProcessos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProcessoExibir = new System.Windows.Forms.TextBox();
            this.btnTestar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtInicializar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProcurarAtalho = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbMaximizado = new System.Windows.Forms.RadioButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione um processo para exibir:";
            // 
            // listBoxProcessos
            // 
            this.listBoxProcessos.FormattingEnabled = true;
            this.listBoxProcessos.Location = new System.Drawing.Point(12, 25);
            this.listBoxProcessos.Name = "listBoxProcessos";
            this.listBoxProcessos.Size = new System.Drawing.Size(225, 251);
            this.listBoxProcessos.TabIndex = 2;
            this.listBoxProcessos.SelectedIndexChanged += new System.EventHandler(this.listBoxProcessos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Processo a ser exibido:";
            // 
            // txtProcessoExibir
            // 
            this.txtProcessoExibir.Location = new System.Drawing.Point(269, 25);
            this.txtProcessoExibir.Name = "txtProcessoExibir";
            this.txtProcessoExibir.Size = new System.Drawing.Size(365, 20);
            this.txtProcessoExibir.TabIndex = 4;
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(478, 279);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(75, 23);
            this.btnTestar.TabIndex = 5;
            this.btnTestar.Text = "Testar";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(559, 279);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtInicializar
            // 
            this.txtInicializar.Location = new System.Drawing.Point(269, 157);
            this.txtInicializar.Name = "txtInicializar";
            this.txtInicializar.Size = new System.Drawing.Size(365, 20);
            this.txtInicializar.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Caso o processo não esteja inicializado, será necessario inicializá-lo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Atalho para inicializar:";
            // 
            // btnProcurarAtalho
            // 
            this.btnProcurarAtalho.Location = new System.Drawing.Point(573, 183);
            this.btnProcurarAtalho.Name = "btnProcurarAtalho";
            this.btnProcurarAtalho.Size = new System.Drawing.Size(61, 23);
            this.btnProcurarAtalho.TabIndex = 10;
            this.btnProcurarAtalho.Text = "Procurar";
            this.btnProcurarAtalho.UseVisualStyleBackColor = true;
            this.btnProcurarAtalho.Click += new System.EventHandler(this.btnProcurarAtalho_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(162, 282);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "lnk";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Links|*.lnk";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Controls.Add(this.rbMaximizado);
            this.groupBox1.Location = new System.Drawing.Point(273, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 46);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado da exibicao:";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(140, 19);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 4;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbMaximizado
            // 
            this.rbMaximizado.AutoSize = true;
            this.rbMaximizado.Checked = true;
            this.rbMaximizado.Location = new System.Drawing.Point(11, 19);
            this.rbMaximizado.Name = "rbMaximizado";
            this.rbMaximizado.Size = new System.Drawing.Size(80, 17);
            this.rbMaximizado.TabIndex = 3;
            this.rbMaximizado.TabStop = true;
            this.rbMaximizado.Text = "Maximizado";
            this.rbMaximizado.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Inicializador|*.ch";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(307, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 57);
            this.label5.TabIndex = 13;
            this.label5.Text = "Para utilizar o CallHandler, use um comando chamando este configurador com um arg" +
    "umento do arquivo .ch. Exemplo: start CallHandler.exe \"C:\\Teste\\Inicializador.ch" +
    "\"";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 310);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnProcurarAtalho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInicializar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.txtProcessoExibir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxProcessos);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Configurador do CallHandler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxProcessos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcessoExibir;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtInicializar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProcurarAtalho;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbMaximizado;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label5;
    }
}