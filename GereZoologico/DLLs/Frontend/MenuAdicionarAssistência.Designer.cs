namespace Frontend
{
    partial class MenuAdicionarAssistência
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
            registarassistencia = new Button();
            exit = new Button();
            comboBoxhabitats = new ComboBox();
            comboBoxanimais = new ComboBox();
            textBoxdata = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // registarassistencia
            // 
            registarassistencia.Location = new Point(176, 337);
            registarassistencia.Name = "registarassistencia";
            registarassistencia.Size = new Size(181, 29);
            registarassistencia.TabIndex = 0;
            registarassistencia.Text = "Registar Assistência";
            registarassistencia.UseVisualStyleBackColor = true;
            registarassistencia.Click += registarassistencia_Click;
            // 
            // exit
            // 
            exit.Location = new Point(12, 409);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 1;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // comboBoxhabitats
            // 
            comboBoxhabitats.FormattingEnabled = true;
            comboBoxhabitats.Location = new Point(146, 101);
            comboBoxhabitats.Name = "comboBoxhabitats";
            comboBoxhabitats.Size = new Size(251, 28);
            comboBoxhabitats.TabIndex = 2;
            // 
            // comboBoxanimais
            // 
            comboBoxanimais.FormattingEnabled = true;
            comboBoxanimais.Location = new Point(146, 192);
            comboBoxanimais.Name = "comboBoxanimais";
            comboBoxanimais.Size = new Size(251, 28);
            comboBoxanimais.TabIndex = 3;
            // 
            // textBoxdata
            // 
            textBoxdata.Location = new Point(146, 276);
            textBoxdata.Name = "textBoxdata";
            textBoxdata.Size = new Size(251, 27);
            textBoxdata.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 78);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 5;
            label1.Text = "Habitat:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 169);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 6;
            label2.Text = "Animal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 253);
            label3.Name = "label3";
            label3.Size = new Size(202, 20);
            label3.TabIndex = 7;
            label3.Text = "Data(dd/mm/yyyy hh:mm:ss):";
            // 
            // MenuAdicionarAssistência
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxdata);
            Controls.Add(comboBoxanimais);
            Controls.Add(comboBoxhabitats);
            Controls.Add(exit);
            Controls.Add(registarassistencia);
            Name = "MenuAdicionarAssistência";
            Text = "MenuAdicionarAssistência";
            Load += MenuAdicionarAssistência_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registarassistencia;
        private Button exit;
        private ComboBox comboBoxhabitats;
        private ComboBox comboBoxanimais;
        private TextBox textBoxdata;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}