using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Xunit;
using Ohce;

namespace OhceTests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckBuenosDias()
        {
            string greetingMessage = "Buenos días";
            string greet = OhceAnswers.OhceGreets;
            Assert.Equal(greetingMessage, OhceGreets());

        }

        // {
        //     public void CheckIfOneIsOne()
        //     {
        //         int listPosition = 0;
        //         string printedValue = "1";
        //         int number = FizzbuzzCalculator.GenerateNumbers()[listPosition];
        //         Assert.Equal(printedValue, FizzbuzzCalculator.ConvertsValueToString(number));
        //     }
        // }
    }
}