/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>07/12/2024 17:51:07</date>
*	<description></description>
*/


using ObjetosZoo;
using System;

namespace Dados
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 07/12/2024 17:51:07
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Habitats
    {
        #region Attributes
        private static List<Habitat> listahabitats = new List<Habitat>();
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        public static List<Habitat> Listahabitats
        {
            get { return listahabitats; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides
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
            listahabitats.Add(habitat);
            return true;
        }


        /// <summary>
        /// Adiciona um animal a um habitat específico.
        /// </summary>
        /// <param name="idhabitat">O ID do habitat onde o animal será adicionado.</param>
        /// <param name="animal">O objeto do tipo Animal a ser adicionado.</param>
        /// <returns>True se o animal for adicionado com sucesso; False se o habitat não for encontrado.</returns>
        public static bool AdicionarAnimal(int idhabitat, Animal animal)
        {
            var habitat = listahabitats.Find(h => h.IdHabitat == idhabitat);
            if (habitat != null)
            {
                habitat.ListaAnimaisHabitat.Add(animal);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Remove um animal de um habitat específico.
        /// </summary>
        /// <param name="idhabitat">O ID do habitat de onde o animal será removido.</param>
        /// <param name="idAnimal">O ID do animal a ser removido.</param>
        /// <returns>
        /// 1 se o animal for removido com sucesso, 
        /// -1 se o animal não for encontrado no habitat, 
        /// -2 se o habitat não for encontrado.
        /// </returns>
        public static int RemoverAnimal(int idhabitat, int idAnimal)
        {
            var habitat = listahabitats.Find(h => h.IdHabitat == idhabitat);
            if (habitat != null)
            {
                var animal = habitat.ListaAnimaisHabitat.Find(a => a.Id == idAnimal);
                if (animal != null)
                {
                    habitat.ListaAnimaisHabitat.Remove(animal);
                    return 1;
                }
                return -1;
            }
            return -2;
        }

        /// <summary>
        /// Mostra todos os animais presentes num habitat específico.
        /// </summary>
        /// <param name="idhabitat">O ID do habitat cujos animais serão listados.</param>
        /// <returns>
        /// Uma lista de objetos do tipo Animal se o habitat for encontrado; 
        /// Null se o habitat não for encontrado.
        /// </returns>
        public static List<Animal>? MostrarAnimais(int idhabitat)
        {
            var habitat = listahabitats.Find(h => h.IdHabitat == idhabitat);
            if (habitat != null) return habitat.ListaAnimaisHabitat;
            return null;

        }
        /// <summary>
        /// Obtém o ID do habitat onde um animal específico está localizado.
        /// </summary>
        /// <param name="animal">O objeto do tipo Animal para o qual se pretende encontrar o habitat.</param>
        /// <returns>O ID do habitat onde o animal está localizado.</returns>
        /// <exception cref="Exception">Lançada se nenhum habitat contendo o animal for encontrado.</exception>
        public static int ObterIdHabitat(Animal animal)
        {
            foreach (var habitat in Habitats.Listahabitats)
            {
                if (habitat.ContemAnimal(animal))
                {
                    return habitat.IdHabitat; 
                }
            }
            throw new Exception("Habitat não encontrado para o animal especificado.");
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}