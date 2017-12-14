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

        public String Nome { get; private set; }

        public double Salario { get; private set; }

        public Cargo Cargo { get; private set; }

        public Funcionario(String nome, double salario, Cargo cargo)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.Cargo = cargo;
        }
    }
}
