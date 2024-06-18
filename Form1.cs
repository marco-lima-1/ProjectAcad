using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto01
{
    public partial class FrmPrincipal : Form
    {

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //conexao com banco de dados
        SqlConnection cn = new SqlConnection("Data Source = OGPC; Initial Catalog = Academia; User Id=sa;Password=39465512");

        string strSQL = "insert into Cliente (Nome, Cpf, Telefone) values (@nome, @cpf, @telefone)";




        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            txtNome.Focus();
            HabilitarBotoes();
            btnNovo.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                // Verificação para ver se existe CPF igual ao inserido
                string checkCpfSQL = "SELECT COUNT(*) FROM Cliente WHERE Cpf = @cpf";
                SqlCommand checkCmd = new SqlCommand(checkCpfSQL, cn);
                checkCmd.Parameters.AddWithValue("@cpf", this.txtCPF.Text);

                // Executa a consulta e obtém o resultado
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    // CPF já cadastrado
                    MessageBox.Show("CPF já cadastrado", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // CPF não cadastrado, prosseguir com a inserção
                    string insertSQL = "INSERT INTO Cliente (Nome, Cpf, Telefone) VALUES (@nome, @cpf, @telefone)";
                    SqlCommand insertCmd = new SqlCommand(insertSQL, cn);

                    // Adicionando os parâmetros com os valores dos campos de texto
                    insertCmd.Parameters.AddWithValue("@nome", this.txtNome.Text);
                    insertCmd.Parameters.AddWithValue("@cpf", this.txtCPF.Text);
                    insertCmd.Parameters.AddWithValue("@telefone", this.txtTel.Text);

                    // Executando o comando de inserção
                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro concluído com êxito");

                    // Limpando os campos e desabilitando após o sucesso da inserção
                    LimparCampos();
                    DesabilitarCampos();
                    DesabilitarBotoes();
                    btnNovo.Enabled = true;
                }

                // Fechar a conexão
                cn.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarCampos();
            DesabilitarBotoes();
            btnNovo.Enabled = true;
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarBotoes();
            btnNovo.Enabled = true;
            LimparCampos();
            DesabilitarCampos();
        }

        //metodo desabilita botoes
        private void DesabilitarBotoes()
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        //metodo habilita botoes
        private void HabilitarBotoes()
        {
            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = true;
        }
        //metodo limpa textos
        private void LimparCampos()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtTel.Clear();
        }
        //metodo desabilita textos
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtTel.Enabled = false;
        }
        //metodo habilita textos
        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtTel.Enabled = true;
        }







    }
}
