using Frontend;
using System.Windows.Forms;
using Dados;
using ObjetosZoo;
using RegrasZoo;


namespace Programa
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            //Criar Habitats
            Habitats.CriarHabitat(1, "Leões", ZONA.Savana);
            Habitats.CriarHabitat(2, "Elefantes", ZONA.Savana);
            Habitats.CriarHabitat(3, "Camelos", ZONA.Deserto);
            Habitats.CriarHabitat(4, "Dromedários", ZONA.Deserto);
            Habitats.CriarHabitat(5, "Golfinhos", ZONA.Aquática);
            Habitats.CriarHabitat(6, "Tubarões Tigres", ZONA.Aquática);
            Habitats.CriarHabitat(7, "Gorilas", ZONA.Floresta);
            Habitats.CriarHabitat(8, "Pandas Vermelhos", ZONA.Floresta);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
