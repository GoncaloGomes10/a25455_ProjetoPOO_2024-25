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
        string nome;
        string especie;
        int idade;
        double peso;
        public static List<Animal> animais = new List<Animal>();

        #endregion

        #region Methods

        #region Constructors  
        public Animal(string nome,string especie, int idade, double peso, DIETA dieta)
        {
            this.nome = nome;
            this.especie = especie;
            this.idade = idade;
            this.peso = peso;
            this.dieta = dieta;
        }
        #endregion

        #region Properties
        #endregion

        #region Operators
        #endregion

        #region Overrides 
        public override string ToString()
        {
            string outStr = String.Format("Nome: {0} Especie: {1} Idade: {2} Peso: {3} Tipo: {4}", nome, especie, idade, peso, dieta);
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
        public void MostraAnimal()
        {
            Console.WriteLine($"");
        }
        #endregion

        #region Destructor
        #endregion

        #endregion
      
            

      


       
       

      

    }

}
