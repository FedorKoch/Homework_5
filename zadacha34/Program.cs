Console.Clear();
int k = 0;
Random rnd = new Random();
Console.WriteLine("введите количество элементов массива");
int a = int.Parse(Console.ReadLine());
int[] mas = new int[a];
for (int i = 0; i < mas.Length; i++)
{
mas[i] = rnd.Next(100, 1000);
Console.Write("{0} ", mas[i]);
if (mas[i] % 2 == 0)
k = k + 1;
}
Console.WriteLine();
Console.WriteLine("четных чисел");
Console.WriteLine(k);