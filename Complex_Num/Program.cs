namespace kursovayafor
{
    class Complex
    {
        public double r, i;

        public static string Sum(double a1, double b1, double a2, double b2) => Convert.ToString($"Результат сложения: {a1 + a2} {b1 + b2}i");
        public static string Subtraction(double a1, double b1, double a2, double b2) => Convert.ToString($"Результат вычитания: {a1 - a2} {b1 - b2}i");
        public static string Multiply(double a1, double b1, double a2, double b2) => Convert.ToString($"Результат умножения: {a1 * a2 - b1 * b2} {b1 * a2 + a1 * b2}i");
        public static string Division(double a1, double b1, double a2, double b2) => Convert.ToString($"Результат деления: {a1 * a2 + b1 * b2/(a2 * a2 + b2 * b2)} {b1 * a2 - a1 * b2/(a2 * a2 + b2 * b2)}i");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new();
            Complex c2 = new();

            Console.WriteLine("Введите первое комплексное число в формате {a bi}");
            string str = Console.ReadLine();

            c1.r = Convert.ToDouble (str.Split(" ")[0]);
            c1.i = Convert.ToDouble(str.Replace("i", "").Split(" ")[1]);

            Console.WriteLine("Введите второе комплексное число в формате {a bi}");
            str = Console.ReadLine();

            c2.r = Convert.ToDouble(str.Split(" ")[0]);
            c2.i = Convert.ToDouble(str.Replace("i", "").Split(" ")[1]);

            Console.WriteLine("Действия с комплексными числами: " +
                $"\nСложение: {Complex.Sum(c1.r, c1.i, c2.r, c2.i)}\n" +
                $"\nВычитание: {Complex.Subtraction(c1.r, c1.i, c2.r, c2.i)}" +
                $"\nУмножение: {Complex.Multiply(c1.r, c1.i, c2.r, c2.i)}" +
                $"\nДеление: {Complex.Division(c1.r, c1.i, c2.r, c2.i)}");

        }
    }
}