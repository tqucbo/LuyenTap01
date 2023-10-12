using System.Runtime.Intrinsics;

namespace NameSpaceVector
{
    public delegate void hienThiThongBao(string thongBao);
    class Vector
    {
        public double a;
        public double b;
        public Vector(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public Vector()
        {
            this.a = 0;
            this.b = 0;
        }

        public void nhapVector()
        {
            Console.WriteLine("Nhap toa do a : ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do b : ");
            b = double.Parse(Console.ReadLine());
        }

        // public string xuatVector()
        // {
        //     return $"Vecto co toa do ({a}, {b})";
        // }
        public static void xuatThongTin(string s) => Console.WriteLine(s);
        // public static Vector tinhTong2Vector(Vector v1, Vector v2)
        // {
        //     Vector v3 = new Vector();
        //     v3.a = v1.a + v2.a;
        //     v3.b = v1.b + v2.b;
        //     return v3;
        // }
        public static Vector tinhTong2Vector(Vector v1, Vector v2) => new Vector(v1.a + v2.a, v1.b + v2.b);
        // public static Vector tinhHieu2Vector(Vector v1, Vector v2)
        // {
        //     Vector v3 = new Vector();
        //     v3.a = v1.a - v2.a;
        //     v3.b = v1.b - v2.b;
        //     return v3;
        // }
        public static Vector tinhHieu2Vector(Vector v1, Vector v2) => new Vector(v1.a - v2.a, v1.b - v2.b);

        // public static double tinhTichVoHuong2Vector(Vector v1, Vector v2)
        // {
        //     double kq;
        //     double doDaiV1 = Math.Sqrt(v1.a * v1.a + v1.b * v1.b);
        //     Console.WriteLine(doDaiV1);
        //     double doDaiV2 = Math.Sqrt(v2.a * v2.a + v2.b * v2.b);
        //     Console.WriteLine(doDaiV2);
        //     double cosV1V2 = (v1.a * v2.a + v1.b * v2.b) / (Math.Sqrt(v1.a * v1.a + v1.b * v2.b) + Math.Sqrt(v2.a * v2.a + v2.b * v2.b));
        //     Console.WriteLine(cosV1V2);
        //     kq = doDaiV1 * doDaiV2 * cosV1V2;
        //     return kq;
        // }

        public static void tinhTichVoHuong2Vector(Vector v1, Vector v2, int gocGiua2Vector, hienThiThongBao thongBao)
        {
            double doDaiV1 = Math.Sqrt(v1.a * v1.a + v1.b * v1.b);
            double doDaiV2 = Math.Sqrt(v2.a * v2.a + v2.b * v2.b);
            double cosV1V2 = Math.Cos(gocGiua2Vector / 180 * Math.PI);
            // Console.WriteLine(1 / 2 * Math.PI);
            thongBao.Invoke($"Tich vo huong cua 2 Vecto vua nhap co gia tri la {doDaiV1 * doDaiV2 * cosV1V2}");
        }
    }
}