namespace WFInicial
{
    partial class FormEx6
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
            lblNome = new Label();
            txtNome = new TextBox();
            txtQuantHoras = new TextBox();
            lblQuantHoras = new Label();
            txtValorHora = new TextBox();
            lblValorHora = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(98, 85);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(184, 82);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // txtQuantHoras
            // 
            txtQuantHoras.Location = new Point(184, 140);
            txtQuantHoras.Name = "txtQuantHoras";
            txtQuantHoras.Size = new Size(100, 23);
            txtQuantHoras.TabIndex = 3;
            // 
            // lblQuantHoras
            // 
            lblQuantHoras.AutoSize = true;
            lblQuantHoras.Location = new Point(59, 144);
            lblQuantHoras.Name = "lblQuantHoras";
            lblQuantHoras.Size = new Size(119, 15);
            lblQuantHoras.TabIndex = 2;
            lblQuantHoras.Text = "Quantidade de Horas";
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(184, 111);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(100, 23);
            txtValorHora.TabIndex = 5;
            // 
            // lblValorHora
            // 
            lblValorHora.AutoSize = true;
            lblValorHora.Location = new Point(79, 114);
            lblValorHora.Name = "lblValorHora";
            lblValorHora.Size = new Size(76, 15);
            lblValorHora.TabIndex = 4;
            lblValorHora.Text = "Valor da hora";
            lblValorHora.Click += lblRenda_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(184, 181);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnRendaTotal_Click;
            // 
            // FormEx6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtValorHora);
            Controls.Add(lblValorHora);
            Controls.Add(txtQuantHoras);
            Controls.Add(lblQuantHoras);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "FormEx6";
            Text = "FormEx6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtQuantHoras;
        private Label lblQuantHoras;
        private TextBox txtValorHora;
        private Label lblValorHora;
        private Button btnCalcular;
    }
}