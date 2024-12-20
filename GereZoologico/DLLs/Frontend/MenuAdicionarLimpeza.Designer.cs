namespace Frontend
{
    partial class MenuAdicionarLimpeza
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
            comboBoxhabitats = new ComboBox();
            textboxdata = new TextBox();
            resgistarlimpeza = new Button();
            exit = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxhabitats
            // 
            comboBoxhabitats.FormattingEnabled = true;
            comboBoxhabitats.Location = new Point(72, 127);
            comboBoxhabitats.Name = "comboBoxhabitats";
            comboBoxhabitats.Size = new Size(279, 28);
            comboBoxhabitats.TabIndex = 0;
            // 
            // textboxdata
            // 
            textboxdata.Location = new Point(72, 256);
            textboxdata.Name = "textboxdata";
            textboxdata.Size = new Size(279, 27);
            textboxdata.TabIndex = 1;
            textboxdata.TextChanged += textboxdata_TextChanged;
            // 
            // resgistarlimpeza
            // 
            resgistarlimpeza.Location = new Point(126, 313);
            resgistarlimpeza.Name = "resgistarlimpeza";
            resgistarlimpeza.Size = new Size(141, 29);
            resgistarlimpeza.TabIndex = 2;
            resgistarlimpeza.Text = "Registar Limpeza";
            resgistarlimpeza.UseVisualStyleBackColor = true;
            resgistarlimpeza.Click += resgistarlimpeza_Click;
            // 
            // exit
            // 
            exit.Location = new Point(12, 409);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 3;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 104);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 4;
            label1.Text = "Habitat:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 233);
            label2.Name = "label2";
            label2.Size = new Size(202, 20);
            label2.TabIndex = 5;
            label2.Text = "Data(dd/mm/yyyy hh:mm:ss):";
            // 
            // MenuAdicionarLimpeza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exit);
            Controls.Add(resgistarlimpeza);
            Controls.Add(textboxdata);
            Controls.Add(comboBoxhabitats);
            Name = "MenuAdicionarLimpeza";
            Text = "MenuAdicionarLimpeza";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxhabitats;
        private TextBox textboxdata;
        private Button resgistarlimpeza;
        private Button exit;
        private Label label1;
        private Label label2;
    }
}