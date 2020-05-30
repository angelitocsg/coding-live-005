using System;
using MyProject;
using Xunit;

namespace MyProjectTest
{
    public class Example5 : IDisposable
    {
        private User user;

        public Example5()
        {
            user = new User()
            {
                Id = 1,
                Username = "user1",
                Email = "user1@example.com",
                Age = 18
            };
        }

        public void Dispose()
        {
            user = null;
        }

        [Fact]
        public void UserIsOlder()
        {
            Assert.True(user.Age >= 18);
        }

        [Fact]
        public void UserHasEmail()
        {
            Assert.NotNull(user.Email);
        }
    }
}
