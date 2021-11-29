using System;
using Ohce;
using Xunit;

namespace OhceTests
{
    public class OhceShould
    {
        [Fact]
        public void GreetBuenosDias()
        {
            string greetingMessage = "Buenos días";
            string greet = OhceAnswers.OhceGreets();
            Assert.Equal(greetingMessage, greet);
        }
    }
}