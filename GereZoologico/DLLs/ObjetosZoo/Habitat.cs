/*
*	<copyright file="ObjetosZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>26/10/2024 16:24:23</date>
*	<description></description>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosZoo
{
    /// <summary>
    /// Representa um habitat de animais, contendo informações sobre a zona e os animais presentes.
    /// Criado por: gonca
    /// Criado em: 26/10/2024 16:24:23
    /// </summary>
    public class Habitat
    {
        #region Attributes

        private ZONA zona;
        private int idhabitat;
        private string nomehabitat;
        public List<Animal> animaishabitat;
        public static List<Habitat> habitats = new List<Habitat>();

        #endregion

        #region Methods

        #region Constructors 

        /// <summary>
        /// Construtor da classe Habitat.
        /// </summary>
        /// <param name="idhabitat">ID único do habitat.</param>
        /// <param name="nomehabitat">Nome do habitat.</param>
        /// <param name="zona">Zona à qual o habitat pertence.</param>
        public Habitat(int idhabitat, string nomehabitat, ZONA zona)
        {
            IdHabitat = idhabitat;
            animaishabitat = new List<Animal>();
            NomeHabitat = nomehabitat;
            Zona = zona;
        }

        #endregion

        #region Properties

       
        public int IdHabitat
        {
            get { return idhabitat; }
            set { idhabitat = value; }
        }

        
        public string NomeHabitat
        {
            get { return nomehabitat; }
            set { nomehabitat = value; }
        }

        
        public ZONA Zona
        {
            get { return zona; }
            set { zona = value; }
        }

        #endregion

        #region Operators 
       
        #endregion

        #region Overrides 

        /// <summary>
        /// Retorna uma representação textual do habitat.
        /// </summary>
        /// <returns>Uma string com as informações do habitat.</returns>
        public override string ToString()
        {
            return String.Format("IDHabitat: {0} Nome Habitat: {1} Zona: {2}", IdHabitat, NomeHabitat, Zona);
        }

        #endregion

        #region OtherMethods

        /// <summary>
        /// Cria um novo habitat e adiciona à lista estática de habitats.
        /// </summary>
        /// <param name="idhabitat">ID único do habitat.</param>
        /// <param name="nomehabitat">Nome do habitat.</param>
        /// <param name="zona">Zona à qual o habitat pertence.</param>
        /// <returns>Retorna true após criar e adicionar o habitat.</returns>
        public static bool CriarHabitat(int idhabitat, string nomehabitat, ZONA zona)
        {
            Habitat habitat = new Habitat(idhabitat, nomehabitat, zona);
            habitats.Add(habitat);
            return true;
        }

        /// <summary>
        /// Mostra as informações do habitat atual.
        /// </summary>
        public void MostraHabitat()
        {
            Console.WriteLine(this.ToString());
        }

        /// <summary>
        /// Mostra todos os habitats existentes.
        /// </summary>
        public static void MostraTodosHabitats()
        {
            foreach (var habitat in habitats)
            {
                habitat.MostraHabitat();
            }
        }

        /// <summary>
        /// Mostra os habitats e seus respectivos animais.
        /// </summary>
        public static void MostraHabitatsAnimais()
        {
            foreach (Habitat habitat in habitats)
            {
                Console.WriteLine(habitat);  // Exibe as informações do habitat

                // Exibe o número de animais no habitat
                Console.WriteLine($"Número de animais no habitat {habitat.NomeHabitat}: {habitat.animaishabitat.Count}");

                if (habitat.animaishabitat.Count > 0)
                {
                    foreach (Animal animal in habitat.animaishabitat)
                    {
                        Console.WriteLine("  - " + animal);  // Exibe cada animal presente no habitat
                    }
                }
                else
                {
                    Console.WriteLine("  Nenhum animal neste habitat.");
                }
            }
        }

        /// <summary>
        /// Adiciona um animal ao habitat.
        /// </summary>
        /// <param name="animal">O animal a ser adicionado.</param>
        /// <returns>Retorna true se o animal foi adicionado com sucesso.</returns>
        public bool AdicionaAnimalHabitat(Animal animal)
        {
            if (animaishabitat.Contains(animal))
            {
                Console.WriteLine("O animal já está no habitat.");
            }
            else
            {
                Console.WriteLine("Animal adicionado ao habitat.");
                animaishabitat.Add(animal);
            }

            return true;
        }

        /// <summary>
        /// Remove um animal do habitat.
        /// </summary>
        /// <param name="animalrecebido">O animal a ser removido.</param>
        /// <returns>Retorna true se o animal foi removido com sucesso; false caso contrário.</returns>
        public bool RemoverAnimalHabitat(Animal animalrecebido)
        {
            Animal? animal = this.animaishabitat.Find(a => a.Id == animalrecebido.Id);
            if (animal != null)
            {
                animaishabitat.Remove(animal);
                Console.WriteLine("Animal retirado do habitat.");
                return true;
            }
            else
            {
                Console.WriteLine("Animal não encontrado no habitat.");
                return false;
            }
        }

        /// <summary>
        /// Verifica se um animal está presente no habitat.
        /// </summary>
        /// <param name="animal">O animal a ser verificado.</param>
        /// <returns>Retorna true se o animal estiver no habitat; false caso contrário.</returns>
        public bool ContemAnimal(Animal animal)
        {
            return animaishabitat.Contains(animal);
        }

        #endregion

        #region Destructor
        #endregion


        #endregion

    }
}
