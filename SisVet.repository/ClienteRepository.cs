using System;
using System.Collections.Generic;
using System.Text;
using SisVet.Model;

namespace SisVet.Repository
{
    internal class ClienteRepository
    {
        public bool Salvar(Cliente cliente)
        {
            return true;
        }

        public Cliente Retornar(int clienteId)
        {
            Cliente cliente = new Cliente(clienteId);

            // Buscar dados do banco de dados

            if (clienteId == 1)
            {
                cliente.Nome = "Nicolas Jung";
                cliente.Cpf = "071.559.629-29";
                cliente.Email = "njayt2@gmail.com";
                cliente.Telefone = "988230299";
                cliente.EnderecoId = 1;

            }

            return new Cliente();
        }

        public List<Cliente> Retornar()
        {
            return new List<Cliente>();
        }
    }
}
