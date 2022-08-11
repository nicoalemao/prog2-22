﻿using System;

namespace SisVet.Model
{
    public class Atendimento
    {
        private int atendimentoId;


        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int ClinicaId { get; set; }
        public Clinica Clinica { get; set; }
        public int VeterinarioId { get; set; }
        public Veterinario Veterinario{ get; set; }
        public int AnimalId { get; set; }
        public Animal Animal{ get; set; }
        public int ProcedimentoId { get; set; }

        public Atendimento()
        {
        }

        public Atendimento(int id)
        {
            Id = id;
        }
    }
}
