using System;
using Xunit;

namespace BankKata.Tests
{
    public class BankKataShould
    {
        [Fact]
        public void Test1()
        {
            //given
            
            //when
            
            //then comprobar qué se ha escrito en la consola preguntando al doble de test de la consola

            ConsoleMock console = new ();
            var result = console.GetPrintedOutput();
            result.Should().Be("Date       || Amount || Balance");
        }
    }
}
