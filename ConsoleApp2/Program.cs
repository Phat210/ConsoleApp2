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
            Dictionary<string, int> cityCountDict = new Dictionary<string, int>();
            foreach (ThueBao thueBao in danhSachThueBao)
            {
                if (cityCountDict.ContainsKey(thueBao.diaChi))
                {
                    cityCountDict[thueBao.diaChi]++;
                }
                else
                {
                    cityCountDict.Add(thueBao.diaChi, 1);
                }
            }
            return cityCountDict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        }
        public string TimThanhPhoItThueBaoNhat()
        {
            Dictionary<string, int> cityCountDict = new Dictionary<string, int>();
            foreach (ThueBao thueBao in danhSachThueBao)
            {
                if (cityCountDict.ContainsKey(thueBao.diaChi))
                {
                    cityCountDict[thueBao.diaChi]++;
                }
                else
                {
                    cityCountDict.Add(thueBao.diaChi, 1);
                }
            }
            return cityCountDict.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
        }
        // Tìm thuê bao sở hữu ít số điện thoại nhất
        public ThueBao TimThueBaoItSDTNhat()
        {
            return danhSachThueBao.OrderBy(t => t.sDT.Length).FirstOrDefault();
        }

        // Sắp xếp khách hàng theo họ tên (tăng dần hoặc giảm dần)
        public ThueBao[] SapXepTheoHoTen(bool tangDan)
        {
            if (tangDan)
            {
                return danhSachThueBao.OrderBy(t => t.hoTen).ToArray();
            }
            else
            {
                return danhSachThueBao.OrderByDescending(t => t.hoTen).ToArray();
            }
        }

        // Sắp xếp khách hàng theo số lượng số điện thoại sở hữu (tăng dần hoặc giảm dần)
        public ThueBao[] SapXepTheoSoDT(bool tangDan)
        {
            if (tangDan)
            {
                return danhSachThueBao.OrderBy(t => t.sDT.Length).ToArray();
            }
            else
            {
                return danhSachThueBao.OrderByDescending(t => t.sDT.Length).ToArray();
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<ThueBao> arr = new List<ThueBao>()
            {
                new ThueBao() { diaChi = "Hà Nội", gioiTinh = GioiTinh.Nam, hoTen = "Nguyễn Văn A", ngaySinh = DateTime.Now.AddYears(-30), sDT = "123456789", soCMND = "0123456789" },
                new ThueBao() { diaChi = "Đà Nẵng", gioiTinh = GioiTinh.Nu, hoTen = "Trần Thị B", ngaySinh = DateTime.Now.AddYears(-25), sDT = "4567", soCMND = "9876543210" },
                new ThueBao() { diaChi = "Hồ Chí Minh", gioiTinh = GioiTinh.Khac, hoTen = "Lý Tấn C", ngaySinh = DateTime.Now.AddYears(-40), sDT = "987654321", soCMND = "1111111111" }
            };

            DanhBa danhBa = new DanhBa(arr);
            string thanhPhoNhieuNhat = danhBa.TimThanhPhoNhieuThueBaoNhat();
            string thanhPhoItNhat = danhBa.TimThanhPhoItThueBaoNhat();
            ThueBao thueBaoItSDTNhat = danhBa.TimThueBaoItSDTNhat();
            ThueBao[] sapXepTheoHoTenTangDan = danhBa.SapXepTheoHoTen(true);
        }
    }
}
