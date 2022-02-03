using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("nhap ho ten");
        string ho_ten = Console.ReadLine();
        double toan = XL_CHUOI.nhap("toan");
        double van = XL_CHUOI.nhap("van");
        string kq = $"ho va ten: {ho_ten} \ndiem toan: {toan} \ndiem van: {van} \ndiem tb: {XL_CHUOI.diemtb(toan, van)}";
        Console.WriteLine(kq);
    }
}
