using MovieInfo.Core.Core.Interfaces;
using MovieInfo.Core.Models;
using MovieInfo.Core.Models.Models;
using System.Collections.Generic;

namespace MovieInfo.Core.Services
{
    public class TestService : ITestService
    {
        public TestService(
           IRepository<User> userRepository
           )
        {
            _userRepository = userRepository;
        }

        private readonly IRepository<User> _userRepository;

        public IEnumerable<User> Get()
        {

            var result = _userRepository.Get();

            return result;
        }
    }
}
