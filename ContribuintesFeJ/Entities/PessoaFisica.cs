using System;
using System.Collections.Generic;
using System.Text;

namespace ContribuintesFeJ.Entities
{
    class PessoaFisica : Contribuintes
    {
        public double GastoSaude { get; private set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }
    }
}
