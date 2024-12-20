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
    public partial class MenuFuncionario : Form
    {
        public MenuFuncionario()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            RegrasUtilizadores.Logout();
            MessageBox.Show("Logout com sucesso");
            this.Close();
        }

        private void mostrarlistas_Click(object sender, EventArgs e)
        {
            MenuMostrar menuMostrar = new MenuMostrar();
            this.Hide();
            menuMostrar.ShowDialog();
            this.Show();
        }

        private void removerdalista_Click(object sender, EventArgs e)
        {
            MenuRemover menuRemover = new MenuRemover();
            this.Hide();
            menuRemover.ShowDialog();
            this.Show();
        }

        private void encontraranimal_Click(object sender, EventArgs e)
        {
            MenuEncontrarAnimal menuEncontrarAnimal = new MenuEncontrarAnimal();
            this.Hide();
            menuEncontrarAnimal.ShowDialog();
            this.Show();
        }

        private void direcionacriarcontafunc_Click(object sender, EventArgs e)
        {
            MenuCriarContaFuncionario menuCriarContaFuncionario = new MenuCriarContaFuncionario();
            menuCriarContaFuncionario.Show();
        }

        private void adicionaranimal_Click(object sender, EventArgs e)
        {
            MenuAdicionarAnimal menuAdicionarAnimal = new MenuAdicionarAnimal();
            this.Hide();
            menuAdicionarAnimal.ShowDialog();
            this.Show();
        }
    }
}
