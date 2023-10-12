namespace NameSpaceVector
{
    class Vector
    {
        double a;
        double b;
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

        public string xuatVector()
        {
            return $"Vecto co toa do ({a}, {b})";
        }
        public static Vector tinhTong2Vector(Vector v1, Vector v2)
        {
            Vector v3 = new Vector();
            v3.a = v1.a + v2.a;
            v3.b = v1.b + v2.b;
            return v3;
        }
        public static Vector tinhHieu2Vector(Vector v1, Vector v2)
        {
            Vector v3 = new Vector();
            v3.a = v1.a - v2.a;
            v3.b = v1.b - v2.b;
            return v3;
        }
        public static double tinhTichVoHuong2Vector(Vector v1, Vector v2)
        {
            double kq;
            double doDaiV1 = Math.Sqrt(v1.a * v1.a + v1.b * v1.b);
            double doDaiV2 = Math.Sqrt(v1.a * v1.a + v1.b * v1.b);
            double cosV1V2 = (v1.a * v2.a + v1.b * v2.b) / (Math.Sqrt(v1.a * v1.a + v1.b * v2.b) + Math.Sqrt(v2.a * v2.a + v2.b * v2.b));
            kq = doDaiV1 * doDaiV2 * cosV1V2;
            return kq;
        }

    }
}