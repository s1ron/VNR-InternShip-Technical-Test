using Microsoft.EntityFrameworkCore;
using VNR_InternShip_Technical_Test.Data;
using VNR_InternShip_Technical_Test.Data.Entities;

namespace VNR_InternShip_Technical_Test.Services
{
    public class CourseService : ICourseService
    {
        private readonly VNR_Technical_Test_Context _context;

        public CourseService(VNR_Technical_Test_Context context) 
        {
            _context = context;
        }
        public async Task<List<KhoaHoc>> GetAllCourse()
        {
            var khoahoc = await _context.KhoaHoc.ToListAsync();
            return khoahoc;
        }

        public async Task<KhoaHoc> GetCourse(int id)
        {
            var khoahoc = await _context.KhoaHoc.FindAsync(id);
            return khoahoc;
        }

        public async Task<List<MonHoc>> GetSubject(int id)
        {
            var monhoc = await _context.MonHoc.Where(x => x.KhoaHocID == id).ToListAsync();
            return monhoc;
        }
    }
}
