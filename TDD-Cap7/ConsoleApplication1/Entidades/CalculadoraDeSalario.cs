using ConsoleApplication1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Entidades
{
    public class CalculadoraDeSalario
    {
        public CalculadoraDeSalario()
        {

        }

        public double CalculaSalario(Funcionario funcionario)
        {
            if (funcionario.Cargo.Equals(Cargos.DESENVOLVEDOR))
            {
                return DezOuVintePorCentoDeDesconto(funcionario);
            }
            else if (funcionario.Cargo.Equals(Cargos.DBA) ||
            funcionario.Cargo.Equals(Cargos.TESTADOR))
            {
                return QuinzeOuVinteCincoPorCentoDeDesconto(funcionario);
            }
            throw new Exception("Funcionario invalido");
        }

        private double QuinzeOuVinteCincoPorCentoDeDesconto(Funcionario funcionario)
        {
            if (funcionario.Salario < 2500)
            {
                return funcionario.Salario * 0.85;
            }
            return funcionario.Salario * 0.75;
        }        private double DezOuVintePorCentoDeDesconto(Funcionario funcionario)
        {
            if (funcionario.Salario > 3000)
            {
                return funcionario.Salario * 0.8;
            }
            return funcionario.Salario * 0.9;
        }
    }
}
