using CapitalPlatforms.Application.Interfaces;
using CapitalPlatforms.Domain.Consultants;
using Moq.AutoMock;
using Moq.EntityFrameworkCore;
using NUnit.Framework;

namespace CapitalPlatforms.Application.Consultants.Queries.GetConsultants
{
    [TestFixture]
    public class GetConsultantsQueryTests
    {
        private GetConsultantsQuery _query;
        private AutoMocker _mocker;
        private Consultant _consultant;

        private const int Id = 1;
        private const string FirstName = "Kylian";
        private const string LastName = "George";
        private const string EmailAddress = "kylian@george.com";
        private const string MobileNo = "0122133311";

        [SetUp]
        public void SetUp()
        {
            _consultant = new Consultant()
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                EmailAddress = EmailAddress,
                MobileNo = MobileNo
            };

            _mocker = new AutoMocker();

            _mocker.GetMock<IDatabaseService>()
                .Setup(c => c.Consultants)
                .ReturnsDbSet(new List<Consultant> { _consultant });

            _query = _mocker.CreateInstance<GetConsultantsQuery>();
        }

        [Test]
        public void TestExecuteShouldReturnConsultants()
        {
            var results = _query.Execute();

            var result = results.Single();

            Assert.That(result.Id, Is.EqualTo(Id));
            Assert.That(result.FirstName, Is.EqualTo(FirstName));
            Assert.That(result.LastName, Is.EqualTo(LastName));
            Assert.That(result.EmailAddress, Is.EqualTo(EmailAddress));
            Assert.That(result.MobileNo, Is.EqualTo(MobileNo));
        }

    }
}
