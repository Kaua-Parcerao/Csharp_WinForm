namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_resultado = new Label();
            calcular = new Button();
            resetar = new Button();
            sair = new Button();
            textBoxDados = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.Location = new Point(16, 145);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(75, 20);
            lbl_resultado.TabIndex = 0;
            lbl_resultado.Text = "Resultado";
            // 
            // calcular
            // 
            calcular.Location = new Point(16, 72);
            calcular.Name = "calcular";
            calcular.Size = new Size(94, 58);
            calcular.TabIndex = 1;
            calcular.Text = "Calcular ";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // resetar
            // 
            resetar.Location = new Point(218, 72);
            resetar.Name = "resetar";
            resetar.Size = new Size(94, 58);
            resetar.TabIndex = 2;
            resetar.Text = "Resetar";
            resetar.UseVisualStyleBackColor = true;
            resetar.Click += resetar_Click;
            // 
            // sair
            // 
            sair.Location = new Point(116, 72);
            sair.Name = "sair";
            sair.Size = new Size(96, 58);
            sair.TabIndex = 3;
            sair.Text = "Sair";
            sair.UseVisualStyleBackColor = true;
            sair.Click += sair_Click;
            // 
            // textBoxDados
            // 
            textBoxDados.Location = new Point(116, 23);
            textBoxDados.Name = "textBoxDados";
            textBoxDados.Size = new Size(114, 27);
            textBoxDados.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 6;
            label1.Text = "Peso e Altura:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 174);
            Controls.Add(label1);
            Controls.Add(textBoxDados);
            Controls.Add(sair);
            Controls.Add(resetar);
            Controls.Add(calcular);
            Controls.Add(lbl_resultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_resultado;
        private Button calcular;
        private Button resetar;
        private Button sair;
        private TextBox textBoxDados;
        private Label label1;
    }
}
