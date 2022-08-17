using System;
using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.Repository
{
    public class ClinicaRepository
    {
        public bool Salvar(Clinica clinica)
        {
            return true;
        }

        public Clinica Retornar(int ClinicaId)
        {
            Clinica clinica = new Clinica(ClinicaId);

            // Buscar dados do banco de dados

            if (ClinicaId == 1)
            {
                clinica.Nome = "Pet Lovers";
                clinica.Telefone = "32465879";
                clinica.Email = "petlovers@gmail.com";
                clinica.EnderecoId = 1;
                clinica.Endereco = new Endereco();

            }

            return new Clinica();
        }

        public List<Clinica> Retornar()
        {
            return new List<Clinica>();
        }
    }
}