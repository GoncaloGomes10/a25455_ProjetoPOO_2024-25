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
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="nome"></param>
        /// <param name="nif"></param>
        /// <param name="tipouser"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        public static Utilizador? VerificaAutenticação()
        {
            if (userlogado == null) return null;
            Utilizador? user = userlogado;
            return user;
        }


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