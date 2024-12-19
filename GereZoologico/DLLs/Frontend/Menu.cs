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
            string caminhodoficheiro = @"C:\Users\gonca\OneDrive\Ambiente de Trabalho\a25455_ProjetoPOO_2024-25\GereZoologico\";
            RegrasAnimais.CarregaAnimais(caminhodoficheiro + "Animais.txt");
            RegrasTiposdeComidas.CarregaTiposdeComida(caminhodoficheiro + "TiposComida.txt");
            RegrasEspetaculos.CarregarEspetaculos(caminhodoficheiro + "Espetaculos-do-mes.txt");
            RegrasUtilizadores.CarregaUtilizadores(caminhodoficheiro + "Utilizadores.txt");
            RegrasBilhetes.CarregarBilhetes(caminhodoficheiro + "Bilhetes.txt");
            RegrasAssistenciasVeterinarias.CarregarAssistenciasVeterinarias(caminhodoficheiro + "AssistenciasVeterinarias.txt");
            RegrasAlimencoes.CarregaAlimentacoes(caminhodoficheiro + "Alimentacoes.txt");
            RegrasLimpezaHabitats.CarregarLimpezasHabitats(caminhodoficheiro + "LimpezasHabitats.txt");

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
            int verificacao = RegrasUtilizadores.Login(usernamemenu.Text, passwordmenu.Text);
            if (verificacao == -3)
            {
                MessageBox.Show("Dados inválidos");
            }
            else if (verificacao == -2)
            {
                MessageBox.Show("Password inválida");
            }
            else if (verificacao == -1)
            {
                MessageBox.Show("Username inválido");
            }
            else
            {
                int tipologado = RegrasUtilizadores.ObterTipoLogado();
                if (tipologado == 1)
                {
                    MenuFuncionario menuFuncionário = new MenuFuncionario();
                    this.Hide();
                    menuFuncionário.ShowDialog();
                    this.Show();
                }
                else if (tipologado == 2)
                {
                    MenuCliente menuCliente = new MenuCliente();
                    this.Hide();
                    menuCliente.ShowDialog();
                    this.Show();
                }

            }

        }
         
        private void exit_Click(object sender, EventArgs e)
        {
            string caminhodoficheiro = @"C:\Users\gonca\OneDrive\Ambiente de Trabalho\a25455_ProjetoPOO_2024-25\GereZoologico\";
            RegrasUtilizadores.GuardarUtilizadores(caminhodoficheiro + "Utilizadores.txt");
            RegrasAlimencoes.GuardarAlimentacoes(caminhodoficheiro + "Alimentacoes.txt");
            RegrasAnimais.GuardaAnimais(caminhodoficheiro + "Animais.txt");
            RegrasBilhetes.GuardarBilhetes(caminhodoficheiro + "Bilhetes.txt");
            RegrasAssistenciasVeterinarias.GuardarAssistenciasVeterinarias(caminhodoficheiro + "AssistenciasVeterinarias.txt");
            RegrasLimpezaHabitats.GuardarLimpezasHabitats(caminhodoficheiro + "LimpezasHabitats.txt");
            this.Close();
        }
    }
}
