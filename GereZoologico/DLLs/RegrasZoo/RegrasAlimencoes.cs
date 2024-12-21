/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>12/12/2024 21:57:52</date>
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
    /// Created on: 12/12/2024 21:57:52
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasAlimencoes
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
        /// Registra uma nova alimentação para um animal específico, com a quantidade e o tipo de comida fornecido.
        /// </summary>
        /// <param name="animal">O animal que será alimentado.</param>
        /// <param name="tempoAlimentacao">A data e hora em que a alimentação ocorreu.</param>
        /// <param name="quantidade">A quantidade de comida fornecida ao animal.</param>
        /// <param name="tipocomida">O tipo de comida que foi dada ao animal.</param>
        /// <returns>Retorna verdadeiro se a alimentação foi registrada com sucesso, caso contrário, retorna falso.</returns>
        public static bool RegistraAlimentacao(Animal animal, DateTime tempoAlimentacao, double quantidade, TipodeComida tipocomida)
        {
            if (animal == null && tempoAlimentacao == null && quantidade <= 0 && tipocomida == null) return false;
            return Alimentacoes.RegistraAlimentacao(animal, tempoAlimentacao, quantidade, tipocomida);
        }
        /// <summary>
        /// Exibe todas as alimentações registradas.
        /// </summary>
        /// <returns>Uma lista contendo todas as alimentações registradas.</returns>
        public static List<Alimentacao> MostraTodasAlimentacoes()
        {
            return Alimentacoes.Listaalimentacoes;
        }
        /// <summary>
        /// Apaga uma alimentação específica, identificada pelo seu ID.
        /// </summary>
        /// <param name="id">ID da alimentação a ser apagada.</param>
        /// <returns>Retorna verdadeiro se a alimentação foi apagada com sucesso, caso contrário, retorna falso.</returns>
        public static bool ApagarAlimentacao(int id)
        {
            if (id <= 0) return false;
            return Alimentacoes.ApagarAlimentacao(id);
        }
        /// <summary>
        /// Apaga todas as alimentações associadas a um animal específico, identificado pelo seu ID.
        /// </summary>
        /// <param name="id">ID do animal cujas alimentações serão apagadas.</param>
        /// <returns>Retorna verdadeiro se as alimentações foram apagadas com sucesso, caso contrário, retorna falso.</returns>
        public static bool ApagarTodasAlimentacoees(int id)
        {
            if(id <= 0) return false;
            return Alimentacoes.ApagarTodasAlimentacoes(id);
        }
        /// <summary>
        /// Edita a quantidade de uma alimentação específica, identificada pelo seu ID.
        /// </summary>
        /// <param name="id">ID da alimentação a ser editada.</param>
        /// <param name="novaQuantidade">Nova quantidade de comida para a alimentação.</param>
        /// <returns>Retorna verdadeiro se a alimentação foi editada com sucesso, caso contrário, retorna falso.</returns>
        public static bool EditarAlimentacao(int id, double novaQuantidade)
        {
            if (id <= 0 && novaQuantidade <= 0) return false;
            return Alimentacoes.EditarAlimentacao(id, novaQuantidade);
        }
        /// <summary>
        /// Carrega as alimentações de um arquivo especificado e as registra.
        /// </summary>
        /// <param name="filePath">Caminho do arquivo que contém os dados das alimentações.</param>
        /// <returns>Retorna verdadeiro se as alimentações foram carregadas com sucesso.</returns>
        /// <exception cref="FileNotFoundException">Lança uma exceção se o arquivo não for encontrado.</exception>
        public static bool CarregaAlimentacoes(string filePath)
        {
            if (File.Exists(filePath))
            {
                Alimentacoes.CarregaAlimentacoes(filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }

            return true;
        }
        /// <summary>
        /// Guarda as alimentações atuais num arquivo especificado.
        /// </summary>
        /// <param name="filePath">Caminho do arquivo onde as alimentações serão armazenadas.</param>
        /// <returns>Retorna verdadeiro se as alimentações foram salvas com sucesso, caso contrário, retorna falso.</returns>
        public static bool GuardarAlimentacoes(string filePath)
        {
            if(File.Exists(filePath)) return Alimentacoes.GuardarAlimentacoes(filePath);
            return false;
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}