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
        public DanhBa()
        {
            
        }

        public DanhBa(List<ThueBao> dsThueBao)
        {
            danhSachThueBao = dsThueBao;
        }
        // diachi-thanhpho
        //phuonwg8-DaLat
        // Tìm thành phố có nhiều thuê bao nhất
        public List<ThueBao> TimThueBaoCuaThanhPho(string thanhPho)
        {
            var dsLocalTB = new List<ThueBao>();
            foreach(var thueBao in  danhSachThueBao)
            {
                //nếu địa chỉ của thuê bao có chứa (contains) thành phố thì gán đối tượng đó vào localThueBao
                if (thueBao.diaChi.Contains(thanhPho))
                {
                    dsLocalTB.Add(thueBao);
                }
            }
            return dsLocalTB;
        }

        //turyen doi tuong
        //truyen dia chi

       
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<ThueBao> danhSachThueBao = new List<ThueBao>();
            danhSachThueBao.Add(new ThueBao("p6-Đà Nẵng", ThueBao.GioiTinh.Nam, "Nguyen Van A", new DateTime(1990, 1, 1), "0123456789", "123456789"));
            danhSachThueBao.Add(new ThueBao("p6-Đà Nẵng", ThueBao.GioiTinh.Nu, "Nguyen Van B", new DateTime(1995, 2, 2), "0123456789", "123456789"));
           
            DanhBa danhBa = new DanhBa();
            danhBa.danhSachThueBao = danhSachThueBao;
            List<ThueBao> thueBaoTheoThanhPho = danhBa.TimThueBaoCuaThanhPho("Đà Nẵng");
            foreach (var item in thueBaoTheoThanhPho)
            {
                Console.WriteLine(item.hoTen);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
