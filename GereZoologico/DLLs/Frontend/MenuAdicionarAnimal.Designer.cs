namespace Frontend
{
    partial class MenuAdicionarAnimal
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
            idadetext = new TextBox();
            nometext = new TextBox();
            pesotext = new TextBox();
            comboBoxdieta = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxespecie = new ComboBox();
            criaranimal = new Button();
            exit = new Button();
            comboBoxhabitat = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // idadetext
            // 
            idadetext.Location = new Point(75, 174);
            idadetext.Name = "idadetext";
            idadetext.Size = new Size(190, 27);
            idadetext.TabIndex = 0;
            // 
            // nometext
            // 
            nometext.Location = new Point(75, 95);
            nometext.Name = "nometext";
            nometext.Size = new Size(190, 27);
            nometext.TabIndex = 2;
            // 
            // pesotext
            // 
            pesotext.Location = new Point(75, 260);
            pesotext.Name = "pesotext";
            pesotext.Size = new Size(190, 27);
            pesotext.TabIndex = 3;
            // 
            // comboBoxdieta
            // 
            comboBoxdieta.FormattingEnabled = true;
            comboBoxdieta.Location = new Point(458, 173);
            comboBoxdieta.Name = "comboBoxdieta";
            comboBoxdieta.Size = new Size(190, 28);
            comboBoxdieta.TabIndex = 4;
            comboBoxdieta.SelectedIndexChanged += comboBoxdieta_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 72);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 150);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Idade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 237);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 7;
            label3.Text = "Peso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 71);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 8;
            label4.Text = "Especie:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 150);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 9;
            label5.Text = "Dieta:";
            // 
            // comboBoxespecie
            // 
            comboBoxespecie.FormattingEnabled = true;
            comboBoxespecie.Location = new Point(458, 94);
            comboBoxespecie.Name = "comboBoxespecie";
            comboBoxespecie.Size = new Size(190, 28);
            comboBoxespecie.TabIndex = 10;
            comboBoxespecie.SelectedIndexChanged += comboBoxanimal_SelectedIndexChanged;
            // 
            // criaranimal
            // 
            criaranimal.Location = new Point(266, 333);
            criaranimal.Name = "criaranimal";
            criaranimal.Size = new Size(190, 29);
            criaranimal.TabIndex = 11;
            criaranimal.Text = "Adicionar Animal";
            criaranimal.UseVisualStyleBackColor = true;
            criaranimal.Click += criaranimal_Click;
            // 
            // exit
            // 
            exit.Location = new Point(12, 409);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 12;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // comboBoxhabitat
            // 
            comboBoxhabitat.FormattingEnabled = true;
            comboBoxhabitat.Location = new Point(458, 259);
            comboBoxhabitat.Name = "comboBoxhabitat";
            comboBoxhabitat.Size = new Size(190, 28);
            comboBoxhabitat.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 237);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 14;
            label6.Text = "Habitat:";
            // 
            // MenuAdicionarAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 450);
            Controls.Add(label6);
            Controls.Add(comboBoxhabitat);
            Controls.Add(exit);
            Controls.Add(criaranimal);
            Controls.Add(comboBoxespecie);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxdieta);
            Controls.Add(pesotext);
            Controls.Add(nometext);
            Controls.Add(idadetext);
            Name = "MenuAdicionarAnimal";
            Text = "MenuAdicionarAnimal";
            Load += MenuAdicionarAnimal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idadetext;
        private TextBox textBox2;
        private TextBox nometext;
        private TextBox pesotext;
        private ComboBox comboBoxdieta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxespecie;
        private Button criaranimal;
        private Button exit;
        private ComboBox comboBoxhabitat;
        private Label label6;
    }
}