using System.Threading.Tasks;
using AutoMapper;
using Passenger.Infrastructure.Services;
using  Xunit;
using Moq;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;

namespace Passenger.Tests.Services
{
    public class UserServiceTests
    {
        [Fact]
        public async Task register_async_should_invoke_and_async_on_repository()
        {
            var userRepositoryMock = new Mock<IUserRepository>();
            var mapperMock = new Mock<IMapper>();
            
            var userService = new UserService(userRepositoryMock.Object, mapperMock.Object);
            await userService.RegisterAsync("user@email.com", "user", "secret");
            
            userRepositoryMock.Verify(x => x.AddAsync(It.IsAny<User>()), Times.Once);
        }
    }
}