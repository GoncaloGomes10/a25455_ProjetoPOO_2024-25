using RegrasZoo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class MenuAlterarPassword : Form
    {
        public MenuAlterarPassword()
        {
            InitializeComponent();
        }

        private void alterarpassword_Click(object sender, EventArgs e)
        {
            int sucesso = RegrasUtilizadores.AlterarPassword(textBoxpasswordantiga.Text, textBoxpasswordnova.Text);
            if (sucesso == -3)
            {
                MessageBox.Show("Dados inválidos");
            }
            else if (sucesso == -1)
            {
                MessageBox.Show("Passoword incorreta!");
            }
            else if (sucesso == -2)
            {
                MessageBox.Show("Ninguem logado");
            }
            else MessageBox.Show("Passoword alterada com sucesso!");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
