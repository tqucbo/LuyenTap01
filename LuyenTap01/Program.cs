using NameSpaceVector;

namespace LuyenTap01;
class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector();
        v1.nhapVector();
        v1.xuatVector();
        Vector v2 = new Vector();
        v2.nhapVector();
        v2.xuatVector();
        Vector v3 = Vector.tinhTong2Vector(v1, v2);
        Console.WriteLine($"Tong 2 Vector vua nhap : " + v3.xuatVector());
        Vector v4 = Vector.tinhHieu2Vector(v1, v2);
        Console.WriteLine($"Tong 2 Vector vua nhap : " + v4.xuatVector());
        double tichVoHuong = Vector.tinhTichVoHuong2Vector(v1, v2);
        Console.WriteLine($"Tich vo huong 2 Vector vua nhap : {tichVoHuong}");
    }
}
