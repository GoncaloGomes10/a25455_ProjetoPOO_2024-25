using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetosZoo;
using RegrasZoo;

namespace Frontend
{
    public partial class MenuCriarContaCliente : Form
    {
        public MenuCriarContaCliente()
        {
            InitializeComponent();
        }

        private void criarconta_Click(object sender, EventArgs e)
        {
            int verificacao = RegrasUtilizadores.Registo(username.Text, password.Text, email.Text, nome.Text, nif.Text,2);
            if (verificacao == -2)
            {
                MessageBox.Show("Dados inválidos");
            }
            else if (verificacao == -1)
            {
                MessageBox.Show("Username já existente");
            }
            else MessageBox.Show("Sucesso");
            this.Close();
        }
    }
}
