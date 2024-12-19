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

        public string Display => $"{Id} - {Nome} - {Username} - {Password} - {Email} - {NIF}";
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
        public abstract int Tipo { get; }


        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        #endregion

        #region Destructor
        #endregion

        #endregion
    }

}