namespace Frontend
{
    partial class MenuAlterarPassword
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
            alterarpassword = new Button();
            textBoxpasswordnova = new TextBox();
            textBoxpasswordantiga = new TextBox();
            exit = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // alterarpassword
            // 
            alterarpassword.Location = new Point(188, 330);
            alterarpassword.Name = "alterarpassword";
            alterarpassword.Size = new Size(143, 29);
            alterarpassword.TabIndex = 0;
            alterarpassword.Text = "Alterar Password";
            alterarpassword.UseVisualStyleBackColor = true;
            alterarpassword.Click += alterarpassword_Click;
            // 
            // textBoxpasswordnova
            // 
            textBoxpasswordnova.Location = new Point(102, 253);
            textBoxpasswordnova.Name = "textBoxpasswordnova";
            textBoxpasswordnova.Size = new Size(326, 27);
            textBoxpasswordnova.TabIndex = 1;
            // 
            // textBoxpasswordantiga
            // 
            textBoxpasswordantiga.Location = new Point(102, 114);
            textBoxpasswordantiga.Name = "textBoxpasswordantiga";
            textBoxpasswordantiga.Size = new Size(326, 27);
            textBoxpasswordantiga.TabIndex = 2;
            // 
            // exit
            // 
            exit.Location = new Point(12, 409);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 4;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 91);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 6;
            label2.Text = "Password Antiga:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 230);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 7;
            label3.Text = "Password Nova:";
            // 
            // MenuAlterarPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(textBoxpasswordantiga);
            Controls.Add(textBoxpasswordnova);
            Controls.Add(alterarpassword);
            Name = "MenuAlterarPassword";
            Text = "MenuAlterarPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button alterarpassword;
        private TextBox textBoxpasswordnova;
        private TextBox textBoxpasswordantiga;
        private Button exit;
        private Label label2;
        private Label label3;
    }
}