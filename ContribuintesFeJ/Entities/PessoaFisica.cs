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

        public override double Imposto()
        {
           if (RendaAnual < 20000.0)
            {
                RendaAnual * 0.15 - GastoSaude * 0.5;

            }
            else
            {
                RendaAnual * 0.25 - GastoSaude * 0.5;
            }

        }
    }
}
