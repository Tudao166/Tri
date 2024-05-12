using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class LichSuUngTuyen
    {
        public string IDCV { get; set; }
        public string HinhThuc {  get; set; }
        public string IDTinDang {  get; set; }
        public string IDCongTy { get; set; }
        public Image AnhCongTy { get; set; }
        public Image AnhUngVien { get; set; }
        public string TenCongTy { get; set; }
        public string TenNguoiUngTuyen { get; set; }
        public DateTime NgayUngTuyen { get; set; }
        public string DiaDiem {  get; set; }
        public string TenCongViec { get; set; }
        public string ChucVu {  get; set; }
        public string LuongMin {  get; set; }
        public string LuongMax { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu {  get; set; }

        public LichSuUngTuyen(string idcv, string idtindang, string idcongty, Image anhcongty, string tencongty,string tennguoiungtuyen,string hinhthuc, DateTime ngayungtuyen, string diadiem, string chucvu, string luongmin,string luongmax, string trangthai,string ghichu)
        {
            this.GhiChu = ghichu;
            this.TenNguoiUngTuyen = tennguoiungtuyen;
            this.IDCV = idcv;
            this.IDTinDang = idtindang;
            this.IDCongTy = idcongty;
            this.AnhCongTy = anhcongty;
            this.TenCongTy = tencongty;
            this.NgayUngTuyen = ngayungtuyen;
            this.DiaDiem = diadiem;
            this.ChucVu = chucvu;
            this.LuongMin = luongmin;
            this.LuongMax = luongmax;
            this.TrangThai = trangthai;
            this.HinhThuc = hinhthuc;
        }
        public LichSuUngTuyen(string idcv, string idtindang, string idcongty, Image anhcongty, string tencongty, string tennguoiungtuyen, string hinhthuc, string diadiem, string chucvu, string luongmin, string luongmax, string trangthai)
        {
            this.TenNguoiUngTuyen = tennguoiungtuyen;
            this.IDCV = idcv;
            this.IDTinDang = idtindang;
            this.IDCongTy = idcongty;
            this.AnhCongTy = anhcongty;
            this.TenCongTy = tencongty;
            this.DiaDiem = diadiem;
            this.ChucVu = chucvu;
            this.LuongMin = luongmin;
            this.LuongMax = luongmax;
            this.TrangThai = trangthai;
            this.HinhThuc = hinhthuc;
        }
        public LichSuUngTuyen(string idcv, string idtindang, string idcongty)
        {
            this.IDCV = idcv;
            this.IDTinDang = idtindang;
            this.IDCongTy = idcongty;
       
        }
    }
    
}
