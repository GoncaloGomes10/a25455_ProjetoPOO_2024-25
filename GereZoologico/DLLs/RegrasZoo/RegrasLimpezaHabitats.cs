/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>16/12/2024 16:13:41</date>
*	<description></description>
*/


using System;
using Dados;
using ObjetosZoo;

namespace RegrasZoo
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 16/12/2024 16:13:41
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasLimpezaHabitats
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
        /// Regista a limpeza de um habitat, associando a hora da limpeza fornecida.
        /// </summary>
        /// <param name="habitat">O habitat a ser registado como limpo.</param>
        /// <param name="horalimpeza">A data e hora da limpeza.</param>
        /// <returns>True se o registo for realizado com sucesso; False caso contrário.</returns>
        public static bool RegistarHabitatLimpo(Habitat habitat, DateTime horalimpeza)
        {
            if (habitat == null) return false;
            return LimpezaHabitats.RegistarHabitatLimpo(habitat, horalimpeza);
        }

        /// <summary>
        /// Obtém uma lista de todos os registos de limpeza de habitats.
        /// </summary>
        /// <returns>Uma lista de objetos do tipo LimpezaHabitat.</returns>
        public static List<LimpezaHabitat> MostraTodosHabitatsLimpos()
        {
            return LimpezaHabitats.Listalimpezahabitats;
        }
        /// <summary>
        /// Apaga todos os registos de limpeza associados a um habitat específico.
        /// </summary>
        /// <param name="habitat">O habitat cujos registos de limpeza serão apagados.</param>
        /// <returns>True se os registos forem apagados com sucesso; False caso contrário.</returns>
        public static bool ApagarTodoRegistoLimpezaHabitat(Habitat habitat)
        {
            if (habitat == null) return false;
            return LimpezaHabitats.ApagarTodoRegistoLimpezaHabitat(habitat);
        }
        /// <summary>
        /// Apaga todos os registos de limpeza existentes na aplicação.
        /// </summary>
        /// <returns>True se os registos forem apagados com sucesso; False caso contrário.</returns>
        public static bool ApagarTodosRegistosdeLimpeza()
        {
            return LimpezaHabitats.ApagarTodosRegistosdeLimpeza();
        }
        /// <summary>
        /// Apaga um registo específico de limpeza com base no ID do habitat.
        /// </summary>
        /// <param name="idHabitat">O ID do habitat cujo registo de limpeza será apagado.</param>
        /// <returns>1 se o registo for apagado com sucesso; -2 se o ID for inválido.</returns>
        public static int ApagarRegistoLimpeza(int idHabitat)
        {
           if(idHabitat < 0 ) return -2;
           return LimpezaHabitats.ApagarRegistoLimpeza(idHabitat);
        }

        /// <summary>
        /// Carrega os registos de limpezas de habitats a partir de um ficheiro especificado.
        /// </summary>
        /// <param name="filePath">O caminho para o ficheiro de dados das limpezas.</param>
        /// <returns>True se os dados forem carregados com sucesso.</returns>
        /// <exception cref="FileNotFoundException">Lançada se o ficheiro especificado não for encontrado.</exception>
        public static bool CarregarLimpezasHabitats(string filePath)
        {
            if (File.Exists(filePath))
            {
                LimpezaHabitats.CarregarLimpezasHabitats(filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }

            return true;
        }
        /// <summary>
        /// Guarda os registos de limpezas de habitats num ficheiro especificado.
        /// </summary>
        /// <param name="filePath">O caminho para o ficheiro onde os dados serão guardados.</param>
        /// <returns>False se o ficheiro especificado já existir; True caso contrário.</returns>
        public static bool GuardarLimpezasHabitats(string filePath)
        {
            if (File.Exists(filePath)) LimpezaHabitats.GuardarLimpezasHabitats(filePath);
            return false;
        }
        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}