using VNR_InternShip_Technical_Test.Data.Entities;

namespace VNR_InternShip_Technical_Test.Services
{
    public interface ICourseService
    {
        Task<List<KhoaHoc>> GetAllCourse();
        Task<List<MonHoc>> GetSubject(int id);
        Task<KhoaHoc> GetCourse(int id);
    }
}
