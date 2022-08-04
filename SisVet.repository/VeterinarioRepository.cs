using System;
using System.Collections.Generic;
using SisVet.Model;

namespace SisVet.repository
{
    public class VeterinarioRepository
    {
        public bool Salvar(Veterinario veterinario)
        {
            return true;
        }

        public Veterinario Retornar(int veterianarioId)
        {
            Veterinario veterinario = new Veterinario(veterianarioId);

            // Buscar dados do banco de dados

            if (veterianarioId == 1)
            {
                veterinario.Nome = "Mauricio";
                veterinario.Sobrenome = "Gonzatto";
                veterinario.Crv = "123456";
                veterinario.Email = "mauriciogonzatto@hotmail.com";
                veterinario.Telefone = "49 9 9975 8575";

            }

            return new Veterinario();
        }

        public List<Veterinario> Retornar()
        {
            return new List<Veterinario>();
        }
    }
}
