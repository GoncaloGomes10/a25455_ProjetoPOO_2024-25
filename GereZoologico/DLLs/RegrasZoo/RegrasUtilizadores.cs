/*
*	<copyright file="RegrasZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>12/12/2024 22:22:01</date>
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
    /// Created on: 12/12/2024 22:22:01
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class RegrasUtilizadores
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
        /// Regista um novo utilizador no sistema, verificando os dados fornecidos.
        /// </summary>
        /// <param name="username">O nome de utilizador.</param>
        /// <param name="password">A palavra-passe do utilizador.</param>
        /// <param name="email">O e-mail do utilizador.</param>
        /// <param name="nome">O nome completo do utilizador.</param>
        /// <param name="nif">O número de identificação fiscal (NIF) do utilizador.</param>
        /// <param name="tipouser">O tipo de utilizador (1 ou 2).</param>
        /// <returns>Um código indicando o sucesso ou erro do registo.</returns>
        public static int Registo(string username, string password, string email, string nome, string nif, int tipouser)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(nif) || tipouser <= 0 && tipouser > 2) return -2;
            return Utilizadores.Registo(username,password, email, nome, nif, tipouser);
        }
        /// <summary>
        /// Loga um utilizador com base no nome de utilizador e palavra-passe.
        /// </summary>
        /// <param name="username">O nome de utilizador.</param>
        /// <param name="password">A palavra-passe do utilizador.</param>
        /// <returns>Um código indicando o sucesso ou erro do login.</returns>
        public static int Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) return -3;
            return Utilizadores.Login(username,password);
        }
        /// <summary>
        /// Remove um utilizador existente com base no seu identificador único.
        /// </summary>
        /// <param name="id">O identificador único do utilizador a remover.</param>
        /// <returns>Um código indicando o sucesso ou erro da remoção.</returns>
        public static int RemoverUtilizador(int id)
        {
            if (id < 0) return -2;
            return Utilizadores.RemoverUtilizador(id);
        }
        /// <summary>
        /// Obtém a lista de todos os utilizadores registados no sistema.
        /// </summary>
        /// <returns>Uma lista de objetos do tipo Utilizador.</returns>
        public static List<Utilizador> MostrarTodosUtilizadores()
        {
            return Utilizadores.Listautilizadores;
        }
        /// <summary>
        /// Altera a palavra-passe de um utilizador após verificar a palavra-passe antiga.
        /// </summary>
        /// <param name="passwordantiga">A palavra-passe atual do utilizador.</param>
        /// <param name="passwordnova">A nova palavra-passe para o utilizador.</param>
        /// <returns>Um código indicando o sucesso ou erro da alteração.</returns>
        public static int AlterarPassword(string passwordantiga, string passwordnova)
        {
            if (string.IsNullOrEmpty(passwordantiga) || string.IsNullOrEmpty(passwordnova)) return -3; // passwords invalidas
            return Utilizadores.AlterarPassword(passwordantiga, passwordnova);
        }
        /// <summary>
        /// Verifica se o utilizador está autenticado no sistema.
        /// </summary>
        /// <returns>O objeto Utilizador do utilizador autenticado, ou null se não estiver autenticado.</returns>
        public static Utilizador? VerificaAutenticação()
        {
            return Utilizadores.VerificaAutenticação();
        }
        /// <summary>
        /// Termina a sessão do utilizador autenticado.
        /// </summary>
        /// <returns>True se o logout for bem-sucedido; caso contrário, False.</returns>
        public static bool Logout()
        {
            return Utilizadores.Logout();
        }
        /// <summary>
        /// Obtém o tipo de utilizador atualmente autenticado.
        /// </summary>
        /// <returns>O tipo de utilizador (1 ou 2), ou -1 se não houver utilizador autenticado.</returns>
        public static int ObterTipoLogado()
        {
            if (Utilizadores.TipoLogado == null) return -1;
            return (int)Utilizadores.TipoLogado;
        }
        /// <summary>
        /// Obtém o utilizador atualmente autenticado.
        /// </summary>
        /// <returns>O objeto Utilizador do utilizador autenticado, ou null se não houver um utilizador autenticado.</returns>

        public static Utilizador ObterUserLogado() 
        {
            if (Utilizadores.UserLogado == null) return null;
            return (Utilizador)Utilizadores.UserLogado;
        }
        /// <summary>
        /// Carrega os dados de utilizadores a partir de um ficheiro especificado.
        /// </summary>
        /// <param name="filePath">O caminho para o ficheiro de dados de utilizadores.</param>
        /// <returns>True se o carregamento for bem-sucedido.</returns>
        /// <exception cref="FileNotFoundException">Se o ficheiro especificado não for encontrado.</exception>
        public static bool CarregaUtilizadores(string filePath)
        {
            if (File.Exists(filePath))
            {
                Utilizadores.CarregaUtilizadores(filePath);
            }
            else
            {
                throw new FileNotFoundException();
            }

            return true;
        }
        /// <summary>
        /// Guarda os dados de utilizadores num ficheiro especificado.
        /// </summary>
        /// <param name="filePath">O caminho para o ficheiro onde os dados serão guardados.</param>
        /// <returns>True se a operação de guardar for bem-sucedida.</returns>
        /// <exception cref="FileNotFoundException">Se o ficheiro especificado não for encontrado.</exception>
        public static bool GuardarUtilizadores(string filePath)
        {
            if (File.Exists(filePath))
            {
                Utilizadores.GuardarUtilizadores(filePath);
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