using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIGEST.AppCode;

namespace TIGEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            string nome = txt_Usuario.Text;
            string senha = txt_Senha.Text;
            
            Login login = new Login();
            int count = login.BuscarUsuario(nome, senha);
                

            if (count > 0) // Se encontrou usuário, faz login
            {
                Frm_TelaInicial frm_TelaInicial = new Frm_TelaInicial();
                this.Hide();
                login.FecharConexao();
                frm_TelaInicial.Show();
            }
            else
            {
                MessageBox.Show("Senha ou usuário incorretos, por gentileza verifique suas credenciais e tente novamente!");
            }
        }
    }
}