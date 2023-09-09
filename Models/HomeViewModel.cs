using VNR_InternShip_Technical_Test.Data.Entities;

namespace VNR_InternShip_Technical_Test.Models
{
    public class HomeViewModel
    {
        public List<KhoaHoc> KhoaHocs { get; set; }
        public List<MonHoc>? MonHocs { get; set; }
        public KhoaHoc? KhoaHoc { get; set; }
    }
}
