using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

   

    public class ThueBao
    {
        public enum GioiTinh { Nam, Nu, Khac };
        public ThueBao()
        {

        }

        public ThueBao(string diaChi, GioiTinh gioiTinh, string hoTen, DateTime ngaySinh, string sDT, string soCMND)
        {
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.sDT = sDT;
            this.soCMND = soCMND;
        }
        public string diaChi;
        public GioiTinh gioiTinh;
        public string hoTen;
        public DateTime ngaySinh;
        public string sDT;
        public string soCMND;
        public void Xuat(ThueBao thueBao)
        {
            Console.WriteLine($"Ho ten: {thueBao.hoTen}");
            Console.WriteLine($"Gioi tinh: {thueBao.gioiTinh}");
            Console.WriteLine($"Ngay sinh: {thueBao.ngaySinh.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Dia chi: {thueBao.diaChi}");
            Console.WriteLine($"So dien thoai: {thueBao.sDT}");
            Console.WriteLine($"So CMND: {thueBao.soCMND}");
        }



    }
    public class DanhBa
    {
        public List<ThueBao> danhSachThueBao;
        public string LayThanhPhoCuaDiaChi(string diaChi)
        {
            return diaChi.Split('_')[1];
        }
        public void TimThanhPhoCoNhieuThueBaoNhat(string[] danhSachThanhPho)
        {
            danhSachThueBao.GroupBy(x => x.diaChi);

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Hà Nội", "Đà Nẵng", "Hồ Chí Minh", "Nha Trang", "Huế" };
            DanhBa danhBa = new DanhBa();
            danhBa.TimThanhPhoCoNhieuThueBaoNhat(cities);
        }
    }
}
