using Service;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите значения a, b, c по порядку через Enter. Числа с плавающей точкой через запятую -10,7");
        var parameters = new List<double>();
        for (int i = 0; i < 3; i++)
        {
            if (double.TryParse(Console.ReadLine(), out var userIn))
                parameters.Add(userIn);
            else
            {
                Console.WriteLine("Неверный формат, введите еще раз");
                i--;
            }
        }

        var result = QuadraticSolver.Solve(parameters[0], parameters[1], parameters[2]);
        Console.WriteLine($"x1:{result.Value.x1}");
        Console.WriteLine($"x2:{result.Value.x2}");
    }
}