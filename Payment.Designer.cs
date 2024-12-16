namespace Projeto01
{
    partial class Payment
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
            this.btnNovoCard = new System.Windows.Forms.Button();
            this.cmbTipoCard = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelCard = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtValorPagamento = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtNomeCard = new System.Windows.Forms.TextBox();
            this.txtNumeroCard = new System.Windows.Forms.TextBox();
            this.txtNomePag = new System.Windows.Forms.TextBox();
            this.lblCvv = new System.Windows.Forms.Label();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblVencimento = new System.Windows.Forms.Label();
            this.lblNomeCard = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNovoCard
            // 
            this.btnNovoCard.Location = new System.Drawing.Point(423, 434);
            this.btnNovoCard.Name = "btnNovoCard";
            this.btnNovoCard.Size = new System.Drawing.Size(75, 23);
            this.btnNovoCard.TabIndex = 64;
            this.btnNovoCard.Text = "Novo";
            this.btnNovoCard.UseVisualStyleBackColor = true;
            // 
            // cmbTipoCard
            // 
            this.cmbTipoCard.Enabled = false;
            this.cmbTipoCard.FormattingEnabled = true;
            this.cmbTipoCard.Location = new System.Drawing.Point(431, 270);
            this.cmbTipoCard.Name = "cmbTipoCard";
            this.cmbTipoCard.Size = new System.Drawing.Size(78, 21);
            this.cmbTipoCard.TabIndex = 63;
            this.cmbTipoCard.Text = "Selecione";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Bandeira:";
            // 
            // btnCancelCard
            // 
            this.btnCancelCard.Enabled = false;
            this.btnCancelCard.Location = new System.Drawing.Point(504, 434);
            this.btnCancelCard.Name = "btnCancelCard";
            this.btnCancelCard.Size = new System.Drawing.Size(75, 23);
            this.btnCancelCard.TabIndex = 61;
            this.btnCancelCard.Text = "Cancelar";
            this.btnCancelCard.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Green;
            this.btnPagar.Enabled = false;
            this.btnPagar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPagar.Location = new System.Drawing.Point(678, 384);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(97, 58);
            this.btnPagar.TabIndex = 60;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            // 
            // txtValorPagamento
            // 
            this.txtValorPagamento.Enabled = false;
            this.txtValorPagamento.Location = new System.Drawing.Point(431, 365);
            this.txtValorPagamento.Name = "txtValorPagamento";
            this.txtValorPagamento.Size = new System.Drawing.Size(67, 20);
            this.txtValorPagamento.TabIndex = 59;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(394, 368);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 58;
            this.lblValor.Text = "Valor:";
            // 
            // txtCVV
            // 
            this.txtCVV.Enabled = false;
            this.txtCVV.Location = new System.Drawing.Point(431, 329);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(67, 20);
            this.txtCVV.TabIndex = 57;
            // 
            // txtNomeCard
            // 
            this.txtNomeCard.Enabled = false;
            this.txtNomeCard.Location = new System.Drawing.Point(431, 232);
            this.txtNomeCard.Name = "txtNomeCard";
            this.txtNomeCard.Size = new System.Drawing.Size(322, 20);
            this.txtNomeCard.TabIndex = 56;
            // 
            // txtNumeroCard
            // 
            this.txtNumeroCard.Enabled = false;
            this.txtNumeroCard.Location = new System.Drawing.Point(431, 196);
            this.txtNumeroCard.Name = "txtNumeroCard";
            this.txtNumeroCard.Size = new System.Drawing.Size(322, 20);
            this.txtNumeroCard.TabIndex = 55;
            // 
            // txtNomePag
            // 
            this.txtNomePag.Enabled = false;
            this.txtNomePag.Location = new System.Drawing.Point(431, 161);
            this.txtNomePag.Name = "txtNomePag";
            this.txtNomePag.Size = new System.Drawing.Size(322, 20);
            this.txtNomePag.TabIndex = 54;
            // 
            // lblCvv
            // 
            this.lblCvv.AutoSize = true;
            this.lblCvv.Location = new System.Drawing.Point(394, 332);
            this.lblCvv.Name = "lblCvv";
            this.lblCvv.Size = new System.Drawing.Size(31, 13);
            this.lblCvv.TabIndex = 53;
            this.lblCvv.Text = "CVV:";
            // 
            // cmbAno
            // 
            this.cmbAno.Enabled = false;
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(483, 301);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(43, 21);
            this.cmbAno.TabIndex = 52;
            this.cmbAno.Text = "Ano";
            // 
            // cmbMes
            // 
            this.cmbMes.Enabled = false;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(431, 301);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(46, 21);
            this.cmbMes.TabIndex = 51;
            this.cmbMes.Text = "Mês";
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.Location = new System.Drawing.Point(318, 304);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(107, 13);
            this.lblVencimento.TabIndex = 50;
            this.lblVencimento.Text = "Data de Vencimento:";
            // 
            // lblNomeCard
            // 
            this.lblNomeCard.AutoSize = true;
            this.lblNomeCard.Location = new System.Drawing.Point(338, 236);
            this.lblNomeCard.Name = "lblNomeCard";
            this.lblNomeCard.Size = new System.Drawing.Size(87, 13);
            this.lblNomeCard.TabIndex = 49;
            this.lblNomeCard.Text = "Nome no Cartão:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(329, 199);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(96, 13);
            this.lblNumero.TabIndex = 48;
            this.lblNumero.Text = "Número do Cartão:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(479, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 23);
            this.label7.TabIndex = 46;
            this.label7.Text = "TELA DE PAGAMENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 45;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 573);
            this.Controls.Add(this.btnNovoCard);
            this.Controls.Add(this.cmbTipoCard);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelCard);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtValorPagamento);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.txtNomeCard);
            this.Controls.Add(this.txtNumeroCard);
            this.Controls.Add(this.txtNomePag);
            this.Controls.Add(this.lblCvv);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblVencimento);
            this.Controls.Add(this.lblNomeCard);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoCard;
        private System.Windows.Forms.ComboBox cmbTipoCard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelCard;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtValorPagamento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtNomeCard;
        private System.Windows.Forms.TextBox txtNumeroCard;
        private System.Windows.Forms.TextBox txtNomePag;
        private System.Windows.Forms.Label lblCvv;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblVencimento;
        private System.Windows.Forms.Label lblNomeCard;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}