using Calculadora.Services;

namespace Teste;

public class CalculadoraTest
{

    private CalculadoraImp _calc;

    public CalculadoraTest()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int result = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, result);


    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarTrue()
    {
        //Arrange
        int num = 4;

        //Act
        bool result = _calc.EhPar(num);

        //Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    public void DeveVerificarSeOsNumerosSaoPresEReornarTrue(int num)
    {
        //Act
        bool result = _calc.EhPar(num);

        //Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(new int[] {6,4,6})]
    public void DeveVerificarSeOsNumerosDaListaSaoPresEReornarTrue(int[] numeros)
    {
        //Acto e Assert
        Assert.All(numeros, nums => _calc.EhPar(nums));
    }
}
