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
                ("Mauricio", 1500.0, Cargos.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(desenvolvedor);

            Assert.AreEqual(1500.0 * 0.9, salario, 0.00001);
        }
    }
}
