using Library;
using Xunit;

namespace MaiorIR.Test
{
    public class MaiorIRTest
    {
        [Fact]
        public void ShouldReturnDefaultName()
        {
            //arrange
            var nome = Library.MaiorIR.nomeMaiorIR;

            //act

            //assert
            Assert.Equal("nome", nome);
        }

        [Fact]
        public void ShouldReturnDefaltMaiorIR()
        {
            //arrange
            var ir = Library.MaiorIR.maiorIR;

            //act

            //assert
            Assert.Equal((double)0, ir);
        }

        [Fact]
        public void ShouldReturnNewName()
        {
            //arrange
            var nome = "Henrique";
            var ir = 5000;

            //act
            Library.MaiorIR.CalculaMaiorIR(nome, ir);
            var novoNome = Library.MaiorIR.nomeMaiorIR;


            //assert
            Assert.Equal("Henrique", novoNome);
        }

        [Fact]
        public void ShouldReturnNewIR()
        {
            //arrange
            var nome = "Henrique";
            var ir = 5000;

            //act
            Library.MaiorIR.CalculaMaiorIR(nome,ir);
            var novoIR =  Library.MaiorIR.maiorIR;

            //assert
            Assert.Equal(5000, novoIR);
        }
    }
}