namespace Frontend
{
    partial class MenuFuncionario
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
            logout = new Button();
            encontraranimal = new Button();
            direcionacriarcontafunc = new Button();
            label1 = new Label();
            adicionaranimal = new Button();
            adicionarregistoassistencia = new Button();
            adicionarregistoalimentacao = new Button();
            registolimpezahabitat = new Button();
            mostrarlistas = new Button();
            removerutilizador = new Button();
            removerdalista = new Button();
            SuspendLayout();
            // 
            // logout
            // 
            logout.Location = new Point(12, 608);
            logout.Name = "logout";
            logout.Size = new Size(94, 29);
            logout.TabIndex = 0;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // encontraranimal
            // 
            encontraranimal.Location = new Point(102, 294);
            encontraranimal.Name = "encontraranimal";
            encontraranimal.Size = new Size(170, 29);
            encontraranimal.TabIndex = 1;
            encontraranimal.Text = "Encontrar Animal";
            encontraranimal.UseVisualStyleBackColor = true;
            // 
            // direcionacriarcontafunc
            // 
            direcionacriarcontafunc.Location = new Point(1082, 57);
            direcionacriarcontafunc.Name = "direcionacriarcontafunc";
            direcionacriarcontafunc.Size = new Size(213, 29);
            direcionacriarcontafunc.TabIndex = 2;
            direcionacriarcontafunc.Text = "Criar Conta";
            direcionacriarcontafunc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1082, 34);
            label1.Name = "label1";
            label1.Size = new Size(213, 20);
            label1.TabIndex = 5;
            label1.Text = "Criar Conta de um Funcionário:";
            // 
            // adicionaranimal
            // 
            adicionaranimal.Location = new Point(102, 241);
            adicionaranimal.Name = "adicionaranimal";
            adicionaranimal.Size = new Size(170, 29);
            adicionaranimal.TabIndex = 6;
            adicionaranimal.Text = "Adicionar Animal";
            adicionaranimal.UseVisualStyleBackColor = true;
            // 
            // adicionarregistoassistencia
            // 
            adicionarregistoassistencia.Location = new Point(454, 241);
            adicionarregistoassistencia.Name = "adicionarregistoassistencia";
            adicionarregistoassistencia.Size = new Size(171, 29);
            adicionarregistoassistencia.TabIndex = 11;
            adicionarregistoassistencia.Text = "Adicionar Registo";
            adicionarregistoassistencia.UseVisualStyleBackColor = true;
            // 
            // adicionarregistoalimentacao
            // 
            adicionarregistoalimentacao.Location = new Point(278, 241);
            adicionarregistoalimentacao.Name = "adicionarregistoalimentacao";
            adicionarregistoalimentacao.Size = new Size(170, 29);
            adicionarregistoalimentacao.TabIndex = 15;
            adicionarregistoalimentacao.Text = "Adicionar Registo";
            adicionarregistoalimentacao.UseVisualStyleBackColor = true;
            // 
            // registolimpezahabitat
            // 
            registolimpezahabitat.Location = new Point(631, 241);
            registolimpezahabitat.Name = "registolimpezahabitat";
            registolimpezahabitat.Size = new Size(171, 29);
            registolimpezahabitat.TabIndex = 17;
            registolimpezahabitat.Text = "Registo Limpeza";
            registolimpezahabitat.UseVisualStyleBackColor = true;
            // 
            // mostrarlistas
            // 
            mostrarlistas.Location = new Point(102, 105);
            mostrarlistas.Name = "mostrarlistas";
            mostrarlistas.Size = new Size(182, 29);
            mostrarlistas.TabIndex = 22;
            mostrarlistas.Text = "Mostrar Listas";
            mostrarlistas.UseVisualStyleBackColor = true;
            mostrarlistas.Click += mostrarlistas_Click;
            // 
            // removerutilizador
            // 
            removerutilizador.Location = new Point(1082, 105);
            removerutilizador.Name = "removerutilizador";
            removerutilizador.Size = new Size(213, 29);
            removerutilizador.TabIndex = 23;
            removerutilizador.Text = "Remover Utilizador";
            removerutilizador.UseVisualStyleBackColor = true;
            // 
            // removerdalista
            // 
            removerdalista.Location = new Point(102, 70);
            removerdalista.Name = "removerdalista";
            removerdalista.Size = new Size(182, 29);
            removerdalista.TabIndex = 24;
            removerdalista.Text = "Remover da lista";
            removerdalista.UseVisualStyleBackColor = true;
            removerdalista.Click += removerdalista_Click;
            // 
            // MenuFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 649);
            Controls.Add(removerdalista);
            Controls.Add(removerutilizador);
            Controls.Add(mostrarlistas);
            Controls.Add(registolimpezahabitat);
            Controls.Add(adicionarregistoalimentacao);
            Controls.Add(adicionarregistoassistencia);
            Controls.Add(adicionaranimal);
            Controls.Add(label1);
            Controls.Add(direcionacriarcontafunc);
            Controls.Add(encontraranimal);
            Controls.Add(logout);
            Name = "MenuFuncionario";
            Text = "MenuFuncionário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logout;
        private Button encontraranimal;
        private Button direcionacriarcontafunc;
        private Label label1;
        private Button adicionaranimal;
        private Button adicionarregistoassistencia;
        private Button adicionarregistoalimentacao;
        private Button registolimpezahabitat;
        private Button mostrarlistas;
        private Button removerutilizador;
        private Button removerdalista;
    }
}