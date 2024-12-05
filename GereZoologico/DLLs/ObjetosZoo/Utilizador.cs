/*
*	<copyright file="ObjetosZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>26/10/2024 16:24:23</date>
*	<description></description>
*/


using System;

namespace ObjetosZoo
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 26/10/2024 16:24:23
    /// </summary>
    /// 
    public abstract class Utilizador
    {
        #region Attributes

        private int id;
        private static int idstatic;
        private string username;
        private string password;
        private string email;
        private string nome;
        private string nif;
        public abstract int Tipo { get; }

        //UTILIZADOR LOGADO
        static Utilizador? userlogado = null;
        static int? tipologado = null;

        public static List<Utilizador> utilizadores = new List<Utilizador>();


        #endregion

        #region Methods

        #region Constructors

        public Utilizador()
        {
            Username = "";
            Password = "12345";
            Email = "";
            NIF = "";
            Nome = "";
            Id = idstatic++;
            idstatic++;
        }
        public Utilizador(string username, string password, string email, string nome, string nif)
        {
            Username = username;
            Password = password;
            Email = email;
            NIF = nif;
            Nome = nome;
            Id = idstatic++;
            idstatic++;
        }
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string NIF
        {
            get { return nif; }
            set { nif = value; }
        }


        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        public static bool Registo(string username, string password, string email, string nome, string nif, int tipouser)
        {
            // Verifica se o utilizador já existe
            if (utilizadores.Exists(u => u.Username == username))
            {
                Console.WriteLine("Utilizador já registrado.");

                return false;
            }

            Utilizador novoUtilizador = tipouser switch
            {
                1 => new Funcionário(username, password, email, nome, nif), // Cria um Funcionário
                2 => new Cliente(username, password, email, nome, nif),    // Cria um Cliente
                _ => throw new Exception("Tipo de utilizador inválido.")
            };

            utilizadores.Add(novoUtilizador);

            return true;
        }

        public static bool Login(string username, string password)
        {
            if (username == null || password == null)
            {
                return false;
            }
            else
            {
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {

                    Utilizador? utilizador = utilizadores.Find(u => u.Username == username);
                    if (utilizador == null) 
                    {
                        Console.WriteLine("Utilizador não existe!");
                        return false;
                    }
                    
                    if (utilizador.Password != password)
                    {
                        Console.WriteLine("Password Incorreta!");
                        return false;
                    }

                    if (utilizador.username == username && utilizador.password == password)
                    {
                        userlogado = utilizador;
                        tipologado = utilizador.Tipo;

                        Console.WriteLine("Login Efetuado com sucesso!");

                        return true;
                    }

                }
                return false;
            }
        }

        public static bool AlterarPassword(string passwordantiga, string passwordnova)
        {
            if (userlogado == null)
            {
                Console.WriteLine("Nenhum Utilizador logado!");
                return false;
            }

            if(!string.IsNullOrEmpty(passwordantiga) && !string.IsNullOrEmpty(passwordnova))
            {
                if (userlogado.password == passwordantiga) 
                {
                    userlogado.password = passwordnova;

                    Console.WriteLine("Password Alterada com sucesso!");
                    return true;
                }

                Console.WriteLine("Passwords Incorretas!");
                return false;
            }

            Console.WriteLine("Passwords Inválidas!");
            return false;
        }

        public static Utilizador? VerificaAutenticação()
        {

            if (userlogado == null)
            {
                Console.WriteLine("Nenhum Utilizador Logado!");

                return null;
            }

            Utilizador? user = userlogado;

            Console.WriteLine("Utilizador logado: " + user.username);


            return user;
        }

        public static bool Logout()
        {
            if (userlogado == null)
            {
                Console.WriteLine("Nenhum Utilizador Logado!");

                return false;
            }

            userlogado = null;
            tipologado = null;

            Console.WriteLine("Logout Efetuado com Sucesso!");

            return true;
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
    }

}