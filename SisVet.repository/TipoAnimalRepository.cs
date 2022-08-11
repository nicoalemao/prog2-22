using System;
using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repository
{
    internal class TipoAnimalRepository
    {
        public bool Salvar(TipoAnimal tipoAnimal)
        {
            return true;
        }

        public TipoAnimal Retornar(int tipoAnimalId)
        {
            TipoAnimal tipoAnimal = new TipoAnimal(tipoAnimalId);

            // Buscar dados do banco de dados

            if (tipoAnimalId == 1)
            {
                tipoAnimal.Tipo = "Gato";
            }

            return new TipoAnimal();
        }

        public List<TipoAnimal> Retornar()
        {
            return new List<TipoAnimal>();
        }
    }
}
