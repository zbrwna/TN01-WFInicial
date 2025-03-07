namespace WFInicial
{
    partial class FormEx10
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
            txtNumero = new TextBox();
            label1 = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(141, 57);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(96, 23);
            txtNumero.TabIndex = 1;
            txtNumero.Leave += txtNumero_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 60);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Numero";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(124, 101);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(136, 199);
            txtResultado.TabIndex = 3;
            // 
            // FormEx10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 331);
            Controls.Add(txtResultado);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Name = "FormEx10";
            Text = "FormEx10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private Label label1;
        private TextBox txtResultado;
    }
}