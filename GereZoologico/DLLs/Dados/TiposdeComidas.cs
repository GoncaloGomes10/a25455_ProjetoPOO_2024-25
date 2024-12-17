/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>07/12/2024 17:52:58</date>
*	<description></description>
*/


using ObjetosZoo;
using System;

namespace Dados
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 07/12/2024 17:52:58
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class TiposdeComidas
    {
        #region Attributes
        private static List<TipodeComida> listatipodecomidas = new List<TipodeComida>();
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        public static List<TipodeComida> Listatipodecomidas
        {
            get { return listatipodecomidas; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Cria um novo tipo de comida e o adiciona à lista de tipos de comida.
        /// </summary>
        /// <param name="nomecomida">Nome do tipo de comida.</param>
        /// <param name="calorias">Quantidade de calorias.</param>
        /// <param name="dieta">Dieta associada ao tipo de comida.</param>
        /// <returns>Retorna true após criar o tipo de comida.</returns>
        public static bool CriarTipoComida(string nomecomida, double calorias, DIETA dieta)
        {
            TipodeComida tipo = new TipodeComida(nomecomida, calorias, dieta);
            listatipodecomidas.Add(tipo);
            return true;
        }

        /// <summary>
        /// Apaga um tipo de comida da lista com base no nome.
        /// </summary>
        /// <param name="nomecomida">Nome do tipo de comida a ser apagado.</param>
        /// <returns>Retorna true se o tipo de comida foi apagado, ou false se não encontrado.</returns>
        public static bool ApagarTipoComida(string nomecomida)
        {
            // Procura o tipo de comida pelo nome
            TipodeComida? tipo = listatipodecomidas.Find(tipo => tipo.NomeComida == nomecomida);
            if (tipo != null)
            {
                listatipodecomidas.Remove(tipo);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Carrega informações dos tipos de comida de um ficheiro para a lista de tipos de comida.
        /// </summary>
        /// <param name="filePath">Caminho do ficheiro com informações dos tipos de comida.</param>
        /// <returns>Retorna true se o carregamento for bem-sucedido.</returns>
        /// <exception cref="FileNotFoundException">Lançada se o ficheiro não for encontrado.</exception>
        /// <exception cref="Exception">Lançada se o formato de uma linha do ficheiro estiver incorreto.</exception>
        public static bool CarregaTiposdeComida(string filePath)
        {
           
            // Lê todas as linhas do ficheiro
            string[] linhas = File.ReadAllLines(filePath);

            // Para cada linha no ficheiro, processa o conteúdo
            foreach (string linha in linhas)
            {
                // Divide a linha em partes
                string[] partes = linha.Split(';');

                // Verifica se há exatamente 3 partes
                if (partes.Length == 3)
                {
                    string nomeComida = partes[0];
                    double calorias = double.Parse(partes[1]);
                    DIETA dieta = (DIETA)Enum.Parse(typeof(DIETA), partes[2]);

                    // Cria o objeto TipodeComida e adiciona-o à lista de tipos de comida pela função
                    TiposdeComidas.CriarTipoComida(nomeComida, calorias, dieta);
                }
                else
                {
                    throw new Exception("Formato da linha inválido.");
                }
            }
            return true;
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}