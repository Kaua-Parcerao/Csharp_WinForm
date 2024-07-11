namespace While_Média
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
            txt_dados = new TextBox();
            btn_media = new Button();
            btn_resetar = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_dados
            // 
            txt_dados.Location = new Point(28, 25);
            txt_dados.Name = "txt_dados";
            txt_dados.Size = new Size(231, 27);
            txt_dados.TabIndex = 0;
            txt_dados.KeyPress += txt_dados_KeyPress;
            // 
            // btn_media
            // 
            btn_media.Location = new Point(28, 72);
            btn_media.Name = "btn_media";
            btn_media.Size = new Size(82, 29);
            btn_media.TabIndex = 1;
            btn_media.Text = "Calcular";
            btn_media.UseVisualStyleBackColor = true;
            btn_media.Click += btn_media_Click;
            // 
            // btn_resetar
            // 
            btn_resetar.Location = new Point(179, 72);
            btn_resetar.Name = "btn_resetar";
            btn_resetar.Size = new Size(80, 29);
            btn_resetar.TabIndex = 2;
            btn_resetar.Text = "Resetar";
            btn_resetar.UseVisualStyleBackColor = true;
            btn_resetar.Click += btn_resetar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(28, 107);
            button1.Name = "button1";
            button1.Size = new Size(231, 29);
            button1.TabIndex = 3;
            button1.Text = "Mostrar todas as médias";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 166);
            label1.Name = "label1";
            label1.Size = new Size(261, 17);
            label1.TabIndex = 4;
            label1.Text = "Ao apertar a tecla \"p\" encerra o programa.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 192);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btn_resetar);
            Controls.Add(btn_media);
            Controls.Add(txt_dados);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_dados;
        private Button btn_media;
        private Button btn_resetar;
        private Button button1;
        private Label label1;
    }
}
