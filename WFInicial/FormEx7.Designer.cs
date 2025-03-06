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
            btnContador = new Button();
            lblNomeProduto = new Label();
            txtNomeProduto = new TextBox();
            txtValorProduto = new TextBox();
            lblValorProduto = new Label();
            SuspendLayout();
            // 
            // btnContador
            // 
            btnContador.Location = new Point(215, 164);
            btnContador.Name = "btnContador";
            btnContador.Size = new Size(75, 23);
            btnContador.TabIndex = 0;
            btnContador.Text = "Contador";
            btnContador.UseVisualStyleBackColor = true;
            btnContador.Click += btnCadastrar_Click;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(140, 75);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(50, 15);
            lblNomeProduto.TabIndex = 1;
            lblNomeProduto.Text = "Produto";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(201, 72);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(100, 23);
            txtNomeProduto.TabIndex = 2;
            // 
            // txtValorProduto
            // 
            txtValorProduto.Location = new Point(201, 113);
            txtValorProduto.Name = "txtValorProduto";
            txtValorProduto.Size = new Size(100, 23);
            txtValorProduto.TabIndex = 4;
            // 
            // lblValorProduto
            // 
            lblValorProduto.AutoSize = true;
            lblValorProduto.Location = new Point(140, 116);
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
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNomeProduto);
            Controls.Add(btnContador);
            Name = "FormEx7";
            Text = "FormEx7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContador;
        private Label lblNomeProduto;
        private TextBox txtNomeProduto;
        private TextBox txtValorProduto;
        private Label lblValorProduto;
    }
}