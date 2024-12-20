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
            encontraranimal = new Button();
            logout = new Button();
            SuspendLayout();
            // 
            // comprarbilhete
            // 
            comprarbilhete.Location = new Point(137, 176);
            comprarbilhete.Name = "comprarbilhete";
            comprarbilhete.Size = new Size(547, 29);
            comprarbilhete.TabIndex = 0;
            comprarbilhete.Text = "Comprar Bilhete";
            comprarbilhete.UseVisualStyleBackColor = true;
            comprarbilhete.Click += comprarbilhete_Click;
            // 
            // encontraranimal
            // 
            encontraranimal.Location = new Point(137, 248);
            encontraranimal.Name = "encontraranimal";
            encontraranimal.Size = new Size(547, 29);
            encontraranimal.TabIndex = 2;
            encontraranimal.Text = "Encontrar Animal";
            encontraranimal.UseVisualStyleBackColor = true;
            encontraranimal.Click += encontraranimal_Click;
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
            Controls.Add(encontraranimal);
            Controls.Add(comprarbilhete);
            Name = "MenuCliente";
            Text = "MenuCliente";
            ResumeLayout(false);
        }

        #endregion

        private Button comprarbilhete;
        private Button encontraranimal;
        private Button logout;
    }
}