namespace WinFormsApp4
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
            button1 = new Button();
            txt_numero = new TextBox();
            lbl_conta = new Label();
            txt_resultado = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_tabuada = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(119, 76);
            button1.Name = "button1";
            button1.Size = new Size(104, 53);
            button1.TabIndex = 0;
            button1.Text = "Vamos treinar!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_numero
            // 
            txt_numero.Location = new Point(106, 32);
            txt_numero.Name = "txt_numero";
            txt_numero.Size = new Size(138, 27);
            txt_numero.TabIndex = 1;
            // 
            // lbl_conta
            // 
            lbl_conta.AutoSize = true;
            lbl_conta.Location = new Point(33, 162);
            lbl_conta.Name = "lbl_conta";
            lbl_conta.Size = new Size(54, 20);
            lbl_conta.TabIndex = 2;
            lbl_conta.Text = "0 x 0 =";
            // 
            // txt_resultado
            // 
            txt_resultado.Location = new Point(106, 159);
            txt_resultado.Name = "txt_resultado";
            txt_resultado.Size = new Size(125, 27);
            txt_resultado.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(119, 210);
            button2.Name = "button2";
            button2.Size = new Size(104, 38);
            button2.TabIndex = 10;
            button2.Text = "Resultado!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 35);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 11;
            label1.Text = "Número :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-13, 353);
            label2.Name = "label2";
            label2.Size = new Size(357, 20);
            label2.TabIndex = 12;
            label2.Text = "----------------------------------------------------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-13, -2);
            label3.Name = "label3";
            label3.Size = new Size(357, 20);
            label3.TabIndex = 13;
            label3.Text = "----------------------------------------------------------";
            // 
            // btn_tabuada
            // 
            btn_tabuada.Location = new Point(119, 312);
            btn_tabuada.Name = "btn_tabuada";
            btn_tabuada.Size = new Size(104, 38);
            btn_tabuada.TabIndex = 14;
            btn_tabuada.Text = "Tabuada!";
            btn_tabuada.UseVisualStyleBackColor = true;
            btn_tabuada.Click += btn_tabuada_Click;
            btn_tabuada.KeyPress += btn_tabuada_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 371);
            Controls.Add(btn_tabuada);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(txt_resultado);
            Controls.Add(lbl_conta);
            Controls.Add(txt_numero);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txt_numero;
        private Label lbl_conta;
        private TextBox txt_resultado;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_tabuada;
    }
}
