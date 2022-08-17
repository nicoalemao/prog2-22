using System;
using System.Collections.Generic;
using System.Text;
using SisVet.Model

namespace SisVet.Repository
{
    internal class EnderecoRepository
    {
        public bool Salvar(Endereco endereco)
        {
            return true;
        }

        public Endereco Retornar(int enderecoId)
        {
            Endereco endereco = new Endereco(enderecoId);

            // Buscar dados do banco de dados

            if (enderecoId == 1)
            {
                endereco.Rua = "C";
                endereco.Nro = "74";
                endereco.Complemento = "";
                endereco.Bairro = "Portal"
            }
        }
    }
}
