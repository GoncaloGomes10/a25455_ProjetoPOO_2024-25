namespace Frontend
{
    partial class MenuAdicionarAlimentação
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
            comboBoxanimal = new ComboBox();
            comboBoxtipodecomida = new ComboBox();
            registaralimentacao = new Button();
            exit = new Button();
            textBoxquantidade = new TextBox();
            textBoxdata = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxanimal
            // 
            comboBoxanimal.FormattingEnabled = true;
            comboBoxanimal.Location = new Point(73, 110);
            comboBoxanimal.Name = "comboBoxanimal";
            comboBoxanimal.Size = new Size(211, 28);
            comboBoxanimal.TabIndex = 0;
            // 
            // comboBoxtipodecomida
            // 
            comboBoxtipodecomida.FormattingEnabled = true;
            comboBoxtipodecomida.Location = new Point(73, 231);
            comboBoxtipodecomida.Name = "comboBoxtipodecomida";
            comboBoxtipodecomida.Size = new Size(211, 28);
            comboBoxtipodecomida.TabIndex = 1;
            // 
            // registaralimentacao
            // 
            registaralimentacao.Location = new Point(246, 317);
            registaralimentacao.Name = "registaralimentacao";
            registaralimentacao.Size = new Size(184, 29);
            registaralimentacao.TabIndex = 2;
            registaralimentacao.Text = "Registar Alimentação";
            registaralimentacao.UseVisualStyleBackColor = true;
            registaralimentacao.Click += registaralimentacao_Click;
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
            // textBoxquantidade
            // 
            textBoxquantidade.Location = new Point(411, 231);
            textBoxquantidade.Name = "textBoxquantidade";
            textBoxquantidade.Size = new Size(211, 27);
            textBoxquantidade.TabIndex = 4;
            // 
            // textBoxdata
            // 
            textBoxdata.Location = new Point(411, 111);
            textBoxdata.Name = "textBoxdata";
            textBoxdata.Size = new Size(211, 27);
            textBoxdata.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 87);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 6;
            label1.Text = "Animal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 208);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 8;
            label3.Text = "Quantidade(kg):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 87);
            label4.Name = "label4";
            label4.Size = new Size(195, 20);
            label4.TabIndex = 9;
            label4.Text = "Data(dd/mm/yyy hh:mm:ss):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 208);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 10;
            label2.Text = "Tipo de Comida:";
            // 
            // MenuAdicionarAlimentação
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 450);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxdata);
            Controls.Add(textBoxquantidade);
            Controls.Add(exit);
            Controls.Add(registaralimentacao);
            Controls.Add(comboBoxtipodecomida);
            Controls.Add(comboBoxanimal);
            Name = "MenuAdicionarAlimentação";
            Text = "AdicionarAlimentação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxanimal;
        private ComboBox comboBoxtipodecomida;
        private Button registaralimentacao;
        private Button exit;
        private TextBox textBoxquantidade;
        private TextBox textBoxdata;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
    }
}