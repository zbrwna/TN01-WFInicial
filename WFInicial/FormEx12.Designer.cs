namespace WFInicial
{
    partial class FormEx12
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
            lblNumeros = new Label();
            txtNumero = new TextBox();
            lblContador = new Label();
            btnAdicionar = new Button();
            lblNome = new Label();
            lblPar = new Label();
            lblImpar = new Label();
            SuspendLayout();
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Location = new Point(111, 66);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(51, 15);
            lblNumeros.TabIndex = 0;
            lblNumeros.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(174, 63);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(298, 66);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(13, 15);
            lblContador.TabIndex = 2;
            lblContador.Text = "0";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(186, 92);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lblNome
            // 
            lblNome.BorderStyle = BorderStyle.Fixed3D;
            lblNome.Location = new Point(140, 135);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(161, 23);
            lblNome.TabIndex = 4;
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPar
            // 
            lblPar.BorderStyle = BorderStyle.Fixed3D;
            lblPar.Location = new Point(140, 178);
            lblPar.Name = "lblPar";
            lblPar.Size = new Size(161, 23);
            lblPar.TabIndex = 5;
            // 
            // lblImpar
            // 
            lblImpar.BorderStyle = BorderStyle.Fixed3D;
            lblImpar.Location = new Point(140, 222);
            lblImpar.Name = "lblImpar";
            lblImpar.Size = new Size(161, 23);
            lblImpar.TabIndex = 6;
            // 
            // FormEx12
            // 
            AcceptButton = btnAdicionar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblImpar);
            Controls.Add(lblPar);
            Controls.Add(lblNome);
            Controls.Add(btnAdicionar);
            Controls.Add(lblContador);
            Controls.Add(txtNumero);
            Controls.Add(lblNumeros);
            Name = "FormEx12";
            Text = "FormEx12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumeros;
        private TextBox txtNumero;
        private Label lblContador;
        private Button btnAdicionar;
        private Label lblNome;
        private Label lblPar;
        private Label lblImpar;
    }
}