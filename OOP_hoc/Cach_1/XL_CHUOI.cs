using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class XL_CHUOI
{
    public static double nhap(string value)
    {
        Console.WriteLine($"nhap diem {value} ");
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
