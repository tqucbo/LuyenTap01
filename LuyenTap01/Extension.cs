using NameSpaceVector;

namespace ExtensionVector
{
    public static class ExtensionVector
    {
        public static void inToaDoA(this Vector v1) => Console.WriteLine($"Toa do a : {v1.a}");

        public static void inToaDoB(this Vector v1) => Console.WriteLine($"Toa do b : {v1.b}");

        public static void inVector(this Vector v1) => Console.WriteLine($"Vector : ({v1.a}, {v1.b})");

        public static void inVectorDao(this Vector v1) => Console.WriteLine($"Vector : ({v1.b}, {v1.a})");
    }
}