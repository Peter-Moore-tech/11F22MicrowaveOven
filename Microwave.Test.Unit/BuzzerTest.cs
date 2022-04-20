using Microwave.Classes.Boundary;
using NUnit.Framework;
using System.IO;
using System.Text;

namespace Microwave.Test.Unit
{
    [TestFixture]
    public class BuzzerTest
    {
        private StringWriter readConsole;
        private Buzzer uut;

        [SetUp]
        public void Setup()
        {
            uut = new Buzzer();
            readConsole = new StringWriter();
            System.Console.SetOut(readConsole);
        }

        [Test]
        public void BeepThreeTimes_MethodCalled_PrintsToTerminal()
        {
            // act
            uut.BeepThreeTimes();

            // assert
            var print = readConsole.ToString();
            Assert.AreEqual("Buzzer says: Beep, beep, beep\r\n", print);
        }
    }
}
