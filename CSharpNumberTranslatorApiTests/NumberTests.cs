using CSharpNumberTranslatorApi.Enums;
using CSharpNumberTranslatorApi.ExtensionMethods;
using CSharpNumberTranslatorApi.RepositoryContracts;
using CSharpNumberTranslatorApi.ServiceContracts;
using CSharpNumberTranslatorApi.Services;
using Moq;
using NUnit.Framework;

namespace CSharpNumberTranslatorApiTests
{
    public class Tests
    {
        private Mock<IUniqueNumberRepository> _uniqueNumberRepositoryMock;
        private Mock<IUniqueNumberTranslatorService> _uniqueNumberTranslatorServiceMock;
        private Mock<IPrefixService> _prefixServiceMock;

        [SetUp]
        public void Setup()
        {
            _uniqueNumberRepositoryMock = new Mock<IUniqueNumberRepository>();
            _uniqueNumberTranslatorServiceMock = new Mock<IUniqueNumberTranslatorService>();
            _prefixServiceMock = new Mock<IPrefixService>();
        }

        [Test]
        public void TestGetDigit()
        {
            var expected = new[] {3, 1};
            var actual = new[]
            {
                31.GetDigit(DigitPlacesEnum.Tens),
                31.GetDigit(DigitPlacesEnum.Ones)
            };

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestUniqueNumbers()
        {
            _uniqueNumberRepositoryMock.Setup(x => x.Get(It.IsAny<int>())).Returns("zero");
            var uniqueNumberService = new UniqueNumberTranslatorService(_uniqueNumberRepositoryMock.Object);
            var expected = "zero";
            var actual = uniqueNumberService.TranslateUniqueNumbers(0);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTeens()
        {
            var prefixServiceMock = new Mock<IPrefixService>();
            prefixServiceMock.Setup(x => x.GetPrefix(It.IsAny<int>())).Returns("thir");
            var teensTranslatorService = new TeensTranslatorService(prefixServiceMock.Object);
            var expected = "thirteen";
            var actual = teensTranslatorService.TranslateTeens(13);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTranslateTensWithZeroAtEnd()
        {
            var expected = "twenty";
            _prefixServiceMock.Setup(x => x.GetPrefix(It.IsAny<int>())).Returns("twen");
            _uniqueNumberRepositoryMock.Setup(x => x.Get(It.IsAny<int>())).Returns("");
            var translateTensService = new TensTranslatorService(_prefixServiceMock.Object, _uniqueNumberTranslatorServiceMock.Object);
            var actual = translateTensService.TranslateTens(20);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestTranslateTensWithNonZeroAtEnd()
        {
            var expected = "twenty-two";
            _prefixServiceMock.Setup(x => x.GetPrefix(It.IsAny<int>())).Returns("twen");
            _uniqueNumberTranslatorServiceMock.Setup(x => x.TranslateUniqueNumbers(It.IsAny<int>())).Returns("two");
            var translateTensService = new TensTranslatorService(_prefixServiceMock.Object, _uniqueNumberTranslatorServiceMock.Object);
            var actual = translateTensService.TranslateTens(22);

            Assert.AreEqual(expected, actual);
        }
    }
}