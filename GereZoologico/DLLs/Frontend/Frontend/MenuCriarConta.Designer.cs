﻿namespace Frontend
{
    partial class MenuCriarConta
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            Username = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // criarconta
            // 
            criarconta.Location = new Point(482, 298);
            criarconta.Name = "criarconta";
            criarconta.Size = new Size(199, 29);
            criarconta.TabIndex = 0;
            criarconta.Text = "Criar Conta";
            criarconta.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 288);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(482, 194);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(139, 194);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(482, 88);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(199, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(139, 88);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(199, 27);
            textBox5.TabIndex = 5;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(37, 96);
            Username.Name = "Username";
            Username.Size = new Size(78, 20);
            Username.TabIndex = 6;
            Username.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 201);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 7;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 96);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 295);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 9;
            label4.Text = "Nome:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(432, 201);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 10;
            label5.Text = "NIF:";
            // 
            // MenuCriarConta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(criarconta);
            Name = "MenuCriarConta";
            Text = "MenuCriarConta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button criarconta;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label Username;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}