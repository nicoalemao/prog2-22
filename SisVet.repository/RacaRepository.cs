using System;
using System.Collections.Generic;
using System.Text;
using SisVet.Model;

namespace SisVet.Repository
{
    internal class RacaRepository
    {
        public bool Salvar(Raca raca)
        {
            return true;
        }

        public Raca Retornar(int racaId)
        {
            Raca raca = new Raca(racaId);

            // Buscar dados do banco de dados

            if (racaId == 1)
            {
                raca.Nome = "Vira lata";
                raca.TipoAnimalId = 1;
                raca.TipoAnimal = new TipoAnimal();
            }

            return new Raca();
        }

        public List<Raca> Retornar()
        {
            return new List<Raca>();
        }
    }
}
