using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using VNR_InternShip_Technical_Test.Data.Entities;
using VNR_InternShip_Technical_Test.Models;
using VNR_InternShip_Technical_Test.Services;

namespace VNR_InternShip_Technical_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICourseService _courseService;

        public HomeController(ILogger<HomeController> logger, ICourseService courseService)
        {
            _logger = logger;
            _courseService = courseService;
        }

        public async Task<IActionResult> Index(int id = 0)
        {
            var listkhoahoc = await _courseService.GetAllCourse();
            if (id != 0)
            {
                var listmonhoc = await _courseService.GetSubject(id);
                var khoahoc = await _courseService.GetCourse(id);
                return View(new HomeViewModel()
                {
                    KhoaHocs = listkhoahoc,
                    MonHocs = listmonhoc,
                    KhoaHoc = khoahoc
                });
            }

            return View(new HomeViewModel()
            {
                KhoaHocs = listkhoahoc
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}