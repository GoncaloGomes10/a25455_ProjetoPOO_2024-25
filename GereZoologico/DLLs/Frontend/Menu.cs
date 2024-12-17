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
    public partial class Menu : Form
    {
        public Menu()
        {

            InitializeComponent();

        }

        private void direcionarmenucriarconta_Click(object sender, EventArgs e)
        {

            MenuCriarContaCliente menuCriarContaCliente = new MenuCriarContaCliente();
            menuCriarContaCliente.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void direcionarmenu_Click(object sender, EventArgs e)
        {

        }
    }
}
