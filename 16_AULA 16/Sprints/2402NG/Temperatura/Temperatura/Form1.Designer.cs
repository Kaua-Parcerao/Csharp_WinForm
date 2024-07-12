namespace Temperatura
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
            txt_temp = new TextBox();
            btn_temp = new Button();
            button1 = new Button();
            btn_resetar = new Button();
            button3 = new Button();
            txt_nome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txt_temp
            // 
            txt_temp.Location = new Point(147, 33);
            txt_temp.Name = "txt_temp";
            txt_temp.Size = new Size(125, 27);
            txt_temp.TabIndex = 0;
            // 
            // btn_temp
            // 
            btn_temp.Location = new Point(45, 131);
            btn_temp.Name = "btn_temp";
            btn_temp.Size = new Size(94, 29);
            btn_temp.TabIndex = 1;
            btn_temp.Text = "Medir";
            btn_temp.UseVisualStyleBackColor = true;
            btn_temp.Click += btn_temp_Click;
            // 
            // button1
            // 
            button1.Location = new Point(212, 131);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "historico";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_resetar
            // 
            btn_resetar.Location = new Point(45, 180);
            btn_resetar.Name = "btn_resetar";
            btn_resetar.Size = new Size(94, 29);
            btn_resetar.TabIndex = 3;
            btn_resetar.Text = "Resetar";
            btn_resetar.UseVisualStyleBackColor = true;
            btn_resetar.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(212, 180);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Número";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(147, 74);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(125, 27);
            txt_nome.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 36);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 6;
            label1.Text = "Temperatura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 74);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 7;
            label2.Text = "Nome:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(339, 249);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_nome);
            Controls.Add(button3);
            Controls.Add(btn_resetar);
            Controls.Add(button1);
            Controls.Add(btn_temp);
            Controls.Add(txt_temp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_temp;
        private Button btn_temp;
        private Button button1;
        private Button btn_resetar;
        private Button button3;
        private TextBox txt_nome;
        private Label label1;
        private Label label2;
    }
}
