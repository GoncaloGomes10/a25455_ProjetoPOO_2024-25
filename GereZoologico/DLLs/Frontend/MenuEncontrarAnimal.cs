using Dados;
using ObjetosZoo;
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
    public partial class MenuEncontrarAnimal : Form
    {
        public MenuEncontrarAnimal()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MenuEncontrarAnimal_Load(object sender, EventArgs e)
        {
            int verificacao = RegrasUtilizadores.ObterTipoLogado();
            if(verificacao == 1)
            {
                listBox1.DataSource = RegrasAnimais.MostraAnimais();
                listBox1.DisplayMember = "Display";
            }
            else
            {
                listBox1.DataSource = RegrasAnimais.MostraAnimais();
                listBox1.DisplayMember = "Display1";
            }

        }
    }
}
