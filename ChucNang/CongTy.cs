using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChucNang
{
    public class CongTy
    {
        public string ID { get; set; }
        public byte[] HinhAnh { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public string Gmail { get; set; }
        public string Website { get; set; }
        public string TruSo { get; set; }
        public string GiayPhepKinhDoanh { get; set; }
        public string MaSoThue { get; set; }
        public DateTime? NgayThanhLap { get; set; }
        public CongTy()
        {
        }
        public CongTy(string id, byte[] hinhanh, string ten, string sdt, string gmail, string website, string truso, string giayphepkinhdoanh, string nguoidungdau, string masothue, DateTime? ngaythanhlap)
        {
            ID = id;
            HinhAnh = hinhanh;
            Ten = ten;
            SDT = sdt;
            Gmail = gmail;
            Website = website;
            TruSo = truso;
            MaSoThue = masothue;
            NgayThanhLap = ngaythanhlap;
        }
        public string GetFullName()
        {
            return Ten;
        }

        // Example method
        public int CalculateAge()
        {
            if (NgayThanhLap.HasValue)
            {
                DateTime now = DateTime.Now;
                int age = now.Year - NgayThanhLap.Value.Year;
                if (now < NgayThanhLap.Value.AddYears(age))
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
