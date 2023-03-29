using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    enum GioiTinh { Nam, Nu, Khac };

    class ThueBao
    {
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
    class DanhBa
    {
        public List<ThueBao> danhSachThueBao;

        public DanhBa(List<ThueBao> dsThueBao)
        {
            danhSachThueBao = dsThueBao;
        }
        // Tìm thành phố có nhiều thuê bao nhất
        public string TimThanhPhoNhieuThueBaoNhat()
        {
          
        }
        public string TimThanhPhoItThueBaoNhat()
        {
          
        }
        // Tìm thuê bao sở hữu ít số điện thoại nhất
        public ThueBao TimThueBaoItSDTNhat()
        {
           
        }

        // Sắp xếp khách hàng theo họ tên (tăng dần hoặc giảm dần)
        public ThueBao[] SapXepTheoHoTen(bool tangDan)
        {
          
        }

        // Sắp xếp khách hàng theo số lượng số điện thoại sở hữu (tăng dần hoặc giảm dần)
        public ThueBao[] SapXepTheoSoDT(bool tangDan)
        {
           
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
