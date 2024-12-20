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
            comprarbilhete = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxTipobilhete
            // 
            comboBoxTipobilhete.FormattingEnabled = true;
            comboBoxTipobilhete.Location = new Point(315, 205);
            comboBoxTipobilhete.Name = "comboBoxTipobilhete";
            comboBoxTipobilhete.Size = new Size(151, 28);
            comboBoxTipobilhete.TabIndex = 0;
            comboBoxTipobilhete.SelectedIndexChanged += comboBoxTipobilhete_SelectedIndexChanged;
            // 
            // comboBoxZona
            // 
            comboBoxZona.FormattingEnabled = true;
            comboBoxZona.Location = new Point(115, 205);
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
            // comprarbilhete
            // 
            comprarbilhete.Location = new Point(315, 280);
            comprarbilhete.Name = "comprarbilhete";
            comprarbilhete.Size = new Size(151, 29);
            comprarbilhete.TabIndex = 3;
            comprarbilhete.Text = "Comprar Bilhete";
            comprarbilhete.UseVisualStyleBackColor = true;
            comprarbilhete.Click += comprarbilhete_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(555, 206);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(500, 213);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Preço:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(592, 209);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 6;
            label2.Text = "€";
            // 
            // MenuBilhete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comprarbilhete);
            Controls.Add(exit);
            Controls.Add(comboBoxZona);
            Controls.Add(comboBoxTipobilhete);
            Name = "MenuBilhete";
            Text = "MenuBilhete";
            Load += MenuBilhete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxTipobilhete;
        private ComboBox comboBoxZona;
        private Button exit;
        private Button comprarbilhete;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}