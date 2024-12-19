namespace Frontend
{
    partial class MenuBilhete
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
            comboBoxTipobilhete = new ComboBox();
            comboBoxZona = new ComboBox();
            exit = new Button();
            SuspendLayout();
            // 
            // comboBoxTipobilhete
            // 
            comboBoxTipobilhete.FormattingEnabled = true;
            comboBoxTipobilhete.Location = new Point(286, 205);
            comboBoxTipobilhete.Name = "comboBoxTipobilhete";
            comboBoxTipobilhete.Size = new Size(151, 28);
            comboBoxTipobilhete.TabIndex = 0;
            comboBoxTipobilhete.SelectedIndexChanged += comboBoxTipobilhete_SelectedIndexChanged;
            // 
            // comboBoxZona
            // 
            comboBoxZona.FormattingEnabled = true;
            comboBoxZona.Location = new Point(98, 205);
            comboBoxZona.Name = "comboBoxZona";
            comboBoxZona.Size = new Size(151, 28);
            comboBoxZona.TabIndex = 1;
            comboBoxZona.SelectedIndexChanged += comboBoxZona_SelectedIndexChanged;
            // 
            // exit
            // 
            exit.Location = new Point(24, 399);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 2;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // MenuBilhete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(comboBoxZona);
            Controls.Add(comboBoxTipobilhete);
            Name = "MenuBilhete";
            Text = "MenuBilhete";
            Load += MenuBilhete_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxTipobilhete;
        private ComboBox comboBoxZona;
        private Button exit;
    }
}