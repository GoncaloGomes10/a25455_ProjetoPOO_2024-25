namespace Frontend
{
    partial class MenuCliente
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
            comprarbilhete = new Button();
            adicionarsaldo = new Button();
            encontraranimal = new Button();
            saldo = new Label();
            mostrasaldo = new TextBox();
            logout = new Button();
            SuspendLayout();
            // 
            // comprarbilhete
            // 
            comprarbilhete.Location = new Point(137, 111);
            comprarbilhete.Name = "comprarbilhete";
            comprarbilhete.Size = new Size(547, 29);
            comprarbilhete.TabIndex = 0;
            comprarbilhete.Text = "Comprar Bilhete";
            comprarbilhete.UseVisualStyleBackColor = true;
            comprarbilhete.Click += comprarbilhete_Click;
            // 
            // adicionarsaldo
            // 
            adicionarsaldo.Location = new Point(137, 186);
            adicionarsaldo.Name = "adicionarsaldo";
            adicionarsaldo.Size = new Size(547, 29);
            adicionarsaldo.TabIndex = 1;
            adicionarsaldo.Text = "Adicionar Saldo";
            adicionarsaldo.UseVisualStyleBackColor = true;
            // 
            // encontraranimal
            // 
            encontraranimal.Location = new Point(137, 265);
            encontraranimal.Name = "encontraranimal";
            encontraranimal.Size = new Size(547, 29);
            encontraranimal.TabIndex = 2;
            encontraranimal.Text = "Encontrar Animal";
            encontraranimal.UseVisualStyleBackColor = true;
            // 
            // saldo
            // 
            saldo.AutoSize = true;
            saldo.Location = new Point(573, 28);
            saldo.Name = "saldo";
            saldo.Size = new Size(50, 20);
            saldo.TabIndex = 3;
            saldo.Text = "Saldo:";
            // 
            // mostrasaldo
            // 
            mostrasaldo.Enabled = false;
            mostrasaldo.Location = new Point(620, 25);
            mostrasaldo.Name = "mostrasaldo";
            mostrasaldo.ReadOnly = true;
            mostrasaldo.Size = new Size(125, 27);
            mostrasaldo.TabIndex = 4;
            mostrasaldo.WordWrap = false;
            // 
            // logout
            // 
            logout.Location = new Point(27, 397);
            logout.Name = "logout";
            logout.Size = new Size(94, 29);
            logout.TabIndex = 5;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // MenuCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logout);
            Controls.Add(mostrasaldo);
            Controls.Add(saldo);
            Controls.Add(encontraranimal);
            Controls.Add(adicionarsaldo);
            Controls.Add(comprarbilhete);
            Name = "MenuCliente";
            Text = "MenuCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button comprarbilhete;
        private Button adicionarsaldo;
        private Button encontraranimal;
        private Label saldo;
        private TextBox mostrasaldo;
        private Button logout;
    }
}