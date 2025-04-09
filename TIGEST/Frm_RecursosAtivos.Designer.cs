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
            this.Btn_CarregarQwerty = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DataRecursos)).BeginInit();
            this.Gpr_FiltroData.SuspendLayout();
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
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(99, 19);
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
            this.Dgv_DataRecursos.Location = new System.Drawing.Point(12, 142);
            this.Dgv_DataRecursos.Name = "Dgv_DataRecursos";
            this.Dgv_DataRecursos.RowHeadersWidth = 51;
            this.Dgv_DataRecursos.Size = new System.Drawing.Size(1390, 439);
            this.Dgv_DataRecursos.TabIndex = 2;
            // 
            // Gpr_FiltroData
            // 
            this.Gpr_FiltroData.Controls.Add(this.Btn_CarregarQwerty);
            this.Gpr_FiltroData.Location = new System.Drawing.Point(12, 27);
            this.Gpr_FiltroData.Name = "Gpr_FiltroData";
            this.Gpr_FiltroData.Size = new System.Drawing.Size(1390, 106);
            this.Gpr_FiltroData.TabIndex = 3;
            this.Gpr_FiltroData.TabStop = false;
            this.Gpr_FiltroData.Text = "Filtros";
            // 
            // Btn_CarregarQwerty
            // 
            this.Btn_CarregarQwerty.Location = new System.Drawing.Point(19, 28);
            this.Btn_CarregarQwerty.Name = "Btn_CarregarQwerty";
            this.Btn_CarregarQwerty.Size = new System.Drawing.Size(75, 23);
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
    }
}