using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{

    public class TinDang
    {
        public string ten;
        public string luongmin;
        public string luongmax;
        public Image hinhanh;
        public string sodt;
        public string gmail;
        public string website;
        public string noilamviec;
        public string nganhnghe;
        public string chucvu;
        public string hinhthuclamviec;
        public string mota;
        public string kynang;
        public string phucloi;
        public string kinhnghiem;
        public DateTime ngaydang;
        public string idtindang;
        public string idcv;
        public string idct;
        public int likeCount;


        public TinDang(Image hinhanh, string ten, string sodt, string gmail, string website, string noilamviec, string nganhnghe, string chucvu, string hinhthuclamviec, string luongmin, string luongmax, string kinhnghiem, string mota, string kynang, string phucloi, string idct,string idcv, string idtindang, DateTime ngaydang, int likecount)
        {
            this.idcv = idcv;                                                                                       
            this.idct = idct;
            this.hinhanh = hinhanh;
            this.ten = ten;
            this.kynang = kynang;
            this.nganhnghe = nganhnghe;
            this.chucvu = chucvu;
            this.sodt = sodt;
            this.gmail = gmail;
            this.website = website;
            this.phucloi = phucloi;
            this.noilamviec = noilamviec;
            this.hinhthuclamviec = hinhthuclamviec;
            this.mota = mota;
            this.luongmax = luongmax;
            this.luongmin = luongmin;
            this.kinhnghiem = kinhnghiem;
            this.ngaydang = ngaydang;
            this.idtindang = idtindang;
            this.likeCount = likecount;
        }
        public TinDang(Image hinhanh, string ten, string sodt, string gmail, string website, string noilamviec, string nganhnghe, string chucvu, string hinhthuclamviec, string luongmin,string luongmax, string kinhnghiem, string mota, string kynang, string phucloi, string idct)
        {
            this.idct = idct;
            this.hinhanh = hinhanh;
            this.ten = ten;
            this.kynang = kynang;
            this.nganhnghe = nganhnghe;
            this.chucvu = chucvu;
            this.sodt = sodt;
            this.gmail = gmail;
            this.website = website;
            this.phucloi = phucloi;
            this.noilamviec = noilamviec;
            this.hinhthuclamviec = hinhthuclamviec;
            this.mota = mota;
            this.luongmin = luongmin;
            this.luongmax = luongmax;
            this.kinhnghiem = kinhnghiem;
        }
        public TinDang(Image hinhanh, string ten, string sodt, string gmail, string website, string noilamviec, string nganhnghe, string chucvu, string hinhthuclamviec, string luongmin, string luongmax, string kinhnghiem, string mota, string kynang, string phucloi,string idct, string    idtindang)
        {
            this.idct = idct;
            this.hinhanh = hinhanh;
            this.ten = ten;
            this.kynang = kynang;
            this.nganhnghe = nganhnghe;
            this.chucvu = chucvu;
            this.sodt = sodt;
            this.gmail = gmail;
            this.website = website;
            this.phucloi = phucloi;
            this.noilamviec = noilamviec;
            this.hinhthuclamviec = hinhthuclamviec;
            this.mota = mota;
            this.luongmin = luongmin;
            this.luongmax = luongmax;
            this.kinhnghiem = kinhnghiem;
            this.idtindang = idtindang;
        }
    }
}
