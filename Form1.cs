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
            btnExcluir.Enabled = false;
            btnAtualizar.Enabled = false;
            btnNovo.Enabled = false;
            txtNomePesquisar.Enabled = false;
            btnPesquisar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length == 0 || txtCPF.Text.Length == 0)
            {
                MessageBox.Show("Os campos Nome e CPF são obrigatórios !");
            }
            else
            {
                try
                {
                    cn.Open();

                    // Verificação para ver se existe CPF igual ao inserido
                    string checkCpfSQL = "SELECT COUNT(*) FROM Cliente WHERE Cpf = @cpf";
                    SqlCommand checkCmd = new SqlCommand(checkCpfSQL, cn);
                    checkCmd.Parameters.AddWithValue("@cpf", this.txtCPF.Text);

                    // Executa a consulta e obtém o resultado.
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
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                // Verificação para ver se existe um cliente com o nome inserido
                string searchByNameSQL = "SELECT * FROM Cliente WHERE Nome = @nome";
                SqlCommand searchCmd = new SqlCommand(searchByNameSQL, cn);
                searchCmd.Parameters.AddWithValue("@nome", this.txtNomePesquisar.Text);

                SqlDataReader dt = searchCmd.ExecuteReader();
                if (!dt.HasRows)
                {
                    // Nome não cadastrado
                    MessageBox.Show("Nome não cadastrado!", "Erro no Nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dt.Read();
                    txtNome.Text = dt["Nome"].ToString();
                    txtCPF.Text = dt["Cpf"].ToString();
                    txtTel.Text = dt["Telefone"].ToString();
                    HabilitarCampos();
                    btnExcluir.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnAtualizar.Enabled = true;
                    btnNovo.Enabled = false;

                    txtNomePesquisar.Clear();
                }
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarDados();
        }




        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirDados();
            LimparCampos();
            DesabilitarCampos();
            DesabilitarBotoes();

            btnNovo.Enabled = true;
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {

            btnNovo.Enabled = true;
            LimparCampos();
            DesabilitarCampos();
            btnPesquisar.Enabled = true;
            txtNomePesquisar.Enabled = true;
        }
        private void btnPesquisaNome_Click(object sender, EventArgs e)
        {
            BuscarPorNome();

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
            btnPesquisar.Enabled = true;
            btnAtualizar.Enabled = true;
        }
        //metodo limpa textos
        private void LimparCampos()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtTel.Clear();
            txtNomePesquisar.Clear();
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

        private void AtualizarDados()
        {
            try
            {
                // Verificando se todos os campos estão preenchidos
                if (string.IsNullOrWhiteSpace(this.txtNome.Text) ||
                    string.IsNullOrWhiteSpace(this.txtCPF.Text) ||
                    string.IsNullOrWhiteSpace(this.txtTel.Text))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.");
                    return;
                }

                cn.Open();
                string updateSQL = "UPDATE Cliente SET Nome = @nome, Telefone = @telefone, Cpf = @cpf";
                SqlCommand updateCmd = new SqlCommand(updateSQL, cn);

                // Adicionando os parâmetros com os valores dos campos de texto
                updateCmd.Parameters.AddWithValue("@nome", this.txtNome.Text.Trim());
                updateCmd.Parameters.AddWithValue("@cpf", this.txtCPF.Text.Trim());
                updateCmd.Parameters.AddWithValue("@telefone", this.txtTel.Text.Trim());

                // Executando o comando de atualização
                int rowsAffected = updateCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Dados atualizados com êxito");

                    // Limpando os campos e desabilitando após o sucesso da inserção
                    LimparCampos();
                    DesabilitarCampos();
                    DesabilitarBotoes();
                    btnNovo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Nenhum cliente encontrado com o CPF informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os dados: " + ex.Message);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }


        }

        private void ExcluirDados()
        {
            cn.Open();
            string deleteSQL = "DELETE FROM Cliente WHERE Cpf = @cpf";
            SqlCommand deleteCmd = new SqlCommand(deleteSQL, cn);

            // Adicionando o parâmetro com o CPF do cliente a ser excluído
            deleteCmd.Parameters.AddWithValue("@cpf", this.txtCPF.Text);

            // Executando o comando de exclusão
            deleteCmd.ExecuteNonQuery();
            MessageBox.Show("Cliente excluído com êxito");

            // Limpando os campos e desabilitando após o sucesso da exclusão
            LimparCampos();
            DesabilitarCampos();
            DesabilitarBotoes();
            btnNovo.Enabled = true;

            cn.Close();

        }

        private void BuscarPorNome()
        {
            cn.Open();
            string selectSQL = "SELECT Nome, Cpf, Telefone FROM Cliente WHERE Nome = @nome";
            SqlCommand selectCmd = new SqlCommand(selectSQL, cn);

            // Adicionando o parâmetro com o nome para a busca
            selectCmd.Parameters.AddWithValue("@nome", this.txtNomePesquisar.Text);

            // Executando o comando de seleção
            SqlDataReader reader = selectCmd.ExecuteReader();

            if (reader.Read())
            {
                // Preenchendo os campos com as informações encontradas
                this.txtNome.Text = reader["Nome"].ToString();
                this.txtCPF.Text = reader["Cpf"].ToString();
                this.txtTel.Text = reader["Telefone"].ToString();

                MessageBox.Show("Dados encontrados e preenchidos com êxito");

                HabilitarBotoes();
                btnNovo.Enabled = false;
                btnSalvar.Enabled = false;
                HabilitarCampos();
            }
            else
            {
                MessageBox.Show("Cliente não encontrado");
            }

            reader.Close();
            cn.Close();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand;

        private void sidebarTime_Tick(object sender, EventArgs e)
        {




            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTime.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTime.Stop();
                }
                
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
        }
    }
}
