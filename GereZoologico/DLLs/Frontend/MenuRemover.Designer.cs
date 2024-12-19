namespace Frontend
{
    partial class MenuRemover
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
            exit = new Button();
            remover = new Button();
            comboBoxSelecionar = new ComboBox();
            listBox1 = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Location = new Point(12, 433);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 0;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // remover
            // 
            remover.Location = new Point(98, 255);
            remover.Name = "remover";
            remover.Size = new Size(94, 29);
            remover.TabIndex = 1;
            remover.Text = "Remover";
            remover.UseVisualStyleBackColor = true;
            remover.Click += remover_Click;
            // 
            // comboBoxSelecionar
            // 
            comboBoxSelecionar.FormattingEnabled = true;
            comboBoxSelecionar.Location = new Point(46, 204);
            comboBoxSelecionar.Name = "comboBoxSelecionar";
            comboBoxSelecionar.Size = new Size(212, 28);
            comboBoxSelecionar.TabIndex = 2;
            comboBoxSelecionar.SelectedIndexChanged += comboBoxSelecionar_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(323, 8);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(713, 464);
            listBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 181);
            label1.Name = "label1";
            label1.Size = new Size(212, 20);
            label1.TabIndex = 4;
            label1.Text = "Seleciona a lista que pretende:";
            // 
            // MenuRemover
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 474);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(comboBoxSelecionar);
            Controls.Add(remover);
            Controls.Add(exit);
            Name = "MenuRemover";
            Text = "MenuRemover";
            Load += MenuRemover_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exit;
        private Button remover;
        private ComboBox comboBoxSelecionar;
        private ListBox listBox1;
        private Label label1;
    }
}