/*
*	<copyright file="ObjetosZoo" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>gonca</author>
*   <date>26/10/2024 16:24:23</date>
*	<description></description>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ObjetosZoo
{
    /// <summary>
    /// Purpose: 
    /// Created by: gonca
    /// Created on: 26/10/2024 16:24:23
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class TipoComida
    {
        #region Attributes
        private int id;
        private static int idstatic;
        DIETA dieta;
        private string nomecomida;
        private double calorias;
        public static List<TipoComida> tipocomidas = new List<TipoComida>();

        #endregion

        #region Methods

        #region Constructors
        public TipoComida(string nomecomida, double calorias, DIETA dieta)
        {
            idstatic++;
            Id = idstatic;
            NomeComida = nomecomida;
            Calorias = calorias;
            Dieta = dieta;
        }

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string NomeComida
        {
            get { return nomecomida; }
            set { nomecomida = value; }
        }

        public double Calorias
        {
            get { return calorias; }
            set { calorias = value; }
        }

        public DIETA Dieta
        {
            get { return dieta; }
            set { dieta = value; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides 
        public override string ToString()  
        {
            string outStr = String.Format(" {0} ,Calorias: {1}",NomeComida,Calorias);
            return outStr;
        }
        #endregion

        #region OtherMethods
        public bool MostraDetalhesTipodeComida()
        {
            Console.WriteLine($"Comida: {NomeComida}, Calorias: {Calorias}");
            return true;
        }

        public static bool CriarTipoComida(string nomecomida,double calorias,DIETA dieta)
        {
            TipoComida tipo = new TipoComida(nomecomida,calorias,dieta);
            tipocomidas.Add(tipo);
            return true;
        }

        public static bool MostraTodosTipodeComida()
        {
            foreach(var tipo in tipocomidas)
            {
                tipo.MostraDetalhesTipodeComida();
            }
            return true;
        }

        public static bool ApagarTipoComida(string nomecomida)
        {
            TipoComida? tipo = tipocomidas.Find(tipo=> tipo.nomecomida==nomecomida);
            if (tipo != null)
            {
                tipocomidas.Remove(tipo);
                Console.WriteLine("Tipo de comida apagada");
                return true;
            }
            else
            {
                Console.WriteLine("Tipo de comida não existe");
                return false;
            }
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
        
        
       
        
    }
}
