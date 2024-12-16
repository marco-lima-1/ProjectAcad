using Stripe;
using Stripe.BillingPortal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Stripe.Checkout;
using SessionCreateOptions = Stripe.Checkout.SessionCreateOptions;
using SessionService = Stripe.Checkout.SessionService;
using Session = Stripe.Checkout.Session;

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

        string strSQL = "insert into Cliente (Nome, Cpf, Telefone,StatusMensalidade,DataPagamento) values (@nome, @cpf, @telefone, @StatusMensalidade, @DataPagamento)";




        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        }
        public void btnNovo_Click(object sender, EventArgs e)
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
                        string insertSQL = "INSERT INTO Cliente (Nome, Cpf, Telefone,StatusMensalidade,DataPagamento) VALUES (@nome, @cpf, @telefone, @StatusMensalidade, @DataPagamento)";
                        SqlCommand insertCmd = new SqlCommand(insertSQL, cn);


                        // Adicionando os parâmetros com os valores dos campos de texto
                        insertCmd.Parameters.AddWithValue("@nome", this.txtNome.Text);
                        insertCmd.Parameters.AddWithValue("@cpf", this.txtCPF.Text);
                        insertCmd.Parameters.AddWithValue("@telefone", this.txtTel.Text);
                        string status = cmbStatus.SelectedItem.ToString();
                        DateTime? dataPagamento = null;
                        if (status == "Pago")
                        {
                            dataPagamento = dtpDataPagamento.Value;
                        }
                        if (status == "Atrasado")
                        {
                            dataPagamento = dtpDataPagamento.Value;
                        }


                        insertCmd.Parameters.AddWithValue("@StatusMensalidade", status);
                        insertCmd.Parameters.AddWithValue("@DataPagamento", dataPagamento);



                        // Executando o comando de inserção
                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastro concluído com êxito");

                        // Limpando os campos e desabilitando após o sucesso da inserção
                        LimparCampos();
                        DesabilitarCampos();
                        DesabilitarBotoes();
                        btnNovo.Enabled = true;
                        btnPesquisar.Enabled = true;
                        btnPesquisar.Enabled = true;
                        txtNomePesquisar.Enabled = true;
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
            cmbStatus.SelectedIndex = -1;
        }
        //metodo desabilita textos
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtTel.Enabled = false;
            cmbStatus.Enabled = false;
        }
        //metodo habilita textos
        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtTel.Enabled = true;
            cmbStatus.Enabled = true;
            dtpDataPagamento.Enabled = true;
            cmbStatus.Enabled = true;
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

                string updateSQL = "UPDATE Cliente SET Nome = @nome, Telefone = @telefone, Cpf = @cpf, @StatusMensalidade = StatusMensalidade, @DataPagamento = DataPagamento";
                SqlCommand updateCmd = new SqlCommand(updateSQL, cn);


                string status = cmbStatus.SelectedItem.ToString();
                DateTime? dataPagamento = null;
                if (status == "Pago")
                {
                    dataPagamento = dtpDataPagamento.Value;
                }
                // Adicionando os parâmetros com os valores dos campos de texto
                updateCmd.Parameters.AddWithValue("@nome", this.txtNome.Text.Trim());
                updateCmd.Parameters.AddWithValue("@cpf", this.txtCPF.Text.Trim());
                updateCmd.Parameters.AddWithValue("@telefone", this.txtTel.Text.Trim());
                updateCmd.Parameters.AddWithValue("@StatusMensalidade", status);
                updateCmd.Parameters.AddWithValue("@DataPagamento", dataPagamento);





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
            string selectSQL = "SELECT Nome, Cpf, Telefone, StatusMensalidade, DataPagamento FROM Cliente WHERE Nome = @nome";
            SqlCommand selectCmd = new SqlCommand(selectSQL, cn);

            // Adicionando o parâmetro com o nome para a busca
            selectCmd.Parameters.AddWithValue("@nome", this.txtNomePesquisar.Text);

            // Executando o comando de seleção
            SqlDataReader reader = selectCmd.ExecuteReader();

            if (reader.Read())
            {
                // Preenchendo os campos com as informações encontradas
                this.txtNome.Text = reader["Nome"].ToString();
                this.txtNomePag.Text = reader["Nome"].ToString();
                this.txtCPF.Text = reader["Cpf"].ToString();
                this.txtTel.Text = reader["Telefone"].ToString();
                this.cmbStatus.SelectedItem = reader["StatusMensalidade"].ToString();
                this.dtpDataPagamento.Value = (DateTime)reader["DataPagamento"];

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
                if (sidebar.Width == sidebar.MaximumSize.Width)
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

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            Funcionarios fm = new Funcionarios();
            fm.Show();
            this.Hide();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPrincipal_Load_1(object sender, EventArgs e)
        {
            this.clienteTableAdapter3.Fill(this.academiaDataSet8.Cliente);

            //combo
            cmbTipoCard.Items.Add("Visa");
            cmbTipoCard.Items.Add("MasterCard");
            cmbTipoCard.Items.Add("American Express");
            cmbTipoCard.Items.Add("Elo");
            cmbTipoCard.Items.Add("Hipercard");

            //combo card
            for (int i = 1; i <= 12; i++)
            {
                cmbMes.Items.Add(i.ToString("00"));
            }

            int anoatual = DateTime.Now.Year;
            for (int i = 0; i < 12; i++)
            {
                cmbAno.Items.Add((anoatual + i).ToString());
            }





        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            Home fm = new Home();
            fm.Show();
            this.Hide();
        }

        private void lblCvv_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoCard_Click(object sender, EventArgs e)
        {
            HabilitarCamposCard();
            txtNumeroCard.Focus();
            HabilitarBotoesCard();
        }

        private void HabilitarBotoesCard()
        {
            btnCancelCard.Enabled = true;
            btnPagar.Enabled = true;
        }

        private void HabilitarCamposCard()
        {
            txtNumeroCard.Enabled = true;
            txtNomeCard.Enabled = true;
            cmbTipoCard.Enabled = true;
            cmbMes.Enabled = true;
            cmbAno.Enabled = true;
            txtCVV.Enabled = true;
            txtValorPagamento.Enabled = true;
            btnPagar.Enabled = true;
        }

        private void btnCancelCard_Click(object sender, EventArgs e)
        {
            txtNumeroCard.Enabled = false;
            txtNomeCard.Enabled = false;
            cmbTipoCard.Enabled = false;
            cmbMes.Enabled = false;
            cmbAno.Enabled = false;
            txtCVV.Enabled = false;
            txtValorPagamento.Enabled = false;
            btnPagar.Enabled = false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios estão preenchidos
            if (
                string.IsNullOrEmpty(txtNumeroCard.Text) ||
                string.IsNullOrEmpty(txtNomeCard.Text) ||
                string.IsNullOrEmpty(cmbMes.Text) ||
                string.IsNullOrEmpty(cmbAno.Text) ||
                string.IsNullOrEmpty(txtCVV.Text) ||
                string.IsNullOrEmpty(txtValorPagamento.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Tenta converter o valor para decimal
            if (!decimal.TryParse(txtValorPagamento.Text, out decimal valorPagamento))
            {
                MessageBox.Show("Insira um valor válido.");
                return;
            }

            // Obtém os dados do cartão e do pagamento
            string numeroCARD = txtNumeroCard.Text;
            string nomeCard = txtNomeCard.Text;
            string mes = cmbMes.Text;
            string ano = cmbAno.Text;
            string cvv = txtCVV.Text;

            // Chave secreta do Stripe
            Stripe.StripeConfiguration.ApiKey = StripeSecret.StripeSecretKey;

            // Chama o método para criar a sessão de pagamento no Stripe
            string sessionId = RealizarPagamento(valorPagamento);

            if (!string.IsNullOrEmpty(sessionId))
            {
                // URL base para redirecionar ao checkout do Stripe
                string checkoutUrl = $"https://checkout.stripe.com/pay/{sessionId}";

                // Abre o link no navegador padrão do sistema para realizar o pagamento
                System.Diagnostics.Process.Start(checkoutUrl);
            }
            else
            {
                MessageBox.Show("Erro ao criar a sessão de pagamento. Tente novamente.");
            }
        }


        private string RealizarPagamento(decimal valor)
        {
            try
            {
                // Configura a chave secreta do Stripe
                StripeConfiguration.ApiKey = StripeSecret.StripeSecretKey;

                // Cria as opções da sessão de checkout
                var options = new SessionCreateOptions
                {
                    PaymentMethodTypes = new List<string>
            {
                "card"
            },
                    LineItems = new List<SessionLineItemOptions>
            {
                new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        Currency = "brl",
                        UnitAmount = (long)(valor * 100), // Convertendo para centavos
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = "Pagamento de Mensalidade"
                        }
                    },
                    Quantity = 1
                }
            },
                    Mode = "payment",
                    SuccessUrl = "https://marco-lima-1.github.io/checkout_acad/sucesso.html",
                    CancelUrl = "https://marco-lima-1.github.io/checkout_acad/cancelado.html"
                };

                var service = new SessionService();
                Session session = service.Create(options);

                // Retorna o sessionId para redirecionar para a página de pagamento
                return session.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar o pagamento: " + ex.Message);
                return null;
            }
        }


        private void AtualizarStatusCliente()
        {
            string updateSQL = "UPDATE Cliente SET @StatusMensalidade = StatusMensalidade, @DataPagamento = DataPagamento WHERE Nome = @nome";
            SqlCommand updateCmd = new SqlCommand(updateSQL, cn);


            string status = cmbStatus.SelectedItem.ToString();
            DateTime? dataPagamento = null;
            if (status == "Pago")
            {
                dataPagamento = dtpDataPagamento.Value;
            }

            updateCmd.Parameters.AddWithValue("@StatusMensalidade", status);
        }

    }
}
