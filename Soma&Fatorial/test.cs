using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTest
{
    [TestClass]
    public class UnitTestProgram
    {
        private const int fatorialExperado = 120;
        private const int somaExperado = 16;
        [TestMethod]
        public void TestProgram()
        {
            using (var sw = new StringWriter())
            {
                var teste1 = Logic.Main.Fatorial(5);
                Assert.AreEqual(fatorialExperado, teste1);

                
            }
            using (var sw = new StringWriter())
            {
                var teste2 = Logic.Main.Soma(5);
                Assert.AreEqual(somaExperado, teste2);
            }
        }
    }
}
