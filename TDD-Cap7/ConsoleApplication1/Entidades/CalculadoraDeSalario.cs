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
                if (funcionario.Salario > 3000)
                {
                    return funcionario.Salario * 0.8;
                }
                return funcionario.Salario * 0.9;
            }
            else if (funcionario.Cargo.Equals(Cargos.DBA))
            {
                if (funcionario.Salario < 2500)
                {
                    return funcionario.Salario * 0.85;
                }
                return funcionario.Salario * 0.75;
            }
            throw new Exception("Funcionario invalido");
        }
    }
}
