using System;
using System.Collections.Generic;
using System.Text;
using SisVet.Model;

namespace SisVet.Repository
{
    internal class ClienteAnimalRepository
    {
        public bool Salvar(ClienteAnimal clienteAnimal)
        {
            return true;

        }

        public ClienteAnimal Retornar(int clienteAnimalId)
        {
            ClienteAnimal clienteAnimal = new ClienteAnimal(clienteAnimalId);

            // Buscar dados do banco de dados

            if (clienteAnimalId == 1)
            {
                clienteAnimal.ClienteId = 1;
                clienteAnimal.AnimalId = 1;

            }

            return new ClienteAnimal();
            }
       
    }
}
