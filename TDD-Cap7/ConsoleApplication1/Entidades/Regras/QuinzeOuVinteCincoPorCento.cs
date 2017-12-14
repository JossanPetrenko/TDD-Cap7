using ConsoleApplication1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Entidades.Regras
{
    public class QuinzeOuVinteCincoPorCento : IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.Salario < 2500)
            {
                return funcionario.Salario * 0.85;
            }
            return funcionario.Salario * 0.75;
        }
    }
}
