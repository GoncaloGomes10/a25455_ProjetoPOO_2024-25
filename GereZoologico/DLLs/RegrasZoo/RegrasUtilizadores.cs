﻿/*
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
        public static int Registo(string username, string password, string email, string nome, string nif, int tipouser)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(nif) || tipouser <= 0 && tipouser > 2) return -2;
            return Utilizadores.Registo(username,password, email, nome, nif, tipouser);
        }

        public static int Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) return -3;
            return Utilizadores.Login(username,password);
        }

        public static int RemoverUtilizador(int id)
        {
            if (id < 0) return -2;
            return Utilizadores.RemoverUtilizador(id);
        }
        
        public static List<Utilizador> MostrarTodosUtilizadores()
        {
            return Utilizadores.Listautilizadores;
        }
        public static int AlterarPassword(string passwordantiga, string passwordnova)
        {
            if (string.IsNullOrEmpty(passwordantiga) || string.IsNullOrEmpty(passwordnova)) return -3; // passwords invalidas
            return Utilizadores.AlterarPassword(passwordantiga, passwordnova);
        }

        public static Utilizador? VerificaAutenticação()
        {
            return Utilizadores.VerificaAutenticação();
        }

        public static bool Logout()
        {
            return Utilizadores.Logout();
        }

        public static int ObterTipoLogado()
        {
            if (Utilizadores.TipoLogado == null) return -1;
            return (int)Utilizadores.TipoLogado;
        }

        public static Utilizador ObterUserLogado() 
        {
            if (Utilizadores.UserLogado == null) return null;
            return (Utilizador)Utilizadores.UserLogado;
        }

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