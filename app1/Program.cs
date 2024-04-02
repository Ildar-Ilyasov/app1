class Programm {
    public static void Main(String[] args)
    {
        Console.WriteLine("Введите m");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите n");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int x = m; x <= n; x++)
        {
            double num = Math.Pow(x, Math.Sqrt(x));
            if(num % 1 == 0)
            {
                Console.WriteLine(x);
            }
        }
    }
}
