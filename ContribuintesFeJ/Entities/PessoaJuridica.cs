using System;
using System.Collections.Generic;
using System.Text;

namespace ContribuintesFeJ.Entities
{
    class PessoaJuridica : Contribuintes
    {
        public int NumFuncionarios { get; private set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string nome, double rendaAnual, int numFuncionarios) : base(nome, rendaAnual)
        {
            NumFuncionarios = numFuncionarios;
        }
    }
}
