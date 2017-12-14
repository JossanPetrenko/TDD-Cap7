using ConsoleApplication1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Entidades.Regras
{
    public class DezOuVintePorCento : IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.Salario > 3000)
            {
                return funcionario.Salario * 0.8;
            }
            return funcionario.Salario * 0.9;
        }
    }
}