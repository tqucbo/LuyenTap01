using NameSpaceVector;

namespace LuyenTap01;
class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector();
        v1.nhapVector();
        // Console.WriteLine(v1.xuatVector());
        Action<string> action = Vector.xuatThongTin;
        action.Invoke($"Vecto 1 co toa do la : ({v1.a}, {v1.b})");
        Vector v2 = new Vector();
        v2.nhapVector();
        // Console.WriteLine(v2.xuatVector());
        action.Invoke($"Vecto 2 co toa do la : ({v2.a}, {v2.b})");
        Console.WriteLine("Nhap so do goc giua 2 Vecto : ");
        int gocGiua2Vector = int.Parse(Console.ReadLine());
        action.Invoke($"Goc giua 2 Vecto la {gocGiua2Vector} do.");


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
        Console.WriteLine("all. Thuc hien ca 3 phuong thuc tren");
        Console.WriteLine("exit. Thoat");
        string switchNumber = Console.ReadLine();
        switch (switchNumber)
        {
            case "1":
                // Vector v3 = Vector.tinhTong2Vector(v1, v2);
                // Console.WriteLine($"Tong 2 Vector vua nhap : " + v3.xuatVector());
                // // break;
                Func<Vector, Vector, Vector> tinhTong = Vector.tinhTong2Vector;
                Console.WriteLine($"Tong cua 2 Vector vua nhap la mot Vector co toa do la : ({tinhTong(v1, v2).a}, {tinhTong(v1, v2).b})");
                goto L1;
            case "2":
                // Vector v4 = Vector.tinhHieu2Vector(v1, v2);
                // Console.WriteLine($"Tong 2 Vector vua nhap : " + v4.xuatVector());
                // // break;
                Func<Vector, Vector, Vector> tinhHieu = Vector.tinhHieu2Vector;
                Console.WriteLine($"Hieu cua 2 Vector vua nhap la mot Vector co toa do la : ({tinhHieu(v1, v2).a}, {tinhHieu(v1, v2).b})");
                goto L1;
            case "3":

                Vector.tinhTichVoHuong2Vector(v1, v2, gocGiua2Vector, Vector.xuatThongTin);
                // double tichVoHuong = Vector.tinhTichVoHuong2Vector(v1, v2);
                // Console.WriteLine($"Tich vo huong 2 Vector vua nhap : {tichVoHuong}");
                // break;
                goto L1;
            case "all":
            case "a":
                tinhTong = Vector.tinhTong2Vector;
                Console.WriteLine($"Tong cua 2 Vector vua nhap la mot Vector co toa do la : ({tinhTong(v1, v2).a}, {tinhTong(v1, v2).b})");
                tinhHieu = Vector.tinhHieu2Vector;
                Console.WriteLine($"Hieu cua 2 Vector vua nhap la mot Vector co toa do la : ({tinhHieu(v1, v2).a}, {tinhHieu(v1, v2).b})");
                Vector.tinhTichVoHuong2Vector(v1, v2, gocGiua2Vector, Vector.xuatThongTin);
                // break;
                goto L1;
            case "exit":
                break;
            default:
                action.Invoke("Khong co thong tin nay");
                goto L1;
        }
    }
}
