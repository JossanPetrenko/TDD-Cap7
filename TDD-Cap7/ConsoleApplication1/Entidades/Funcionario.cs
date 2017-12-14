using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Enums;

namespace ConsoleApplication1.Entidades
{
    public class Funcionario
    {

        public Funcionario(string nome, double salario, Cargos  cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        public string Nome { get; set; }

        public double Salario { get; set; }

        public Cargos Cargo { get; set; }
    }
}
