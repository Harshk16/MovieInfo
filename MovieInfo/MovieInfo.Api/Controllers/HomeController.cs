using MovieInfo.Core.Core.Interfaces;
using MovieInfo.Core.Models.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MovieInfo.Api.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ITestService testService)
        {
            _testService = testService;
        }

        private readonly ITestService _testService;

        public IEnumerable<User> Index()
        {
            var result = _testService.Get();

            return result;
        }
    }
}