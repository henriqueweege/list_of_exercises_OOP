using Library;
using Xunit;


namespace CalcularIR.Test
{
    public class CalculaIRTest
    {
        [Fact]
        public void ShouldReturnZero()
        {
            //arrange
            int salario = 1;
            var calculaIR = new CalculaIR();

            //act
            var resultado = calculaIR.CalcularIR(salario);


            //assert
            Assert.Equal(0, resultado);
        }

        [Fact]
        public void ShouldReturn232()
        {
            //arrange
            int salario = 4001;
            var calculaIR = new CalculaIR();
            //act
            var resultado = calculaIR.CalcularIR(salario);
            //assert
            Assert.Equal(232.05, resultado);
        }

        [Fact]
        public void ShouldReturn1315()
        {
            int salario = 9001;
            var calculaIR = new CalculaIR();
            //act
            var resultado = calculaIR.CalcularIR(salario);
            //assert
            Assert.Equal(1350.15, resultado);
        }

        [Fact]
        public void ShouldReturn6875()
        {
            int salario = 25001;
            var calculaIR = new CalculaIR();
            //act
            var resultado = calculaIR.CalcularIR(salario);
            //assert
            Assert.Equal(6875.27, resultado);
        }

        [Fact]
        public void ShouldReturn10500()
        {
            int salario = 35001;
            var calculaIR = new CalculaIR();
            //act
            var resultado = calculaIR.CalcularIR(salario);
            //assert
            Assert.Equal(10500.30, resultado);
        }
    }
}