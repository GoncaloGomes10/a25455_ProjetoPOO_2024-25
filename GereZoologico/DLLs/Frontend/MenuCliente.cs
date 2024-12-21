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
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void comprarbilhete_Click(object sender, EventArgs e)
        {
            MenuBilhete menuBilhete = new MenuBilhete();
            this.Hide();
            menuBilhete.ShowDialog();
            this.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void encontraranimal_Click(object sender, EventArgs e)
        {
            MenuEncontrarAnimal menuEncontrarAnimal = new MenuEncontrarAnimal();
            this.Hide();
            menuEncontrarAnimal.ShowDialog();
            this.Show();
        }

        private void alterarpassword_Click(object sender, EventArgs e)
        {
            MenuAlterarPassword menuAlterarPassword = new MenuAlterarPassword();
            this.Hide();
            menuAlterarPassword.ShowDialog();
            this.Show();
        }
    }
}
