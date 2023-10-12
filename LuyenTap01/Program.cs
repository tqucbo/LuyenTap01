using NameSpaceVector;

namespace LuyenTap01;
class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector();
        v1.nhapVector();
        Console.WriteLine(v1.xuatVector());
        Vector v2 = new Vector();
        v2.nhapVector();
        Console.WriteLine(v2.xuatVector());

    // Vector v3 = Vector.tinhTong2Vector(v1, v2);
    // Console.WriteLine($"Tong 2 Vector vua nhap : " + v3.xuatVector());
    // Vector v4 = Vector.tinhHieu2Vector(v1, v2);
    // Console.WriteLine($"Tong 2 Vector vua nhap : " + v4.xuatVector());
    // double tichVoHuong = Vector.tinhTichVoHuong2Vector(v1, v2);
    // Console.WriteLine($"Tich vo huong 2 Vector vua nhap : {tichVoHuong}");

    L1: Console.WriteLine("Moi nhap lua chon : ");
        Console.WriteLine("1. Tinh tong 2 Vector vua nhap");
        Console.WriteLine("2. Tinh hieu 2 Vector vua nhap");
        Console.WriteLine("3. Tinh tich vo huong 2 Vector vua nhap");
        string switchNumber = Console.ReadLine();
        switch (switchNumber)
        {
            case "1":
                Vector v3 = Vector.tinhTong2Vector(v1, v2);
                Console.WriteLine($"Tong 2 Vector vua nhap : " + v3.xuatVector());
                break;
            case "2":
                Vector v4 = Vector.tinhHieu2Vector(v1, v2);
                Console.WriteLine($"Tong 2 Vector vua nhap : " + v4.xuatVector());
                break;
            case "3":
                double tichVoHuong = Vector.tinhTichVoHuong2Vector(v1, v2);
                Console.WriteLine($"Tich vo huong 2 Vector vua nhap : {tichVoHuong}");
                break;
            default:
                Console.WriteLine("Khong co lua chon nay.");
                break;
        }
    }
}
