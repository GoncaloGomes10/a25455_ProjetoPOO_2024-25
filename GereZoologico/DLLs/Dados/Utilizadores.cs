/*
*	<copyright file="Dados" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>12/12/2024 22:21:38</date>
*	<description></description>
*/


using ObjetosZoo;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Dados
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 12/12/2024 22:21:38
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Utilizadores
    {
        #region Attributes
        private static Utilizador? userlogado = null;
        private static int? tipologado = null;
        private static List<Utilizador> listautilizadores = new List<Utilizador>();
        #endregion

        #region Methods

        #region Constructors
        #endregion

        #region Properties
        public static List<Utilizador> Listautilizadores
        {
            get { return listautilizadores; }
        }
        
        public static int? TipoLogado
        {
            get { return tipologado; }
        }

        public static Utilizador? UserLogado
        {
            get { return userlogado; }
        }
        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        /// <summary>
        /// Carrega os dados de utilizadores a partir de um ficheiro especificado. 
        /// Cada linha do ficheiro deve conter os dados de um utilizador separados por ';'.
        /// </summary>
        /// <param name="filePath">O caminho para o ficheiro de dados de utilizadores.</param>
        /// <returns>True se o carregamento for bem-sucedido.</returns>
        /// <exception cref="Exception">Lançada se uma linha no ficheiro tiver um formato inválido.</exception>

        public static bool CarregaUtilizadores(string filePath)
        {
            // Lê todas as linhas do ficheiro
            string[] linhas = File.ReadAllLines(filePath);

            // Para cada linha no ficheiro, processa o conteúdo
            foreach (string linha in linhas)
            {
                // Divide a linha em partes
                string[] partes = linha.Split(';');

                // Verifica se há exatamente 6 partes
                if (partes.Length == 6)
                {
                    string username = partes[0];
                    string password = partes[1];
                    string email = partes[2];
                    string nome = partes[3];
                    string nif = partes[4];
                    int tipouser = int.Parse(partes[5]);

                    Utilizadores.Registo(username, password, email, nome, nif, tipouser);
                }
                else
                {
                    throw new Exception();
                }
            }

            return true;
        }
        /// <summary>
        /// Guarda os dados de todos os utilizadores registados num ficheiro especificado.
        /// </summary>
        /// <param name="filePath">O caminho para o ficheiro onde os dados serão guardados.</param>
        /// <returns>True se a operação de guardar for bem-sucedida.</returns>
        public static bool GuardarUtilizadores(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath)) //Open the file to write
            {
                foreach (Utilizador utilizador in listautilizadores)
                {
                    writer.WriteLine($"{utilizador.Username};{utilizador.Password};{utilizador.Email};{utilizador.Nome};{utilizador.NIF};{utilizador.Tipo}");
                }
            }
            return true;
        }


        /// <summary>
        /// Regista um novo utilizador no sistema, verificando se o nome de utilizador já existe.
        /// Cria um utilizador do tipo Funcionário ou Cliente consoante o valor de "tipouser".
        /// </summary>
        /// <param name="username">O nome de utilizador.</param>
        /// <param name="password">A palavra-passe do utilizador.</param>
        /// <param name="email">O e-mail do utilizador.</param>
        /// <param name="nome">O nome completo do utilizador.</param>
        /// <param name="nif">O número de identificação fiscal (NIF) do utilizador.</param>
        /// <param name="tipouser">O tipo de utilizador (1 para Funcionário, 2 para Cliente).</param>
        /// <returns>1 se o registo for bem-sucedido, -1 se o nome de utilizador já existir.</returns>
        /// <exception cref="Exception">Lançada se ocorrer um erro inesperado ao criar o utilizador.</exception>

        public static int Registo(string username, string password, string email, string nome, string nif, int tipouser)
        {
            // Verifica se o utilizador já existe
            if (listautilizadores.Exists(u => u.Username == username)) return -1;

            Utilizador? novoUtilizador = tipouser switch
            {
                1 => new Funcionário(username, password, email, nome, nif), // Cria um Funcionário
                2 => new Cliente(username, password, email, nome, nif, 0),    // Cria um Cliente
                _ => null
            };

            listautilizadores.Add(novoUtilizador);

            return 1;
        }

        /// <summary>
        /// Autentica um utilizador com base no nome de utilizador e palavra-passe fornecidos.
        /// </summary>
        /// <param name="username">O nome de utilizador.</param>
        /// <param name="password">A palavra-passe do utilizador.</param>
        /// <returns>
        /// 1 se a autenticação for bem-sucedida,
        /// -1 se o utilizador não existir,
        /// -2 se a palavra-passe estiver incorreta.
        /// </returns>
        public static int Login(string username, string password)
        {
            Utilizador? utilizador = listautilizadores.Find(u => u.Username == username);
            if (utilizador == null) return -1;
            if (utilizador.Password != password) return -2;
            if (utilizador.Username == username && utilizador.Password == password)
            {
                userlogado = utilizador;
                tipologado = utilizador.Tipo;
               
            }
            return 1;
        }
        /// <summary>
        /// Remove um utilizador do sistema com base no seu identificador único.
        /// </summary>
        /// <param name="id">O identificador único do utilizador a remover.</param>
        /// <returns>1 se o utilizador for removido com sucesso, -1 se o utilizador não for encontrado.</returns>
        public static int RemoverUtilizador(int id)
        {
            Utilizador? removerutilizador = listautilizadores.Find(x => x.Id == id);
            if(removerutilizador != null)
            {
                listautilizadores.Remove(removerutilizador);
                return 1;
            }
            return -1;   
        }
        /// <summary>
        /// Altera a palavra-passe do utilizador autenticado, após verificar a palavra-passe antiga.
        /// </summary>
        /// <param name="passwordantiga">A palavra-passe atual do utilizador.</param>
        /// <param name="passwordnova">A nova palavra-passe para o utilizador.</param>
        /// <returns>
        /// 1 se a palavra-passe for alterada com sucesso,
        /// -1 se não houver utilizador autenticado,
        /// -2 se a palavra-passe antiga estiver incorreta.
        /// </returns>
        public static int AlterarPassword(string passwordantiga, string passwordnova)
        {
        if (userlogado == null)
        {
            return -1; //Ninguem logado
        }
        if (userlogado.Password == passwordantiga)
        {
           userlogado.Password = passwordnova;
           return 1;
        }
           return -2; //password incorreta
        }
        /// <summary>
        /// Verifica se existe um utilizador autenticado no sistema.
        /// </summary>
        /// <returns>O objeto Utilizador do utilizador autenticado, ou null se não houver um utilizador autenticado.</returns>
        public static Utilizador? VerificaAutenticação()
        {
            if (userlogado == null) return null;
            Utilizador? user = userlogado;
            return user;
        }

        /// <summary>
        /// Termina a sessão do utilizador autenticado, removendo-o do estado de sessão ativa.
        /// </summary>
        /// <returns>True se o logout for bem-sucedido; False se não houver utilizador autenticado.</returns>
        public static bool Logout()
        {
            if (userlogado == null) return false;

            userlogado = null;
            tipologado = null;
            return true;
        }


        #endregion

        #region Destructor
        #endregion

        #endregion
    }
}