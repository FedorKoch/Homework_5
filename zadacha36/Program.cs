Console.Clear();
int sum = 0;
Random rnd = new Random();
Console.WriteLine("введите количество элементов массива");
int a = int.Parse(Console.ReadLine());
int[] mas = new int[a];
for (int i = 0; i < mas.Length; i++)
{
mas[i] = rnd.Next(-100,100); // Указан диапазон для большей наглядности в выводе, на решение задачи не влияет
Console.Write("{0} ", mas[i]);
if (i % 2 != 0)
sum = sum + mas[i];
}
Console.WriteLine();
Console.WriteLine("Сумма лементов, стоящих на нечётных позициях равна");
Console.WriteLine(sum);