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
using System.Text;
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
    public enum ZONA
    {
        Savana,
        Deserto,
        Aquática,
        Floresta
    }
    public enum TIPOBILHETE
    {
        Passeio,
        Espetáculo,
        Completo             // passeio e espetaculo
    }
    public class Bilhete
    {
        #region Attributes 

        private ZONA zona;
        private TIPOBILHETE tipobilhete;
        private double preço;
        private int id;
        private static int idstatic;
        public static List<Bilhete> bilhetes = new List<Bilhete>();

        #endregion

        #region Methods

        #region Constructors 
        public Bilhete(ZONA zona, TIPOBILHETE tipobilhete, double preço)
        {
            idstatic++;
            id = idstatic;
            TipoBilhete = tipobilhete;
            Zona = zona;
            Preço = preço;

        }
        #endregion

        #region Properties
        public double Preço
        {
            get { return preço; }
            set { preço = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public ZONA Zona
        {
            get { return zona; }
            set { zona = value; }
        }

        public TIPOBILHETE TipoBilhete
        {
            get { return tipobilhete; }
            set { tipobilhete = value; }
        }

        #endregion

        #region Operators
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        public void VerBilhete()
        {
            Console.WriteLine($"O teu bilhete {Id} do tipo {TipoBilhete} custou {Preço} euros para a zona: {Zona}");
        }

        public static bool ComprarBilhete(ZONA zona, TIPOBILHETE tipobilhete, double preço)
        {
            Bilhete bilhete = new Bilhete(zona,tipobilhete,preço);
            bilhetes.Add(bilhete);
            Console.WriteLine("Bilhete comprado com sucesso");
            return true;
        }

        public static bool VerTodosBilhetes()
        {
            foreach(var  bilhete in bilhetes)
            {
                bilhete.VerBilhete();
            }
            return true;

        }
        #endregion

        #region Destructor
        #endregion

        #endregion
       

        

        

    }
}