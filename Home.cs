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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        //conexao com banco de dados
        SqlConnection cn = new SqlConnection("Data Source = OGPC; Initial Catalog = Academia; User Id=sa;Password=39465512");

        string strSQL = "insert into Cliente (Nome, Cpf, Telefone,StatusMensalidade,DataPagamento) values (@nome, @cpf, @telefone, @StatusMensalidade, @DataPagamento)";

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'academiaDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.academiaDataSet.Cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            int pago = 0;
            int atrasado = 0;

            cn.Open();
            string selectSQL = "SELECT Nome, Cpf, Telefone, StatusMensalidade, DataPagamento FROM Cliente WHERE Nome = @nome";
            SqlCommand selectCmd = new SqlCommand(selectSQL, cn);

            string sqlTotal = "SELECT COUNT(*) FROM Cliente";
            using (SqlCommand cmdtotal = new SqlCommand(sqlTotal, cn))
            {
                total = (int)cmdtotal.ExecuteScalar();
            }
            string sqlPago = "SELECT COUNT(*) FROM Cliente WHERE StatusMensalidade = 'Pago'";
            using (SqlCommand cmdpago = new SqlCommand(sqlPago, cn))
            {
                pago = (int)cmdpago.ExecuteScalar();
            }
            string sqlAtrasado = "SELECT COUNT(*) FROM Cliente WHERE StatusMensalidade = 'Atrasado'";
            using (SqlCommand cmdatrasado = new SqlCommand(sqlAtrasado, cn))
            {
                atrasado = (int)cmdatrasado.ExecuteScalar();
            }

            this.txtTotal.Text = total.ToString();
            this.txtPagos.Text = pago.ToString();
            this.txtAtrasados.Text = atrasado.ToString();
        }

        private void GerarGrafico()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPrincipal fm = new FrmPrincipal();
            fm.Show();
            this.Hide();
        }
    }
}
