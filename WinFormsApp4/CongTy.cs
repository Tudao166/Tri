using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class CongTy
    {
        public string ID { get; set; }
        public Image HinhAnh { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public string Gmail { get; set; }
        public string Website { get; set; }
        public string TruSo { get; set; }
        public string GiayPhepKinhDoanh { get; set; }
        public string MaSoThue { get; set; }
        public string NguoiDungDau { get; set; }
        public DateTime NgayThanhLap { get; set; }
        public CongTy()
        {
        }
        public CongTy(string id,Image hinhanh, string ten, string sdt, string gmail, string website, string truso, string giayphepkinhdoanh, string nguoidungdau, string masothue, DateTime ngaythanhlap)
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
            GiayPhepKinhDoanh = giayphepkinhdoanh;
            NguoiDungDau = nguoidungdau;
        }
        public string GetFullName()
        {
            return Ten;
        }

        // Example method


    }
}
