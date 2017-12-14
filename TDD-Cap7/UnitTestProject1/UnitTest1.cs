using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1.Entidades;
using ConsoleApplication1.Enums;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestCap7
    {
        //public object Cargo { get; private set; }

        [TestMethod]
        public void
        DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();

            Funcionario desenvolvedor = new Funcionario
                ("Mauricio", 1500.0, new Cargo().DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.9, salario, 0.00001);
        }

        //        Para fazê-los passar, é necessário algum condicional no código de produção para
        //diferenciar o cálculo de desenvolvedores e DBAs, afinal as regras são diferentes.A

        //implementação abaixo, por exemplo, resolve o problema e faz todos os testes passa-
        //rem:

        [TestMethod]
        public void DeveCalcularSalarioParaDBAsComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario
            ("Mauricio", 1500.0, new Cargo().DBA);
            double salario = calculadora.CalculaSalario(desenvolvedor);
            Assert.AreEqual(1500.0 * 0.85, salario, 0.00001);
        }

        [TestMethod]
        public void DeveCalcularSalarioParaDBAsComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario desenvolvedor = new Funcionario
            ("Mauricio", 4500.0, new Cargo().DBA);
            double salario = calculadora.CalculaSalario(desenvolvedor);
            Assert.AreEqual(4500.0 * 0.75, salario, 0.00001);
        }
    }
}
