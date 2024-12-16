namespace Projeto01
{
    partial class FrmPrincipal
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
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNomePesquisar = new System.Windows.Forms.TextBox();
            this.lblNomePesquisar = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDados = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.sidebarTime = new System.Windows.Forms.Timer(this.components);
            this.clienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.academiaDataSet8 = new Projeto01.AcademiaDataSet8();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.clienteTableAdapter3 = new Projeto01.AcademiaDataSet8TableAdapters.ClienteTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.academiaDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet7BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(254, 77);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(84, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome completo:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(315, 104);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(303, 130);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(42, 13);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Celular:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(361, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(322, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtCPF
            // 
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(361, 101);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(125, 20);
            this.txtCPF.TabIndex = 4;
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(361, 127);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(125, 20);
            this.txtTel.TabIndex = 5;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(358, 233);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(439, 233);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Cadastrar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(253, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "CADASTRAR ALUNO";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(520, 233);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(601, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.txtCancelar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(422, 406);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(97, 23);
            this.btnAtualizar.TabIndex = 14;
            this.btnAtualizar.Text = "Atualizar dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "BUSCAR ALUNO";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(341, 406);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisaNome_Click);
            // 
            // txtNomePesquisar
            // 
            this.txtNomePesquisar.Location = new System.Drawing.Point(340, 371);
            this.txtNomePesquisar.Name = "txtNomePesquisar";
            this.txtNomePesquisar.Size = new System.Drawing.Size(322, 20);
            this.txtNomePesquisar.TabIndex = 18;
            // 
            // lblNomePesquisar
            // 
            this.lblNomePesquisar.AutoSize = true;
            this.lblNomePesquisar.Location = new System.Drawing.Point(233, 374);
            this.lblNomePesquisar.Name = "lblNomePesquisar";
            this.lblNomePesquisar.Size = new System.Drawing.Size(84, 13);
            this.lblNomePesquisar.TabIndex = 17;
            this.lblNomePesquisar.Text = "Nome completo:";
            // 
            // sidebar
            // 
            this.sidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(220, 1080);
            this.sidebar.MinimumSize = new System.Drawing.Size(79, 652);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(79, 768);
            this.sidebar.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 78);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(74, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::Projeto01.Properties.Resources.menu_ui;
            this.menuButton.Location = new System.Drawing.Point(23, 30);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(30, 30);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(3, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(217, 49);
            this.panel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAlunos);
            this.panel5.Location = new System.Drawing.Point(8, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 49);
            this.panel5.TabIndex = 21;
            // 
            // btnAlunos
            // 
            this.btnAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlunos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlunos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlunos.Image = global::Projeto01.Properties.Resources.pessoas_ui;
            this.btnAlunos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlunos.Location = new System.Drawing.Point(-19, -9);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAlunos.Size = new System.Drawing.Size(252, 68);
            this.btnAlunos.TabIndex = 20;
            this.btnAlunos.Text = "             Alunos";
            this.btnAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlunos.UseVisualStyleBackColor = false;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = global::Projeto01.Properties.Resources.home1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-19, -9);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(252, 68);
            this.button3.TabIndex = 20;
            this.button3.Text = "             Inicio";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Location = new System.Drawing.Point(3, 142);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(217, 49);
            this.panel6.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnDados);
            this.panel7.Location = new System.Drawing.Point(8, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(217, 49);
            this.panel7.TabIndex = 21;
            // 
            // btnDados
            // 
            this.btnDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDados.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDados.Image = global::Projeto01.Properties.Resources.ad;
            this.btnDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDados.Location = new System.Drawing.Point(-19, -9);
            this.btnDados.Name = "btnDados";
            this.btnDados.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDados.Size = new System.Drawing.Size(244, 60);
            this.btnDados.TabIndex = 20;
            this.btnDados.Text = "             Planos";
            this.btnDados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDados.UseVisualStyleBackColor = false;
            this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Image = global::Projeto01.Properties.Resources.home1;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-19, -9);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(252, 68);
            this.button5.TabIndex = 20;
            this.button5.Text = "             Inicio";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // sidebarTime
            // 
            this.sidebarTime.Interval = 10;
            this.sidebarTime.Tick += new System.EventHandler(this.sidebarTime_Tick);
            // 
            // clienteBindingSource3
            // 
            this.clienteBindingSource3.DataMember = "Cliente";
            this.clienteBindingSource3.DataSource = this.academiaDataSet8;
            // 
            // academiaDataSet8
            // 
            this.academiaDataSet8.DataSetName = "AcademiaDataSet8";
            this.academiaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pago",
            "Atrasado"});
            this.cmbStatus.Location = new System.Drawing.Point(361, 160);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 21;
            // 
            // dtpDataPagamento
            // 
            this.dtpDataPagamento.Enabled = false;
            this.dtpDataPagamento.Location = new System.Drawing.Point(361, 188);
            this.dtpDataPagamento.Name = "dtpDataPagamento";
            this.dtpDataPagamento.Size = new System.Drawing.Size(200, 20);
            this.dtpDataPagamento.TabIndex = 22;
            this.dtpDataPagamento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // clienteTableAdapter3
            // 
            this.clienteTableAdapter3.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Status de pagamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Data de pagamento:";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "Cliente";
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "Cliente";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1646, 768);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDataPagamento);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.txtNomePesquisar);
            this.Controls.Add(this.lblNomePesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load_1);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet7BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNomePesquisar;
        private System.Windows.Forms.Label lblNomePesquisar;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnDados;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer sidebarTime;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpDataPagamento;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.BindingSource academiaDataSet7BindingSource;
        private AcademiaDataSet8 academiaDataSet8;
        private System.Windows.Forms.BindingSource clienteBindingSource3;
        private AcademiaDataSet8TableAdapters.ClienteTableAdapter clienteTableAdapter3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

