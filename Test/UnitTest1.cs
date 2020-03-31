using consoleCircleci.Metodos;
using System;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            Gestion gestion = new Gestion();
            Assert.Equal("HOLA", gestion.Alfanumerico());

        }
    }
}
