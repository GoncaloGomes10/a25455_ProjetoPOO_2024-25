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
            logout = new Button();
            comprarbilhete = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // logout
            // 
            logout.Location = new Point(23, 399);
            logout.Name = "logout";
            logout.Size = new Size(94, 29);
            logout.TabIndex = 0;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            // 
            // comprarbilhete
            // 
            comprarbilhete.Location = new Point(180, 206);
            comprarbilhete.Name = "comprarbilhete";
            comprarbilhete.Size = new Size(157, 29);
            comprarbilhete.TabIndex = 1;
            comprarbilhete.Text = "Comprar Bilhete";
            comprarbilhete.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(495, 206);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(592, 40);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "Saldo:";
            // 
            // MenuCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(comprarbilhete);
            Controls.Add(logout);
            Name = "MenuCliente";
            Text = "MenuCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logout;
        private Button comprarbilhete;
        private Button button2;
        private Label label1;
    }
}