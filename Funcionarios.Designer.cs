namespace Projeto01
{
    partial class Funcionarios
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
            this.components = new System.ComponentModel.Container();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.dtpContratacao = new System.Windows.Forms.DateTimePicker();
            this.dtpFimContrato = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataContratacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTerminoContratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academiaDataSet1 = new Projeto01.AcademiaDataSet1();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblPagEmDia = new System.Windows.Forms.Label();
            this.lblFuncionarios = new System.Windows.Forms.Label();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.txtNomePesquisar = new System.Windows.Forms.TextBox();
            this.lblNomePesquisar = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.funcionariosTableAdapter = new Projeto01.AcademiaDataSet1TableAdapters.FuncionariosTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(120, 179);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(111, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Funcionário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Contratação:";
            // 
            // TxtNomeFuncionario
            // 
            this.TxtNomeFuncionario.Enabled = false;
            this.TxtNomeFuncionario.Location = new System.Drawing.Point(251, 179);
            this.TxtNomeFuncionario.Name = "TxtNomeFuncionario";
            this.TxtNomeFuncionario.Size = new System.Drawing.Size(100, 20);
            this.TxtNomeFuncionario.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Enabled = false;
            this.txtSalario.Location = new System.Drawing.Point(251, 240);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 5;
            // 
            // cmbCargo
            // 
            this.cmbCargo.Enabled = false;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(251, 209);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(130, 21);
            this.cmbCargo.TabIndex = 6;
            // 
            // dtpContratacao
            // 
            this.dtpContratacao.Enabled = false;
            this.dtpContratacao.Location = new System.Drawing.Point(251, 271);
            this.dtpContratacao.Name = "dtpContratacao";
            this.dtpContratacao.Size = new System.Drawing.Size(200, 20);
            this.dtpContratacao.TabIndex = 7;
            // 
            // dtpFimContrato
            // 
            this.dtpFimContrato.Enabled = false;
            this.dtpFimContrato.Location = new System.Drawing.Point(251, 303);
            this.dtpFimContrato.Name = "dtpFimContrato";
            this.dtpFimContrato.Size = new System.Drawing.Size(200, 20);
            this.dtpFimContrato.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fim do contrato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(51, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "AREA DE FUNCIONÁRIOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(119, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cadastro de Funcionário";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(291, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.dataContratacaoDataGridViewTextBoxColumn,
            this.dataTerminoContratoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.funcionariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(571, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(639, 612);
            this.dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            this.salarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataContratacaoDataGridViewTextBoxColumn
            // 
            this.dataContratacaoDataGridViewTextBoxColumn.DataPropertyName = "DataContratacao";
            this.dataContratacaoDataGridViewTextBoxColumn.HeaderText = "DataContratacao";
            this.dataContratacaoDataGridViewTextBoxColumn.Name = "dataContratacaoDataGridViewTextBoxColumn";
            this.dataContratacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataTerminoContratoDataGridViewTextBoxColumn
            // 
            this.dataTerminoContratoDataGridViewTextBoxColumn.DataPropertyName = "dataTerminoContrato";
            this.dataTerminoContratoDataGridViewTextBoxColumn.HeaderText = "dataTerminoContrato";
            this.dataTerminoContratoDataGridViewTextBoxColumn.Name = "dataTerminoContratoDataGridViewTextBoxColumn";
            this.dataTerminoContratoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.academiaDataSet1;
            // 
            // academiaDataSet1
            // 
            this.academiaDataSet1.DataSetName = "AcademiaDataSet1";
            this.academiaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtGasto
            // 
            this.txtGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtGasto.Location = new System.Drawing.Point(1504, 154);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(100, 30);
            this.txtGasto.TabIndex = 35;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1504, 106);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 30);
            this.txtTotal.TabIndex = 34;
            // 
            // lblPagEmDia
            // 
            this.lblPagEmDia.AutoSize = true;
            this.lblPagEmDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagEmDia.Location = new System.Drawing.Point(1249, 154);
            this.lblPagEmDia.Name = "lblPagEmDia";
            this.lblPagEmDia.Size = new System.Drawing.Size(225, 25);
            this.lblPagEmDia.TabIndex = 32;
            this.lblPagEmDia.Text = "Gasto total com salários:";
            // 
            // lblFuncionarios
            // 
            this.lblFuncionarios.AutoSize = true;
            this.lblFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionarios.Location = new System.Drawing.Point(1268, 106);
            this.lblFuncionarios.Name = "lblFuncionarios";
            this.lblFuncionarios.Size = new System.Drawing.Size(206, 25);
            this.lblFuncionarios.TabIndex = 31;
            this.lblFuncionarios.Text = "Total de Funcionarios:";
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.Location = new System.Drawing.Point(1425, 212);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(179, 38);
            this.btnGerarRelatorio.TabIndex = 30;
            this.btnGerarRelatorio.Text = "Gerar relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // txtNomePesquisar
            // 
            this.txtNomePesquisar.Location = new System.Drawing.Point(209, 459);
            this.txtNomePesquisar.Name = "txtNomePesquisar";
            this.txtNomePesquisar.Size = new System.Drawing.Size(322, 20);
            this.txtNomePesquisar.TabIndex = 40;
            // 
            // lblNomePesquisar
            // 
            this.lblNomePesquisar.AutoSize = true;
            this.lblNomePesquisar.Location = new System.Drawing.Point(102, 462);
            this.lblNomePesquisar.Name = "lblNomePesquisar";
            this.lblNomePesquisar.Size = new System.Drawing.Size(84, 13);
            this.lblNomePesquisar.TabIndex = 39;
            this.lblNomePesquisar.Text = "Nome completo:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(210, 494);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 38;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(291, 494);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(97, 23);
            this.btnAtualizar.TabIndex = 36;
            this.btnAtualizar.Text = "Atualizar dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(119, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Buscar Funcionário";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(372, 346);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(394, 494);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(210, 346);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 42;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1415, 615);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 77);
            this.button2.TabIndex = 45;
            this.button2.Text = "Voltar para a página inicial";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1646, 768);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomePesquisar);
            this.Controls.Add(this.lblNomePesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtGasto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblPagEmDia);
            this.Controls.Add(this.lblFuncionarios);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFimContrato);
            this.Controls.Add(this.dtpContratacao);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.TxtNomeFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area de Funcionarios";
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNomeFuncionario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.DateTimePicker dtpContratacao;
        private System.Windows.Forms.DateTimePicker dtpFimContrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblPagEmDia;
        private System.Windows.Forms.Label lblFuncionarios;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.TextBox txtNomePesquisar;
        private System.Windows.Forms.Label lblNomePesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private AcademiaDataSet1 academiaDataSet1;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private AcademiaDataSet1TableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataContratacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTerminoContratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}