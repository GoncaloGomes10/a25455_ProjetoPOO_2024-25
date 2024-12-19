namespace Frontend
{
    partial class MenuMostrar
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
            listBox1 = new ListBox();
            comboBoxSelecionar = new ComboBox();
            exit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(386, 1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(632, 444);
            listBox1.TabIndex = 0;
            // 
            // comboBoxSelecionar
            // 
            comboBoxSelecionar.FormattingEnabled = true;
            comboBoxSelecionar.Location = new Point(80, 194);
            comboBoxSelecionar.Name = "comboBoxSelecionar";
            comboBoxSelecionar.Size = new Size(212, 28);
            comboBoxSelecionar.TabIndex = 1;
            comboBoxSelecionar.SelectedIndexChanged += comboBoxSelecionar_SelectedIndexChanged;
            // 
            // exit
            // 
            exit.Location = new Point(30, 396);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 2;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 171);
            label1.Name = "label1";
            label1.Size = new Size(212, 20);
            label1.TabIndex = 3;
            label1.Text = "Seleciona a lista que pretende:";
            // 
            // MenuMostrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 454);
            Controls.Add(label1);
            Controls.Add(exit);
            Controls.Add(comboBoxSelecionar);
            Controls.Add(listBox1);
            Name = "MenuMostrar";
            Text = "MenuMostrar";
            Load += MenuMostrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ComboBox comboBoxSelecionar;
        private Button exit;
        private Label label1;
    }
}