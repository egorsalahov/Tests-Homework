using Microsoft.EntityFrameworkCore.ChangeTracking;
using NSubstitute;
using Testovoe.Domain;
using Testovoe.EFCore;
using Testovoe.EFCore.Model;

namespace TestovoeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Create_loginIsNullOrEmpty_returnException()
        {
            var dbcontext = Substitute.For<IDbContext>();

            var userRepository = new UserRepository(dbcontext);

            var createModel = new CreateUserModel(string.Empty, String.Empty, String.Empty, DateOnly.FromDateTime(DateTime.UtcNow));

            //Act, Asert
            //dbcontext.Users.DidNotReceive().Add(Arg.Any<User>());
            //single responsobility 

            Assert.Throws<Exception>(() => userRepository.Create(createModel));
        }

        //проверка пароля

        //ДЗ: тест на валидацию входящей сущность, тест на валидацию входных параметров
    }
}