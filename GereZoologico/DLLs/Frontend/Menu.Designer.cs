namespace Frontend
{
    partial class Menu
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
            direcionarmenucriarconta = new Button();
            direcionarmenu = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // direcionarmenucriarconta
            // 
            direcionarmenucriarconta.Location = new Point(261, 286);
            direcionarmenucriarconta.Name = "direcionarmenucriarconta";
            direcionarmenucriarconta.Size = new Size(120, 29);
            direcionarmenucriarconta.TabIndex = 0;
            direcionarmenucriarconta.Text = "Criar Conta";
            direcionarmenucriarconta.UseVisualStyleBackColor = true;
            direcionarmenucriarconta.Click += direcionarmenucriarconta_Click;
            // 
            // direcionarmenu
            // 
            direcionarmenu.Location = new Point(444, 286);
            direcionarmenu.Name = "direcionarmenu";
            direcionarmenu.Size = new Size(120, 29);
            direcionarmenu.TabIndex = 1;
            direcionarmenu.Text = "Login";
            direcionarmenu.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 149);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 206);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(direcionarmenu);
            Controls.Add(direcionarmenucriarconta);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button direcionarmenucriarconta;
        private Button direcionarmenu;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}