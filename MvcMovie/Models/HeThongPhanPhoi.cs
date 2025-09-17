namespace MvcMovie.Models
{
    public class HeThongPhanPhoi
    {
        public int Id { get; set; }   // Khóa chính
        public string MaHTPP { get; set; }
        public string TenHTPP { get; set; }

        // Navigation property: 1 HTPP có nhiều đại lý
        public List<DaiLy> DaiLys { get; set; } = new List<DaiLy>();
    }
}
