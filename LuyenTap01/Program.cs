using ExtensionVector;
using NameSpaceVector;

namespace LuyenTap01;
class Program
{

    static void Main(string[] args)
    {
        Action<string> action = Vector.xuatThongTin;
    L2: Vector v1 = new Vector();
        // v1.nhapVector();
        if (v1.nhapVector())
        {
            action.Invoke($"Vecto co toa do la : ({v1.a}, {v1.b})");
        }
        else
        {
            Console.WriteLine("Moi nhap lai Vecto 1");
            goto L2;
        }
    // Console.WriteLine(v1.xuatVector());
    // action.Invoke($"Vecto 1 co toa do la : ({v1.a}, {v1.b})");
    L3: Vector v2 = new Vector();
        if (v2.nhapVector())
        {
            action.Invoke($"Vecto co toa do la : ({v2.a}, {v2.b})");
        }
        else
        {
            Console.WriteLine("Moi nhap lai Vecto 2");
            goto L3;
        }
        // Console.WriteLine(v2.xuatVector());
        // action.Invoke($"Vecto 2 co toa do la : ({v2.a}, {v2.b})");
        Console.WriteLine("Nhap so do goc giua 2 Vecto : ");
        int gocGiua2Vector = int.Parse(Console.ReadLine());
        action.Invoke($"Goc giua 2 Vecto la {gocGiua2Vector} do.");
        List<Vector> vectors = new List<Vector>() { };


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
        Console.WriteLine("4. Dua 2 Vector vao mang, thoat khoi Swtich - Case nay de lam bai tap mang.");
        Console.WriteLine("all. Thuc hien ca 3 phuong thuc tren");
        Console.WriteLine("exit. Thoat");
        string switchNumber = Console.ReadLine();
        switch (switchNumber)
        {
            case "1":
                // Vector v3 = Vector.tinhTong2Vector(v1, v2);
                // Console.WriteLine($"Tong 2 Vector vua nhap : " + v3.xuatVector());
                // // break;

                // Func<Vector, Vector, Vector> tinhTong = Vector.tinhTong2Vector;
                // Console.WriteLine($"Tong cua 2 Vector vua nhap la mot Vector co toa do la : ({tinhTong(v1, v2).a}, {tinhTong(v1, v2).b})");

                Vector v3 = v1 + v2;
                action.Invoke($"Tong cua 2 Vector vua nhap la mot Vector co toa do la ({v3.a}, {v3.b})");
                goto L1;
            case "2":
                // Vector v4 = Vector.tinhHieu2Vector(v1, v2);
                // Console.WriteLine($"Tong 2 Vector vua nhap : " + v4.xuatVector());
                // // break;

                // Func<Vector, Vector, Vector> tinhHieu = Vector.tinhHieu2Vector;
                // Console.WriteLine($"Hieu cua 2 Vector vua nhap la mot Vector co toa do la : ({tinhHieu(v1, v2).a}, {tinhHieu(v1, v2).b})");

                v3 = v1 + v2;
                action.Invoke($"Hieu cua 2 Vector vua nhap la mot Vector co toa do la ({v3.a}, {v3.b})");
                goto L1;
            case "3":

                Vector.tinhTichVoHuong2Vector(v1, v2, gocGiua2Vector, Vector.xuatThongTin);
                // double tichVoHuong = Vector.tinhTichVoHuong2Vector(v1, v2);
                // Console.WriteLine($"Tich vo huong 2 Vector vua nhap : {tichVoHuong}");
                // break;
                goto L1;
            case "4":
                vectors.Add(v1);
                vectors.Add(v2);
                vectors.Add(new Vector(0, 0));
                break;
            case "all":
            case "a":
                // tinhTong = Vector.tinhTong2Vector;
                // Console.WriteLine($"Tong cua 2 Vector vua nhap la mot Vector co toa do la : ({tinhTong(v1, v2).a}, {tinhTong(v1, v2).b})");
                // tinhHieu = Vector.tinhHieu2Vector;
                // Console.WriteLine($"Hieu cua 2 Vector vua nhap la mot Vector co toa do la : ({tinhHieu(v1, v2).a}, {tinhHieu(v1, v2).b})");

                v3 = v1 + v2;
                action.Invoke($"Tong cua 2 Vector vua nhap la mot Vector co toa do la ({v3.a}, {v3.b})");
                v3 = v1 - v2;
                action.Invoke($"Hieu cua 2 Vector vua nhap la mot Vector co toa do la ({v3.a}, {v3.b})");

                Vector.tinhTichVoHuong2Vector(v1, v2, gocGiua2Vector, Vector.xuatThongTin);
                // break;
                goto L1;
            case "exit":
                break;
            default:
                action.Invoke("Khong co thong tin nay");
                goto L1;
        }
        while (true)
        {
            Console.WriteLine("Moi nhap them Vector moi, nhap toa do la chu de thoat.");
            Vector v = new Vector();
            if (v.nhapVector())
            {
                action.Invoke($"Vecto co toa do la : ({v.a}, {v.b})");
                vectors.Add(v);
            }
            else
            {
                break;
            }
        }
    L4: Console.WriteLine("Moi nhap lua chon : ");
        Console.WriteLine("1. Hien thi toa do X cua tat ca phan tu");
        Console.WriteLine("2. Hien thi toa do Y cua tat ca phan tu");
        Console.WriteLine("3. Hien thi Vector");
        Console.WriteLine("4. Hien thi Vector dao");
        Console.WriteLine("Nhap ky tu khac. Thoat");
        switchNumber = Console.ReadLine();
        switch (switchNumber)
        {
            case "1":
                vectors.ToList().ForEach((v) => v.inToaDoA());
                goto L4;
            case "2":
                vectors.ToList().ForEach((v) => v.inToaDoB());
                goto L4;
            case "3":
                vectors.ToList().ForEach((v) => v.inVector());
                goto L4;
            case "4":
                vectors.ToList().ForEach((v) => v.inVectorDao());
                goto L4;
            case "5":
                var filename = "vectors.txt";
                string content = "";
                vectors.ToList().ForEach((v) => content += $"({v.a}, {v.b})\n");
                File.WriteAllText(filename, content);
                Console.WriteLine(Path.GetFullPath(filename));
                goto L4;
            default:
                break;

        }
        var kq = from vector in vectors where vector.a % 2 == 0 select vector;
        double tongToaDoX = 0;
        kq.ToList().ForEach((v) =>
        {
            tongToaDoX += v.a;
            v.inVector();
        });
        Console.WriteLine("---");
        kq = from vector in vectors where vector.b > 5 select vector;
        double tongToaDoY = 0;
        kq.ToList().ForEach((v) =>
        {
            tongToaDoY += v.b;
            v.inVector();
        });

        double trungBinhToaDoY = tongToaDoY / kq.ToList().Count;

        Vector vBaiTap = new Vector(tongToaDoX, trungBinhToaDoY);
        vBaiTap.inVector();
    }
}
