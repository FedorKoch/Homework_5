Console.Clear();
double max = 0;
double min = 0;
double raz = 0;
Random rnd = new Random();
Console.WriteLine("введите количество элементов массива");
int a = int.Parse(Console.ReadLine());
double[] mas = new double[a];
for (int i = 0; i < mas.Length; i++)
{
mas[i] = Math.Round(rnd.NextDouble() * 50, 2);
Console.Write("{0} ", mas[i]);
}
max = mas.Max();
min = mas.Min();
raz = max - min;
Console.WriteLine();
Console.WriteLine("Разность максиимального и минимального элемента равна");
Console.WriteLine(Math.Round(raz, 2));