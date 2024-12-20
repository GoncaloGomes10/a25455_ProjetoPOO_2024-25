namespace Frontend
{
    partial class MenuEncontrarAnimal
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
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Location = new Point(62, 240);
            exit.Name = "exit";
            exit.Size = new Size(156, 29);
            exit.TabIndex = 0;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(293, 8);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(495, 424);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // MenuEncontrarAnimal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(exit);
            Name = "MenuEncontrarAnimal";
            Text = "MenuEncontrarAnimal";
            Load += MenuEncontrarAnimal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button exit;
        private ListBox listBox1;
    }
}