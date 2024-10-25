﻿using System;
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
        internal static List<Animal> animais = new List<Animal>();

        #endregion

        #region Methods

        #region Constructor
        public Animal(string nome,string especie, int idade, double peso, DIETA dieta)
        {
            this.nome = nome;
            this.especie = especie;
            this.idade = idade;
            this.peso = peso;
            this.dieta = dieta;
        }
        #endregion    

        public void MostraAnimal()
        {
            Console.WriteLine($"");
        }

        public static bool CriarAnimal(string nome,string especie,int idade,double peso,DIETA dieta)
        {
            Animal animal = new Animal(nome,especie,idade,peso,dieta);
            animais.Add(animal);

            return true;
        }

        #region Overrides
        public override string ToString()
        {
            string outStr = String.Format("Nome: {0} Especie: {1} Idade: {2} Peso: {3} Tipo: {4}", nome, especie, idade, peso, dieta);
            return outStr;
        }
        #endregion

        #region Destructor
        #endregion

        #endregion

    }

}
