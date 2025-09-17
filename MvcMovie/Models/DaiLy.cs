namespace MvcMovie.Models
{
    public class DaiLy
    {
        public int Id { get; set; }  // Khóa chính
        public string MaDaiLy { get; set; }
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DienThoai { get; set; }

        // Khóa ngoại
        public int HeThongPhanPhoiId { get; set; }

        // Navigation property
        public HeThongPhanPhoi HeThongPhanPhoi { get; set; }
    }
}
