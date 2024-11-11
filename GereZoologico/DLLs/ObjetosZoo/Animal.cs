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
using System.Threading.Channels;
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

        public static Animal? EncontraAnimal(int id)
        {
            Animal? animal = animais.Find(animais => animais.Id == id);
            if (animal != null)
            {
                //Console.WriteLine(animal);
                return animal;
            }
            else
            {
                Console.WriteLine($"Animal com ID {id} não existe.");
                return null;
            }
        }

        public static bool ApagarAnimal(int id)
        {
            Animal? animal = animais.Find(animal => animal.Id == id);  

            if (animal != null)
            {
                animais.Remove(animal);
                Console.WriteLine($"Animal com ID {id} foi removido.");
                return true;
            }
            else
            {
                Console.WriteLine($"Animal com ID {id} não encontrado.");
                return false;
            }

        }

        public static Animal EscolherAnimalAleatorio(string especie)
        {
            // Filtra os animais pela espécie desejada
            var animaisDaEspecie = animais.Where(a => a.Especie == especie).ToList();

            // Verifica se há animais disponíveis para a espécie especificada
            if (animaisDaEspecie.Count == 0)
            {
                Console.WriteLine($"Nenhum animal disponível para a espécie {especie}.");
                return null; // Retorna null se não houver animais da espécie
            }

            // Seleciona aleatoriamente um animal da lista filtrada
            Random random = new Random();
            int index = random.Next(animaisDaEspecie.Count);
            return animaisDaEspecie[index];
        }

        #endregion

        #region Destructor
        #endregion

        #endregion











    }

}
