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
    public enum DIETA
    {
        Carnivoro,
        Herbivoro,
        Omnivoro
    }
    public class Animal
    {
        #region Atributes
        
        DIETA dieta;
        private int id;
        private static int idstatic;
        private string nome;
        private string especie;
        private int idade;
        private double peso;
        public static List<Animal> animais = new List<Animal>();

        #endregion

        #region Methods

        #region Constructors  
        public Animal(string nome,string especie, int idade, double peso, DIETA dieta)
        {
            idstatic++;
            id = idstatic;
            Nome = nome;
            Especie = especie;
            Idade = idade;
            Peso = peso;
            Dieta = dieta;
        }

        #endregion

        #region Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
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
            string outStr = String.Format("Nome: {0} Especie: {1} Idade: {2} Peso: {3} kg Tipo: {4} Id: {5}", Nome, Especie, Idade, Peso, Dieta,Id);
            return outStr;
        }
       
        #endregion

        #region OtherMethods  
        public static bool CriarAnimal(string nome,string especie,int idade,double peso,DIETA dieta)
        {
            Animal animal = new Animal(nome,especie,idade,peso,dieta);
            animais.Add(animal);

            return true;
        }

        public static bool MostraAnimais()
        {
            foreach (var animal in animais)
            {
                Console.WriteLine(animal.ToString());
            }
            return true;
        }

        #endregion

        #region Destructor
        #endregion

        #endregion
      
            

      


       
       

      

    }

}
