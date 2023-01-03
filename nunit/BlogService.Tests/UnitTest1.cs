
using NUnit.Framework;
using project_backend.Services;

namespace project_backend.UnitTests.Services
{
    [TestFixture]
    public class Tests
    {
        private BlogService _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new BlogService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}