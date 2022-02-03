using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class XL_CHUOI
{
    public struct lop_hoc
    {
        public string ten_lop;
        public int so_luong;
        public hoc_sinh[] ds_lop;
    }
    public struct hoc_sinh
    {
        public string ho_ten;
        public double toan;
        public double van;
        public double dtb;
    }
    public static lop_hoc nhap_lop_hoc()
    {
        lop_hoc A;
        Console.Write("nhap ten lop: ");
        A.ten_lop = Console.ReadLine();
        Console.Write("nhap so luong: ");
        A.so_luong = int.Parse(Console.ReadLine());
        A.ds_lop = new hoc_sinh[A.so_luong];
        for (int i = 0; i < A.ds_lop.Length; i++)
        {
            Console.Write("nhap ho ten: ");
            A.ds_lop[i].ho_ten = Console.ReadLine();
            A.ds_lop[i].toan = nhap("toan");
            A.ds_lop[i].van = nhap("van");
            A.ds_lop[i].dtb = diemtb(A.ds_lop[i].toan, A.ds_lop[i].van);
        }
        return A;
    }
    public static void kq ()
    {
        lop_hoc A = nhap_lop_hoc();
        string kq = $"ten lop: {A.ten_lop}, so luong: {A.so_luong} \n";
        foreach (hoc_sinh item in A.ds_lop)
        {
            kq = kq + $"ho ten: {item.ho_ten}, diem toan: {item.toan}, diem van: {item.van}, diemtb: {item.dtb} \n";
        }
        Console.WriteLine(kq);
    }
    public static double nhap(string value)
    {
        Console.Write($"nhap diem {value}:  ");
        double diem = int.Parse(Console.ReadLine());
        if (diem < 0 || diem > 10)
        {
            return nhap(value);
        }
        return diem;
    }
    public static double diemtb(double diem_toan, double diem_van)
    {
        return (diem_toan + diem_van) / 2;
    }
}
