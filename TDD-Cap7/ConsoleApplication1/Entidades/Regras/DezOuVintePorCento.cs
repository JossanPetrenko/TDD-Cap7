using ConsoleApplication1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Entidades.Regras
{
    public class DezOuVintePorCento  : RegraDeCalculo
    {
        protected override double PorcentagemBase()
        {
            return 0.9;
        }
        protected override double PorcentagemAcimaDoLimite()
        {
            return 0.8;
        }
        protected override int Limite()
        {
            return 3000;
        }
    }
}