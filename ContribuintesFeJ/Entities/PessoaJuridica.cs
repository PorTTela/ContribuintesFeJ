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

        public override double Imposto()
        {
            if (NumFuncionarios > 10)
            {
               return RendaAnual * 0.14;
            }
            else
            {
               return RendaAnual * 0.16;
            }
        }
    }
}
