using System;
namespace WinFormsApp4
{
    public class CV
    {
        public byte[] HinhAnh { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string TrinhDo { get; set; }
        public string Truong { get; set; }
        public string XepLoai { get; set; }
        public string Khoa { get; set; }
        public string KyNang { get; set; }
        public string GiaiThuong { get; set; }
        public DateTime? NgayLamViec { get; set; }
        public DateTime? NgayNghiViec { get; set; }
        public string CongViec { get; set; }
        public string ChucVu { get; set; }
        public string LichSuLamViec { get; set; }
        public string KyNangKhac { get; set; }
        public string MaCongTy { get; set; }
        public string ID { get; set; }

        // Constructor
        public CV()
        {
        }

        // Constructor with parameters
        public CV(byte[] hinhanh,string hoTen, DateTime? ngaySinh, string email, string soDienThoai, string diaChi, string id)
        {
            HinhAnh = hinhanh; ;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            Email = email;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
            ID = id;
        }

        // Example method
        public string GetFullName()
        {
            return HoTen;
        }

        // Example method
        public int CalculateAge()
        {
            if (NgaySinh.HasValue)
            {
                DateTime now = DateTime.Now;
                int age = now.Year - NgaySinh.Value.Year;
                if (now < NgaySinh.Value.AddYears(age))
                {
                    age--;
                }
                return age;
            }
            else
            {
                return -1; // Indicate unknown age
            }
        }
    }

}
