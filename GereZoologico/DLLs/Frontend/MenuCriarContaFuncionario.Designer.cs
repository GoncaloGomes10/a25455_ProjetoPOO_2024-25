namespace Frontend
{
    partial class MenuCriarContaFuncionario
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
            nif = new TextBox();
            nome = new TextBox();
            email = new TextBox();
            username = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            criarcontafuncionario = new Button();
            SuspendLayout();
            // 
            // nif
            // 
            nif.Location = new Point(525, 208);
            nif.Name = "nif";
            nif.Size = new Size(201, 27);
            nif.TabIndex = 0;
            // 
            // nome
            // 
            nome.Location = new Point(125, 313);
            nome.Name = "nome";
            nome.Size = new Size(201, 27);
            nome.TabIndex = 1;
            // 
            // email
            // 
            email.Location = new Point(125, 208);
            email.Name = "email";
            email.Size = new Size(201, 27);
            email.TabIndex = 2;
            // 
            // username
            // 
            username.Location = new Point(125, 106);
            username.Name = "username";
            username.Size = new Size(201, 27);
            username.TabIndex = 3;
            // 
            // password
            // 
            password.Location = new Point(525, 106);
            password.Name = "password";
            password.Size = new Size(201, 27);
            password.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 113);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 5;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 215);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 320);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 215);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 8;
            label4.Text = "NIF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(437, 113);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 9;
            label5.Text = "Password:";
            // 
            // criarcontafuncionario
            // 
            criarcontafuncionario.Location = new Point(525, 311);
            criarcontafuncionario.Name = "criarcontafuncionario";
            criarcontafuncionario.Size = new Size(201, 29);
            criarcontafuncionario.TabIndex = 10;
            criarcontafuncionario.Text = "Criar Conta";
            criarcontafuncionario.UseVisualStyleBackColor = true;
            criarcontafuncionario.Click += criarcontafuncionario_Click;
            // 
            // MenuCriarContaFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(criarcontafuncionario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(email);
            Controls.Add(nome);
            Controls.Add(nif);
            Name = "MenuCriarContaFuncionario";
            Text = "MenuCriarContaFuncionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nif;
        private TextBox nome;
        private TextBox email;
        private TextBox username;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button criarcontafuncionario;
    }
}