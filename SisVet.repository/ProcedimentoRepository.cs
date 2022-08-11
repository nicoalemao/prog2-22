using System;
using System.Collections.Generic;
using System.Text;
using SisVet.Model;

namespace SisVet.Repository
{
    internal class ProcedimentoRepository
    {
        public bool Salvar(Procedimento procedimento)
        {
            return true;
        }

        public Procedimento Retornar(int procedimentoId)
        {
            Procedimento procedimento = new Procedimento(procedimentoId);

            // Buscar dados do banco de dados

            if (procedimentoId == 1)
            {
                procedimento.TipoProcedimento = "Checkup";
                procedimento.Descricao = "Tá joia";
            }
        }
    }
}
