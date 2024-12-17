namespace Frontend
{
    partial class MenuCriarContaCliente
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
            criarconta = new Button();
            email = new TextBox();
            nome = new TextBox();
            username = new TextBox();
            nif = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // criarconta
            // 
            criarconta.Location = new Point(465, 301);
            criarconta.Name = "criarconta";
            criarconta.Size = new Size(201, 29);
            criarconta.TabIndex = 0;
            criarconta.Text = "Criar Conta";
            criarconta.UseVisualStyleBackColor = true;
            criarconta.Click += criarconta_Click;
            // 
            // email
            // 
            email.Location = new Point(146, 294);
            email.Name = "email";
            email.Size = new Size(201, 27);
            email.TabIndex = 1;
            // 
            // nome
            // 
            nome.Location = new Point(146, 207);
            nome.Name = "nome";
            nome.Size = new Size(201, 27);
            nome.TabIndex = 2;
            // 
            // username
            // 
            username.Location = new Point(146, 117);
            username.Name = "username";
            username.Size = new Size(201, 27);
            username.TabIndex = 3;
            // 
            // nif
            // 
            nif.Location = new Point(465, 203);
            nif.Name = "nif";
            nif.Size = new Size(201, 27);
            nif.TabIndex = 4;
            // 
            // password
            // 
            password.Location = new Point(465, 117);
            password.Name = "password";
            password.Size = new Size(201, 27);
            password.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 210);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 124);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 7;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 210);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 8;
            label3.Text = "NIF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 124);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 9;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 301);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 10;
            label5.Text = "Email:";
            // 
            // MenuCriarContaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(nif);
            Controls.Add(username);
            Controls.Add(nome);
            Controls.Add(email);
            Controls.Add(criarconta);
            Name = "MenuCriarContaCliente";
            Text = "MenuCriarConta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button criarconta;
        private TextBox email;
        private TextBox nome;
        private TextBox username;
        private TextBox nif;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}