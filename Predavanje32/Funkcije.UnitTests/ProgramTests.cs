using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Funkcije.UnitTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Kvadrat_Integer5_Returns25()
        {
            //Arrange
            int broj = 5;

            //Act
            double kvadrat = Program.Kvadrat(broj);

            //Assert
            Assert.AreEqual(25, kvadrat);
        }

        [TestMethod]
        public void Kvadrat_InvalidValue_ReturnsFormatException()
        {
            //Arrange
            var nijeBroj = "pet";

            //Assert
            Assert.ThrowsException<FormatException>(() =>
            {
                //Act
                double kvadrat = Program.Kvadrat(double.Parse(nijeBroj));
            });
        }

        [TestMethod]
        public void UcitajCijeliBroj_ValidInput_ReturnsNumber()
        {
            //Arrange
            string input = "5";
            int expectedOutput = 5;
            using (var stringReader = new StringReader(input))
            {
                Console.SetIn(stringReader);

                //Act
                int result = Program.UcitajCijeliBroj();

                //Assert
                Assert.AreEqual(expectedOutput, result);
            }
        }

        [TestMethod]
        public void UcitajCijeliBroj_InvalidInput_ThrowsFormatException()
        {
            //Arrange
            string input = "abc";

            using (var stringReader = new StringReader(input))
            {
                Console.SetIn(stringReader);

                //Assert
                Assert.ThrowsException<FormatException>(() =>
                {
                    //Act
                    int result = Program.UcitajCijeliBroj();
                });
            }
        }
    }
}