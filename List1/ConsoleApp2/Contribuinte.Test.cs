using Library;
using Xunit;

namespace Contribuinte.Tests 
{
    public class ContribuinteTest
    {
        [Fact]
        public void ShouldReturnName()
        {
            //arrange
            string name = "Henrique";
            var contribuinte = new Contribuintes();


            //act
            contribuinte.nome = name;
            var resultado = contribuinte.nome;

            //assert
            Assert.Equal("Henrique", resultado);
        }

        [Fact]
        public void SholdReturnCPF()
        {
            //arrange
            string cpf = "654.456.6454-21";
            var contribuinte = new Contribuintes();

            //act
            contribuinte.cpf = cpf;
            var resultado = contribuinte.cpf;

            //assert
            Assert.Equal("654.456.6454-21", resultado);
        }

        [Fact]
        public void ShouldReturnUF()
        {
            //arrange
            string uf = "SC";
            var contribuinte = new Contribuintes();

            //act
            contribuinte.uf = uf;
            var resultado = contribuinte.uf;

            //assert
            Assert.Equal("SC", resultado);
        }

        [Fact]
        public void ShouldReturnSalario()
        {
            //arrange
            double salario = 12345.00;
            var contribuinte = new Contribuintes();

            //act
            contribuinte.salario = salario;
            var resultado = contribuinte.salario;

            //assert
            Assert.Equal(12345.00, resultado);
        }

        [Fact]
        public void ShouldReturnZero()
        {
            //arrange
            var contribuinte = new Contribuintes();

            //act
            var resultado = contribuinte.ir;

            //assert
            Assert.Equal(0, resultado);
        }
    }
}
