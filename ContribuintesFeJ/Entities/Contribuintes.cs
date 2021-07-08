using System;
using System.Collections.Generic;
using System.Text;

namespace ContribuintesFeJ.Entities
{
    class Contribuintes
    {
        public string Nome { get; protected set; }
        public double RendaAnual { get; protected set; }

        public Contribuintes()
        {
        }

        public Contribuintes(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
    }
}
