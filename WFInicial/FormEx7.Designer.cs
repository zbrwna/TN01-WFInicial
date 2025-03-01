namespace WFInicial
{
    partial class FormEx7
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
            btnCadastro = new Button();
            lblProduto = new Label();
            txtProduto = new TextBox();
            txtValorProduto = new TextBox();
            lblValorProduto = new Label();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(91, 165);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(75, 23);
            btnCadastro.TabIndex = 0;
            btnCadastro.Text = "Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(47, 94);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 1;
            lblProduto.Text = "Produto";
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(104, 91);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(100, 23);
            txtProduto.TabIndex = 2;
            // 
            // txtValorProduto
            // 
            txtValorProduto.Location = new Point(104, 120);
            txtValorProduto.Name = "txtValorProduto";
            txtValorProduto.Size = new Size(100, 23);
            txtValorProduto.TabIndex = 4;
            // 
            // lblValorProduto
            // 
            lblValorProduto.AutoSize = true;
            lblValorProduto.Location = new Point(64, 123);
            lblValorProduto.Name = "lblValorProduto";
            lblValorProduto.Size = new Size(33, 15);
            lblValorProduto.TabIndex = 3;
            lblValorProduto.Text = "Valor";
            // 
            // FormEx7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtValorProduto);
            Controls.Add(lblValorProduto);
            Controls.Add(txtProduto);
            Controls.Add(lblProduto);
            Controls.Add(btnCadastro);
            Name = "FormEx7";
            Text = "FormEx7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastro;
        private Label lblProduto;
        private TextBox txtProduto;
        private TextBox txtValorProduto;
        private Label lblValorProduto;
    }
}