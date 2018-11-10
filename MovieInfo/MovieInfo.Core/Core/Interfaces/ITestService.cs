using MovieInfo.Core.Models.Models;
using System.Collections.Generic;

namespace MovieInfo.Core.Core.Interfaces
{
    public interface ITestService
    {
        IEnumerable<User> Get();
    }
}
