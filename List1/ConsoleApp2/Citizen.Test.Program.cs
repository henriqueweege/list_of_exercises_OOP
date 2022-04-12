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
            var contribuinte = new Citizens();


            //act
            contribuinte.name = name;
            var resultado = contribuinte.name;

            //assert
            Assert.Equal("Henrique", resultado);
        }

        [Fact]
        public void SholdReturnCPF()
        {
            //arrange
            string cpf = "654.456.6454-21";
            var contribuinte = new Citizens();

            //act
            contribuinte.socialSecurity = cpf;
            var resultado = contribuinte.socialSecurity;

            //assert
            Assert.Equal("654.456.6454-21", resultado);
        }

        [Fact]
        public void ShouldReturnUF()
        {
            //arrange
            string uf = "SC";
            var contribuinte = new Citizens();

            //act
            contribuinte.state = uf;
            var resultado = contribuinte.state;

            //assert
            Assert.Equal("SC", resultado);
        }

        [Fact]
        public void ShouldReturnSalario()
        {
            //arrange
            double salario = 12345.00;
            var contribuinte = new Citizens();

            //act
            contribuinte.income = salario;
            var resultado = contribuinte.income;

            //assert
            Assert.Equal(12345.00, resultado);
        }

        [Fact]
        public void ShouldReturnZero()
        {
            //arrange
            var contribuinte = new Citizens();

            //act
            var resultado = contribuinte.it;

            //assert
            Assert.Equal(0, resultado);
        }
    }
}
