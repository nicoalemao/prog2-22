using System;
using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repository
{
    internal class AnimalRepository
    {
        public bool Salvar(Animal animal)
        {
            return true;
        }

        public Animal Retornar(int animalId)
        {
            Animal animal = new Animal(animalId);

            // Buscar dados do banco de dados

            if (animalId == 1)
            {
                animal.Nome = "Bidi";
                animal.DataNascimento = DateTime.Now;
                animal.Peso = 5;
                animal.Altura = 37;
                animal.Comprimento = 50;
                animal.Cor = "Branco";

            }
        }
    }
}
