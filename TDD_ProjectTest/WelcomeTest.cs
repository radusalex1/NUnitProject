using NUnit.Framework;
using System.Linq;
using TDD_Project;

namespace TDD_ProjectTest
{
    [TestFixture]
    public class WelcomeTest
    {

        public Welcome sut;

        [SetUp]
        public void Init()
        {
            sut = new Welcome();
        }

        [Test]
        [TestCase("Alina",ExpectedResult = "Hello, Alina.")]
        [TestCase("Nume",ExpectedResult = "Hello, Nume.")]
        public string Greet_ShouldReturn_CorrectGreetWhenNameIsSimpleString(string name)
        {
            var sut = new Welcome();
            return sut.Greet(name);
        }

        [Test]
        [TestCase("",ExpectedResult = "Hello, my friend.")]
        public string Greet_ShouldReturn_CorrectGreetWhenNameIsEmpty(string name)
        {
            return sut.Greet(name);
        }

        [Test]
        [TestCase("MARIA",ExpectedResult = "HELLO, MARIA!")]
        public string Greet_ShouldReturn_CorrectGreetWhenNameIsShouted(string name)
        {
            return sut.Greet(name);
        }

        [Test]
        [TestCase("Dode","Ana","Vali",ExpectedResult = "Hello, Dode, Ana and Vali.")]
        [TestCase("George","Ioana",ExpectedResult = "Hello, George and Ioana.")]
        public string Greet_ShouldReturn_CorrectGreetWhenInputIsListOfNames(params string[] names)
        {
            var listOfNames = names.ToList();
            return sut.Greet(listOfNames);
        }

        [Test]
        [TestCase("Ana", "MARIA", "George", ExpectedResult = "Hello, Ana and George. AND HELLO MARIA!")]
        [TestCase("Ana", "MARIA", "GEORGE","Vali", ExpectedResult = "Hello, Ana and Vali. AND HELLO MARIA AND GEORGE!")]
        [TestCase("Ana", "MARIA", "GEORGE","Vali","ANDREI","Dode", ExpectedResult = "Hello, Ana, Vali and Dode. AND HELLO MARIA, GEORGE AND ANDREI!")]
        public string Greet_ShouldReturn_CorrectMessageWhenInputIsListOfNormalNamesAndShoutedNames(params string [] names)
        {
            var listOfNames = names.ToList();
            return sut.Greet(listOfNames);
        }

        [Test]
        [TestCase("Victor", "Elena,Dan",ExpectedResult = "Hello, Victor, Elena and Dan.")]
        [TestCase("Victor,Andrei", "Elena,Dan",ExpectedResult = "Hello, Victor, Andrei, Elena and Dan.")]
        public string Greet_ShouldReturn_CorrectMessageWhenInputHasCommas(params string []names)
        {
            var listOfNames = names.ToList();
            return sut.Greet(listOfNames);
        }

        [Test]
        [TestCase("Ana", "\"George, Dan\"",ExpectedResult = "Hello, Ana and George, Dan.")]
        public string Greet_ShouldReturn_CorrectMessageWhenInputHasUntentionalCommas(params string []names)
        {
            var listOfNames = names.ToList();
            return sut.Greet(listOfNames);
        }

    }
}
