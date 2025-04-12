namespace TIGEST
{
    partial class Frm_RecursosAtivos
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Prd_LoadProcess = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Voltar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.Dgv_DataRecursos = new System.Windows.Forms.DataGridView();
            this.Gpr_FiltroData = new System.Windows.Forms.GroupBox();
            this.Lbl_NumBP = new System.Windows.Forms.Label();
            this.Txt_NumBP = new System.Windows.Forms.TextBox();
            this.Ckb_DataFim = new System.Windows.Forms.CheckBox();
            this.Ckb_DataInicio = new System.Windows.Forms.CheckBox();
            this.Lbl_NumSerie = new System.Windows.Forms.Label();
            this.Txt_NumSerie = new System.Windows.Forms.TextBox();
            this.Dtp_Fim = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_NomeObjeto = new System.Windows.Forms.Label();
            this.Txt_NomeObjeto = new System.Windows.Forms.TextBox();
            this.Gpb_FiltrosAtivo = new System.Windows.Forms.GroupBox();
            this.Ckb_NaAtivoAd = new System.Windows.Forms.CheckBox();
            this.Ckb_AtivoAd = new System.Windows.Forms.CheckBox();
            this.Ckb_NaoAtivoAd = new System.Windows.Forms.CheckBox();
            this.Btn_CarregarQwerty = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DataRecursos)).BeginInit();
            this.Gpr_FiltroData.SuspendLayout();
            this.Gpb_FiltrosAtivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Prd_LoadProcess});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1423, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(101, 19);
            this.toolStripStatusLabel1.Text = "TIGEST 0.1 Build 1";
            // 
            // Prd_LoadProcess
            // 
            this.Prd_LoadProcess.Name = "Prd_LoadProcess";
            this.Prd_LoadProcess.Size = new System.Drawing.Size(100, 18);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Menu,
            this.Menu_Voltar,
            this.Menu_Sair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1423, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Menu
            // 
            this.Menu_Menu.Name = "Menu_Menu";
            this.Menu_Menu.Size = new System.Drawing.Size(50, 20);
            this.Menu_Menu.Text = "Menu";
            // 
            // Menu_Voltar
            // 
            this.Menu_Voltar.Name = "Menu_Voltar";
            this.Menu_Voltar.Size = new System.Drawing.Size(49, 20);
            this.Menu_Voltar.Text = "Voltar";
            this.Menu_Voltar.Click += new System.EventHandler(this.Menu_Voltar_Click);
            // 
            // Menu_Sair
            // 
            this.Menu_Sair.Name = "Menu_Sair";
            this.Menu_Sair.Size = new System.Drawing.Size(38, 20);
            this.Menu_Sair.Text = "Sair";
            // 
            // Dgv_DataRecursos
            // 
            this.Dgv_DataRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DataRecursos.Location = new System.Drawing.Point(12, 179);
            this.Dgv_DataRecursos.Name = "Dgv_DataRecursos";
            this.Dgv_DataRecursos.RowHeadersWidth = 51;
            this.Dgv_DataRecursos.Size = new System.Drawing.Size(1390, 439);
            this.Dgv_DataRecursos.TabIndex = 2;
            // 
            // Gpr_FiltroData
            // 
            this.Gpr_FiltroData.Controls.Add(this.Lbl_NumBP);
            this.Gpr_FiltroData.Controls.Add(this.Txt_NumBP);
            this.Gpr_FiltroData.Controls.Add(this.Ckb_DataFim);
            this.Gpr_FiltroData.Controls.Add(this.Ckb_DataInicio);
            this.Gpr_FiltroData.Controls.Add(this.Lbl_NumSerie);
            this.Gpr_FiltroData.Controls.Add(this.Txt_NumSerie);
            this.Gpr_FiltroData.Controls.Add(this.Dtp_Fim);
            this.Gpr_FiltroData.Controls.Add(this.Dtp_Inicio);
            this.Gpr_FiltroData.Controls.Add(this.Lbl_NomeObjeto);
            this.Gpr_FiltroData.Controls.Add(this.Txt_NomeObjeto);
            this.Gpr_FiltroData.Controls.Add(this.Gpb_FiltrosAtivo);
            this.Gpr_FiltroData.Controls.Add(this.Btn_CarregarQwerty);
            this.Gpr_FiltroData.Location = new System.Drawing.Point(12, 27);
            this.Gpr_FiltroData.Name = "Gpr_FiltroData";
            this.Gpr_FiltroData.Size = new System.Drawing.Size(1390, 146);
            this.Gpr_FiltroData.TabIndex = 3;
            this.Gpr_FiltroData.TabStop = false;
            this.Gpr_FiltroData.Text = "Filtros";
            // 
            // Lbl_NumBP
            // 
            this.Lbl_NumBP.AutoSize = true;
            this.Lbl_NumBP.Location = new System.Drawing.Point(687, 22);
            this.Lbl_NumBP.Name = "Lbl_NumBP";
            this.Lbl_NumBP.Size = new System.Drawing.Size(61, 13);
            this.Lbl_NumBP.TabIndex = 14;
            this.Lbl_NumBP.Text = "Número BP";
            // 
            // Txt_NumBP
            // 
            this.Txt_NumBP.Location = new System.Drawing.Point(690, 38);
            this.Txt_NumBP.Name = "Txt_NumBP";
            this.Txt_NumBP.Size = new System.Drawing.Size(101, 20);
            this.Txt_NumBP.TabIndex = 13;
            // 
            // Ckb_DataFim
            // 
            this.Ckb_DataFim.AutoSize = true;
            this.Ckb_DataFim.Location = new System.Drawing.Point(919, 71);
            this.Ckb_DataFim.Name = "Ckb_DataFim";
            this.Ckb_DataFim.Size = new System.Drawing.Size(68, 17);
            this.Ckb_DataFim.TabIndex = 12;
            this.Ckb_DataFim.Text = "Data Fim";
            this.Ckb_DataFim.UseVisualStyleBackColor = true;
            // 
            // Ckb_DataInicio
            // 
            this.Ckb_DataInicio.AutoSize = true;
            this.Ckb_DataInicio.Location = new System.Drawing.Point(919, 22);
            this.Ckb_DataInicio.Name = "Ckb_DataInicio";
            this.Ckb_DataInicio.Size = new System.Drawing.Size(79, 17);
            this.Ckb_DataInicio.TabIndex = 11;
            this.Ckb_DataInicio.Text = "Data Início";
            this.Ckb_DataInicio.UseVisualStyleBackColor = true;
            // 
            // Lbl_NumSerie
            // 
            this.Lbl_NumSerie.AutoSize = true;
            this.Lbl_NumSerie.Location = new System.Drawing.Point(431, 72);
            this.Lbl_NumSerie.Name = "Lbl_NumSerie";
            this.Lbl_NumSerie.Size = new System.Drawing.Size(86, 13);
            this.Lbl_NumSerie.TabIndex = 10;
            this.Lbl_NumSerie.Text = "Número de Série";
            // 
            // Txt_NumSerie
            // 
            this.Txt_NumSerie.Location = new System.Drawing.Point(434, 88);
            this.Txt_NumSerie.Name = "Txt_NumSerie";
            this.Txt_NumSerie.Size = new System.Drawing.Size(203, 20);
            this.Txt_NumSerie.TabIndex = 9;
            // 
            // Dtp_Fim
            // 
            this.Dtp_Fim.CustomFormat = "dd/M/aaaa";
            this.Dtp_Fim.Location = new System.Drawing.Point(919, 91);
            this.Dtp_Fim.Name = "Dtp_Fim";
            this.Dtp_Fim.Size = new System.Drawing.Size(227, 20);
            this.Dtp_Fim.TabIndex = 7;
            this.Dtp_Fim.Enabled = false;
            // 
            // Dtp_Inicio
            // 
            this.Dtp_Inicio.CustomFormat = "dd/M/aaaa";
            this.Dtp_Inicio.Location = new System.Drawing.Point(919, 41);
            this.Dtp_Inicio.Name = "Dtp_Inicio";
            this.Dtp_Inicio.Size = new System.Drawing.Size(227, 20);
            this.Dtp_Inicio.TabIndex = 5;
            this.Dtp_Inicio.Enabled = false;
            // 
            // Lbl_NomeObjeto
            // 
            this.Lbl_NomeObjeto.AutoSize = true;
            this.Lbl_NomeObjeto.Location = new System.Drawing.Point(431, 22);
            this.Lbl_NomeObjeto.Name = "Lbl_NomeObjeto";
            this.Lbl_NomeObjeto.Size = new System.Drawing.Size(84, 13);
            this.Lbl_NomeObjeto.TabIndex = 4;
            this.Lbl_NomeObjeto.Text = "Nome do Objeto";
            // 
            // Txt_NomeObjeto
            // 
            this.Txt_NomeObjeto.Location = new System.Drawing.Point(434, 38);
            this.Txt_NomeObjeto.Name = "Txt_NomeObjeto";
            this.Txt_NomeObjeto.Size = new System.Drawing.Size(203, 20);
            this.Txt_NomeObjeto.TabIndex = 2;
            // 
            // Gpb_FiltrosAtivo
            // 
            this.Gpb_FiltrosAtivo.Controls.Add(this.Ckb_NaAtivoAd);
            this.Gpb_FiltrosAtivo.Controls.Add(this.Ckb_AtivoAd);
            this.Gpb_FiltrosAtivo.Controls.Add(this.Ckb_NaoAtivoAd);
            this.Gpb_FiltrosAtivo.Location = new System.Drawing.Point(143, 19);
            this.Gpb_FiltrosAtivo.Name = "Gpb_FiltrosAtivo";
            this.Gpb_FiltrosAtivo.Size = new System.Drawing.Size(238, 78);
            this.Gpb_FiltrosAtivo.TabIndex = 1;
            this.Gpb_FiltrosAtivo.TabStop = false;
            this.Gpb_FiltrosAtivo.Text = "AD";
            // 
            // Ckb_NaAtivoAd
            // 
            this.Ckb_NaAtivoAd.AutoSize = true;
            this.Ckb_NaAtivoAd.Location = new System.Drawing.Point(127, 22);
            this.Ckb_NaAtivoAd.Name = "Ckb_NaAtivoAd";
            this.Ckb_NaAtivoAd.Size = new System.Drawing.Size(91, 17);
            this.Ckb_NaAtivoAd.TabIndex = 2;
            this.Ckb_NaAtivoAd.Text = "Não se aplica";
            this.Ckb_NaAtivoAd.UseVisualStyleBackColor = true;
            // 
            // Ckb_AtivoAd
            // 
            this.Ckb_AtivoAd.AutoSize = true;
            this.Ckb_AtivoAd.Checked = true;
            this.Ckb_AtivoAd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ckb_AtivoAd.Location = new System.Drawing.Point(20, 45);
            this.Ckb_AtivoAd.Name = "Ckb_AtivoAd";
            this.Ckb_AtivoAd.Size = new System.Drawing.Size(83, 17);
            this.Ckb_AtivoAd.TabIndex = 1;
            this.Ckb_AtivoAd.Text = "Ativo no AD";
            this.Ckb_AtivoAd.UseVisualStyleBackColor = true;
            // 
            // Ckb_NaoAtivoAd
            // 
            this.Ckb_NaoAtivoAd.AutoSize = true;
            this.Ckb_NaoAtivoAd.Location = new System.Drawing.Point(20, 22);
            this.Ckb_NaoAtivoAd.Name = "Ckb_NaoAtivoAd";
            this.Ckb_NaoAtivoAd.Size = new System.Drawing.Size(101, 17);
            this.Ckb_NaoAtivoAd.TabIndex = 0;
            this.Ckb_NaoAtivoAd.Text = "Excluído no AD";
            this.Ckb_NaoAtivoAd.UseVisualStyleBackColor = true;
            // 
            // Btn_CarregarQwerty
            // 
            this.Btn_CarregarQwerty.Location = new System.Drawing.Point(35, 38);
            this.Btn_CarregarQwerty.Name = "Btn_CarregarQwerty";
            this.Btn_CarregarQwerty.Size = new System.Drawing.Size(75, 43);
            this.Btn_CarregarQwerty.TabIndex = 0;
            this.Btn_CarregarQwerty.Text = "Carregar";
            this.Btn_CarregarQwerty.UseVisualStyleBackColor = true;
            this.Btn_CarregarQwerty.Click += new System.EventHandler(this.Btn_CarregarQwerty_Click);
            // 
            // Frm_RecursosAtivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 688);
            this.Controls.Add(this.Gpr_FiltroData);
            this.Controls.Add(this.Dgv_DataRecursos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_RecursosAtivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Recursos";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DataRecursos)).EndInit();
            this.Gpr_FiltroData.ResumeLayout(false);
            this.Gpr_FiltroData.PerformLayout();
            this.Gpb_FiltrosAtivo.ResumeLayout(false);
            this.Gpb_FiltrosAtivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar Prd_LoadProcess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Menu;
        private System.Windows.Forms.ToolStripMenuItem Menu_Voltar;
        private System.Windows.Forms.ToolStripMenuItem Menu_Sair;
        private System.Windows.Forms.DataGridView Dgv_DataRecursos;
        private System.Windows.Forms.GroupBox Gpr_FiltroData;
        private System.Windows.Forms.Button Btn_CarregarQwerty;
        private System.Windows.Forms.GroupBox Gpb_FiltrosAtivo;
        private System.Windows.Forms.CheckBox Ckb_NaAtivoAd;
        private System.Windows.Forms.CheckBox Ckb_AtivoAd;
        private System.Windows.Forms.CheckBox Ckb_NaoAtivoAd;
        private System.Windows.Forms.Label Lbl_NomeObjeto;
        private System.Windows.Forms.TextBox Txt_NomeObjeto;
        private System.Windows.Forms.CheckBox Ckb_DataFim;
        private System.Windows.Forms.CheckBox Ckb_DataInicio;
        private System.Windows.Forms.Label Lbl_NumSerie;
        private System.Windows.Forms.TextBox Txt_NumSerie;
        private System.Windows.Forms.DateTimePicker Dtp_Fim;
        private System.Windows.Forms.DateTimePicker Dtp_Inicio;
        private System.Windows.Forms.Label Lbl_NumBP;
        private System.Windows.Forms.TextBox Txt_NumBP;
    }
}