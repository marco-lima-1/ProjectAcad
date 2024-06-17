using System;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Remoting.Contexts;

namespace Projeto01
{
    public partial class FrmPrincipal : Form
    {

        public FrmPrincipal()
        {
            InitializeComponent();
        }
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
            LimparCampos();
            DesabilitarCampos();
            DesabilitarBotoes();
            btnNovo.Enabled = true;

            //criamos a string de conexao
            SqlConnection conn = new SqlConnection("Data Source = OGPC; Initial Catalog = aula; User Id=sa;Password=39465512");

            //cria string de inserção sql
            string sql = "INSERT INTO Cliente(id, nome, cpf, tel) VALUES (@id, @nome, @cpf, @tel)";
            Random numeroID = new Random();
            numeroID.Next();



            try
            {
                //cria um objeto do tipo comando passando como parametro a string sql e conn
                SqlCommand c = new SqlCommand(sql, conn);

                //insere os dados da texBox no comando sql
                c.Parameters.Add(new SqlParameter("@id", numeroID.Next()));
                c.Parameters.Add(new SqlParameter("@nome", this.txtNome.Text));
                c.Parameters.Add(new SqlParameter("@cpf", this.txtCPF.Text));
                c.Parameters.Add(new SqlParameter("@tel", this.txtTel.Text));

                //abrimos a conexao com banco de dados
                conn.Open();

                //executa o comando sql no banco de dados
                c.BeginExecuteNonQuery();

                //Fechamos a conexao
                conn.Close();

                //aviso que deu certo
                MessageBox.Show("Cadastro concluído com êxito");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally
            {
                conn.Close();
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
