using System;
namespace WinFormsApp4
{
    public class CV
    {

        public Image HinhAnh { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string TrinhDo { get; set; }
        public string Truong { get; set; }
        public string XepLoai { get; set; }
        public string Khoa { get; set; }
        public string KyNang { get; set; }
        public string GiaiThuong { get; set; }
        public string KinhNghiem { get; set; }
        public string CongViec { get; set; }
        public string ChucVu { get; set; }
        public string LichSuLamViec { get; set; }
        public string KyNangKhac { get; set; }
        public string MaCongTy { get; set; }
        public string ID { get; set; }
        public int LikeCount {  get; set; }

        // Constructor
        public CV()
        {
        }

        // Constructor with parameters
        public CV(string id,Image hinhanh, string ten, string gioitinh, DateTime ngaySinh, string email, string soDienThoai, string diaChi, string trinhdo, string truong, string xeploai, string khoa, string kynang, string giaithuong, string kinhnghiem, string congviec, string chucvu, string lichsu, string kynangkhac)
        {
            ID = id;
            HinhAnh = hinhanh;
            HoTen = ten;
            GioiTinh = gioitinh;
            NgaySinh = ngaySinh;
            Email = email;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
            TrinhDo = trinhdo;
            Truong = truong;
            XepLoai = xeploai;
            Khoa = khoa;
            KyNang = kynang;
            KinhNghiem = kinhnghiem;
            ChucVu = chucvu;
            CongViec = congviec;
            LichSuLamViec = lichsu;
            KyNangKhac = kynangkhac;
            GiaiThuong = giaithuong;

        }
        public CV(string id, Image hinhanh, string ten, string gioitinh, DateTime ngaySinh, string email, string soDienThoai, string diaChi, string trinhdo, string truong, string xeploai, string khoa, string kynang, string giaithuong, string kinhnghiem, string congviec, string chucvu, string lichsu, string kynangkhac,int likecount)
        {
            ID = id;
            LikeCount = likecount;
            HinhAnh = hinhanh;
            HoTen = ten;
            GioiTinh = gioitinh;
            NgaySinh = ngaySinh;
            Email = email;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
            TrinhDo = trinhdo;
            Truong = truong;
            XepLoai = xeploai;
            Khoa = khoa;
            KyNang = kynang;
            KinhNghiem = kinhnghiem;
            ChucVu = chucvu;
            CongViec = congviec;
            LichSuLamViec = lichsu;
            KyNangKhac = kynangkhac;
            GiaiThuong = giaithuong;

        }


        public string GetFullName()
        {
            return HoTen;
        }
    }
}
