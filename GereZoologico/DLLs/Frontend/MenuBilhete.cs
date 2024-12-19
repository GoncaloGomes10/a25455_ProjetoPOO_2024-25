using ObjetosZoo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Frontend
{
    public partial class MenuBilhete : Form
    {
        public MenuBilhete()
        {
            InitializeComponent();
        }

        private void comboBoxZona_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtem o valor selecionado
            var selecionado = (ZONA)comboBoxZona.SelectedItem;
        }

        private void comboBoxTipobilhete_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtem o valor selecionado
            var selecionado = (TIPOBILHETE)comboBoxTipobilhete.SelectedItem;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuBilhete_Load(object sender, EventArgs e)
        {
            comboBoxZona.DataSource = Enum.GetValues(typeof(ZONA));
            comboBoxTipobilhete.DataSource = Enum.GetValues(typeof(TIPOBILHETE));

            comboBoxZona.SelectedIndexChanged += comboBoxZona_SelectedIndexChanged;
            comboBoxTipobilhete.SelectedIndexChanged += comboBoxTipobilhete_SelectedIndexChanged;
        }
    }
}
