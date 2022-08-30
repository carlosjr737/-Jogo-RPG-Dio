using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace Teste
{
    public class ValidacoresStringTest
    {
        private ValidacoesStringImp _validaco;

        public ValidacoresStringTest()
        {
            _validaco = new ValidacoesStringImp();
        }

        [Fact]
        public void DeveContar3CharEmOlarERetornar3()
        {
            //Arrange
            string texto = "Ola";

            //Act

            int result = _validaco.ContarCaracter(texto);

            //Assert
            Assert.Equal(3, result);
        }
    }
}