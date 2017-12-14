using ConsoleApplication1.Entidades.Regras;
using ConsoleApplication1.Enums;
using ConsoleApplication1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Entidades
{
    public class Cargo
    {

        public Cargo DESENVOLVEDOR { get { return new Cargo(new DezOuVintePorCento()); } }

        public Cargo DBA { get { return new Cargo(new QuinzeOuVinteCincoPorCento()); } }

        public Cargo TESTADOR { get { return new Cargo(new QuinzeOuVinteCincoPorCento()); } }


        public IRegraDeCalculo Regra { get; private set; }

        private Cargo(IRegraDeCalculo regra)
        {
            this.Regra = regra;
        }

        public Cargo()
        {
        }
    }

}

