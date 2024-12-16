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

namespace Projeto01
{
    public partial class Funcionarios : Form
    {
        SqlConnection cn = new SqlConnection("Data Source = OGPC; Initial Catalog = Academia; User Id=sa;Password=39465512");

        string strSQL = "insert into Funcionarios (Nome, Cargo, Salario,DataContratacao,dataTerminoContrato) values (@nome, @cargo, @salario, @datacontratacao, @datafimcontrato)";

        public Funcionarios()
        {
            InitializeComponent();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'academiaDataSet1.Funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.academiaDataSet1.Funcionarios);
            //combo
            cmbCargo.Items.Add("Personal trainner");
            cmbCargo.Items.Add("Estagiário");
            cmbCargo.Items.Add("Recepcionista");
            cmbCargo.Items.Add("Faxineira");


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            TxtNomeFuncionario.Enabled = true;
            txtSalario.Enabled = true;
            cmbCargo.Enabled = true;
            dtpContratacao.Enabled = true;
            dtpFimContrato.Enabled = true;
            HabilitarBotoes();
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            TxtNomeFuncionario.Enabled = true;
            txtSalario.Enabled = true;
            cmbCargo.Enabled = true;
            dtpContratacao.Enabled = true;
            dtpFimContrato.Enabled = true;
        }
        private void HabilitarBotoes()
        {
            button1.Enabled = true;
            btnCancelar.Enabled = true;
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtNomeFuncionario.Text.Length == 0)
            {
                MessageBox.Show("O campo de Nome é obrigatório!");
            }
            else
            {
                try
                {
                    cn.Open();

                    //ver se tem nome igual no banco
                    string checkSQL = "SELECT COUNT(*) FROM Funcionarios WHERE Nome = @nome";
                    SqlCommand checkCmd = new SqlCommand(checkSQL, cn);
                    checkCmd.Parameters.AddWithValue("@nome", this.TxtNomeFuncionario.Text);

                    // Executa a consulta e obtém o resultado.
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // já cadastrado
                        MessageBox.Show("Funcionário já cadastrado", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {


                        // Func não cadastrado, prosseguir com a inserção
                        string insertSQL = "INSERT INTO Funcionarios (Nome, Cargo, Salario,DataContratacao,dataTerminoContrato) VALUES (@nome, @cargo, @salario, @datacontratacao, @datafimcontrato)";
                        SqlCommand insertCmd = new SqlCommand(insertSQL, cn);


                        // Adicionando os parâmetros com os valores dos campos de texto
                        insertCmd.Parameters.AddWithValue("@nome", this.TxtNomeFuncionario.Text);
                        string cargo = cmbCargo.SelectedItem.ToString();
                        insertCmd.Parameters.AddWithValue("@cargo", cargo);
                        insertCmd.Parameters.AddWithValue("@salario", this.txtSalario.Text);
                        insertCmd.Parameters.AddWithValue("@datacontratacao", this.dtpContratacao.Value);
                        insertCmd.Parameters.AddWithValue("@datafimcontrato", this.dtpFimContrato.Value);




                        // Executando o comando de inserção
                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Funcionário Cadastrado com êxito");

                        // Limpando os campos e desabilitando após o sucesso da inserção
                        LimparCampos();
                        DesabilitarCampos();
                        DesabilitarBotoes();
                        txtNomePesquisar.Enabled = true;
                    }

                    // Fechar a conexão
                    cn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro de SQL: " + ex.Message);
                    Console.WriteLine("Stack Trace: " + ex.StackTrace);
                    MessageBox.Show(ex.Message);
                    if (cn.State == ConnectionState.Open)
                    {
                        cn.Close();
                    }
                }
            }
        }
        private void BuscarPorNome()
        {

            cn.Open();
            string selectSQL = "SELECT Nome, Cargo, Salario,DataContratacao,dataTerminoContrato FROM Funcionario WHERE Nome = @nome";
            SqlCommand selectCmd = new SqlCommand(selectSQL, cn);

            // Adicionando o parâmetro com o nome para a busca
            selectCmd.Parameters.AddWithValue("@nome", this.txtNomePesquisar.Text);

            // Executando o comando de seleção
            SqlDataReader reader = selectCmd.ExecuteReader();

            if (reader.Read())
            {
                // Preenchendo os campos com as informações encontradas
                this.TxtNomeFuncionario.Text = reader["Nome"].ToString();
                this.txtSalario.Text = reader["Salario"].ToString();
                this.cmbCargo.SelectedItem = reader["Cargo"].ToString();
                this.dtpContratacao.Value = (DateTime)reader["DataContratacao"];
                this.dtpFimContrato.Value = (DateTime)reader["dataTerminoContrato"];

                MessageBox.Show("Dados encontrados e preenchidos com êxito");

                HabilitarBotoes();
                btnNovo.Enabled = false;
                button1.Enabled = false;
                HabilitarCampos();
            }
            else
            {
                MessageBox.Show("Cliente não encontrado");
            }

            reader.Close();
            cn.Close();


        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarDados();
        }

        private void AtualizarDados()
        {
            try
            {
                // Verificando se todos os campos estão preenchidos
                if (string.IsNullOrWhiteSpace(this.TxtNomeFuncionario.Text) ||
                    string.IsNullOrWhiteSpace(this.txtSalario.Text))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.");
                    return;
                }

                string updateSQL = "UPDATE Funcionario SET Nome = @nome, Cargo = @cargo, Salario = @salario, DataContratacao = @datacontratacao, dataTerminoContrato = @datafimcontrato";
                SqlCommand updateCmd = new SqlCommand(updateSQL, cn);


                string cargo = cmbCargo.SelectedItem.ToString();

                DateTime dataContratacao = this.dtpContratacao.Value;
                DateTime? dataFim = this.dtpFimContrato.Value;

                // Adicionando os parâmetros com os valores dos campos de texto
                updateCmd.Parameters.AddWithValue("@nome", this.TxtNomeFuncionario.Text.Trim());
                updateCmd.Parameters.AddWithValue("@cargo", cargo);
                updateCmd.Parameters.AddWithValue("@salario", this.txtSalario.Text.Trim());
                updateCmd.Parameters.AddWithValue("@datacontratacao", dataContratacao);
                updateCmd.Parameters.AddWithValue("@datafimcontrato", dataFim);





                // Executando o comando de atualização
                int rowsAffected = updateCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Dados atualizados com êxito");

                    LimparCampos();
                    DesabilitarCampos();
                    DesabilitarBotoes();
                    btnNovo.Enabled = true;
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

        private void DesabilitarBotoes()
        {
            button1.Enabled = false;
            btnCancelar.Enabled = false;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void DesabilitarCampos()
        {
            TxtNomeFuncionario.Enabled = false;
            txtSalario.Enabled = false;
            cmbCargo.Enabled = false;
            dtpContratacao.Enabled = false;
            dtpFimContrato.Enabled = false;
        }

        private void LimparCampos()
        {
            TxtNomeFuncionario.Clear();
            txtSalario.Clear();
            cmbCargo.SelectedIndex = -1;
            dtpContratacao.Checked = false;
            dtpFimContrato.Checked = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarCampos();
            DesabilitarBotoes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscarPorNome();
            HabilitarBotoes();
            btnNovo.Enabled = false;
            btnAtualizar.Enabled = false;
            HabilitarCampos();
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                decimal total = 0;
                decimal gasto = 0;
                cn.Open();
                string selectSQL = "SELECT Nome, Salario FROM Funcionarios";
                SqlCommand selectCmd = new SqlCommand(selectSQL, cn);

                string sqlGasto = "SELECT SUM(Salario) FROM Funcionarios";
                using (SqlCommand cmdtotal = new SqlCommand(sqlGasto, cn))
                {
                    object result = cmdtotal.ExecuteScalar();
                    gasto = (result != DBNull.Value) ? Convert.ToDecimal(result) : 0;
                }
                string sqlTotal = "SELECT COUNT(*) FROM Funcionarios";
                using (SqlCommand cmdpago = new SqlCommand(sqlTotal, cn))
                {
                    object resultT = cmdpago.ExecuteScalar();
                    total = (resultT != DBNull.Value) ? Convert.ToDecimal(resultT) : 0;
                }

                this.txtTotal.Text = total.ToString();
                this.txtGasto.Text = gasto.ToString();
                cn.Close();
            }
            catch
            {
                cn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPrincipal fm = new FrmPrincipal();
            fm.Show();
            this.Hide();
        }
    }
}
