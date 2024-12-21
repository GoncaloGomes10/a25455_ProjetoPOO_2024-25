/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>16/12/2024 15:50:56</date>
*	<description></description>
*/


using Dados;
using ObjetosZoo;
using System;

namespace RegrasZoo
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 16/12/2024 15:50:56
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasHabitats
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Cria um novo habitat com os dados fornecidos.
        /// </summary>
        /// <param name="idhabitat">O ID do habitat a ser criado.</param>
        /// <param name="nomehabitat">O nome do habitat.</param>
        /// <param name="zona">A zona onde o habitat será localizado.</param>
        /// <returns>True se o habitat for criado com sucesso; False caso contrário.</returns>
        public static bool CriarHabitat(int idhabitat, string nomehabitat, ZONA zona)
        {
            if(idhabitat < 0 && !string.IsNullOrEmpty(nomehabitat)) return false;
            return Habitats.CriarHabitat(idhabitat, nomehabitat, zona);
        }
        /// <summary>
        /// Retorna a lista de todos os habitats existentes.
        /// </summary>
        /// <returns>Uma lista contendo todos os habitats registrados.</returns>
        public static List<Habitat> MostraHabitats()
        {
            return Habitats.Listahabitats;
        }
        /// <summary>
        /// Adiciona um animal a um habitat específico.
        /// </summary>
        /// <param name="idhabitat">O ID do habitat onde o animal será adicionado.</param>
        /// <param name="animal">O objeto do tipo Animal a ser adicionado ao habitat.</param>
        /// <returns>True se o animal for adicionado com sucesso; False se o habitat ou o animal forem inválidos.</returns>
        public static bool AdicionarAnimal(int idhabitat, Animal animal)
        {
            if(idhabitat < 0 &&  animal == null) return false;
            return Habitats.AdicionarAnimal(idhabitat, animal);
        }
        /// <summary>
        /// Remove um animal de um habitat específico.
        /// </summary>
        /// <param name="idhabitat">O ID do habitat de onde o animal será removido.</param>
        /// <param name="idAnimal">O ID do animal a ser removido.</param>
        /// <returns>
        /// Retorna:
        /// - 1 se o animal for removido com sucesso;
        /// - -3 se os IDs do habitat ou do animal forem inválidos;
        /// - Outros valores específicos definidos na implementação de `Habitats.RemoverAnimal`.
        /// </returns>
        public static int RemoverAnimal(int idhabitat, int idAnimal)
        {
            if (idhabitat < 0 && idAnimal < 0) return -3;
            return Habitats.RemoverAnimal(idhabitat, idAnimal);
        }
        /// <summary>
        /// Mostra todos os animais presentes em um habitat específico.
        /// </summary>
        /// <param name="idhabitat">O ID do habitat cujos animais serão listados.</param>
        /// <returns>
        /// Uma lista de objetos do tipo Animal se o habitat for encontrado e válido;
        /// Null se o ID do habitat for inválido.
        /// </returns>
        public static List<Animal>? MostrarAnimais(int idhabitat)
        {
            if(idhabitat < 0) return null;
            return Habitats.MostrarAnimais(idhabitat);
        }
        /// <summary>
        /// Obtém o ID do habitat onde um animal específico está localizado.
        /// </summary>
        /// <param name="animal">O objeto do tipo Animal para o qual se deseja encontrar o habitat.</param>
        /// <returns>
        /// Retorna o ID do habitat se o animal for encontrado;
        /// Retorna -1 se o objeto Animal for nulo.
        /// </returns>
        public static int ObterIdHabitat(Animal animal)
        {
            if (animal == null) return -1;
            return Habitats.ObterIdHabitat(animal);
        }
        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}