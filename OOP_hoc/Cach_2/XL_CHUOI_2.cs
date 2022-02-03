using System;

class hoc_sinh
{
    public string ho_ten;
    public double toan;
    public double van;
    public double dtb;
}
class XL_CHUOI_2
{
    public static void kq()
    {
        Console.Write("nhap ten lop: ");
        string ten_lop = Console.ReadLine();

        Console.Write("nhap so luong: ");
        int so_luong = int.Parse(Console.ReadLine());
        hoc_sinh[] A = new hoc_sinh[so_luong];

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = new hoc_sinh();
            Console.Write("nhap ho ten: ");
            A[i].ho_ten  = Console.ReadLine();
            A[i].toan = nhap("toan");
            A[i].van = nhap("van");
            A[i].dtb = diemtb(A[i].toan, A[i].van);
        }

        string kq = $"ten lop: {ten_lop}, so luong: {so_luong} \n";
        foreach (hoc_sinh item in A)
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
