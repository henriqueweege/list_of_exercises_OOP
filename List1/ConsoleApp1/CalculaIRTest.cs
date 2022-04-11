using Library;
using Xunit;


namespace CalculaIR.Test
{
    public class CalculaIRTest
    {
        [Fact]
        public void SouldReturnZero()
        {
            //arrange
            int salario = 1;
            var calculaIR = new CalculaIR();

            //act
            var resultado = calculaIR.CalcularIR(salario);


            //assert
            Xunit.Assert.Equal(0, resultado);
        }
    }
}