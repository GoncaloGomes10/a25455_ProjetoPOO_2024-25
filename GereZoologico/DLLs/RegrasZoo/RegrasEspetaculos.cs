/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>16/12/2024 15:33:44</date>
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
    /// Created on: 16/12/2024 15:33:44
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasEspetaculos
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
        /// Cria um novo espetáculo com os dados fornecidos.
        /// </summary>
        /// <param name="id">O identificador único do espetáculo.</param>
        /// <param name="tipoespetaculo">O tipo do espetáculo (por exemplo, musical, teatral, etc.).</param>
        /// <param name="nome">O nome do espetáculo.</param>
        /// <param name="horario">A data e hora em que o espetáculo será realizado.</param>
        /// <returns>
        /// Retorna True se o espetáculo for criado com sucesso; 
        /// False se os parâmetros forem inválidos (ID <= 0, nome vazio ou nulo, ou horário inválido).
        /// </returns>
        public static bool CriarEspetaculo(int id, TIPOESPETACULO tipoespetaculo, string nome, DateTime horario)
        {
            if(id <=0 && !string.IsNullOrEmpty(nome) && horario == null) return false;
            return Espetaculos.CriarEspetaculo(id, tipoespetaculo, nome, horario);
        }
        /// <summary>
        /// Retorna uma lista de todos os espetáculos disponíveis.
        /// </summary>
        /// <returns>Uma lista contendo todos os objetos do tipo Espetáculo registrados.</returns>
        public static List<Espetaculo> MostrarTodosEspetaculos()
        {
            return Espetaculos.Listaespetaculos;
        }
        /// <summary>
        /// Apaga um espetáculo específico do sistema.
        /// </summary>
        /// <param name="espetaculorecebido">O objeto do tipo Espetáculo a ser apagado.</param>
        /// <returns>
        /// Retorna True se o espetáculo for apagado com sucesso;
        /// False se o objeto fornecido for nulo.
        /// </returns>
        public static bool ApagarEspetaculo(Espetaculo espetaculorecebido)
        {
            if(espetaculorecebido == null) return false;
            return Espetaculos.ApagarEspetaculo(espetaculorecebido);
        }

        /// <summary>
        /// Carrega informações dos espetáculos de um ficheiro para a lista de espetáculos.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro com informações dos espetáculos.</param>
        /// <returns>Retorna true se o carregamento for bem-sucedido.</returns>
        /// <exception cref="FileNotFoundException">Lançada se o ficheiro não for encontrado.</exception>
        /// <exception cref="Exception">Lançada se o formato de uma linha do ficheiro estiver incorreto.</exception>
        public static bool CarregarEspetaculos(string filePath)
        {
            // Verifica se o ficheiro existe
            if (File.Exists(filePath))
            {
               Espetaculos.CarregarEspetaculos(filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }
            return true;
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}