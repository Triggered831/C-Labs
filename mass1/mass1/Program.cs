
using System;
Console.WriteLine("Введите числа");
int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.Write("Вставить после: ");
int k = Convert.ToInt32(Console.ReadLine());
int[] ints2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
int num = ints.Length - 1;
int[] ints3 = new int[ints.Length + ints2.Length];
ints3 = ints.SkipLast(ints.Length-k).ToArray();
ints3 = ints3.Concat(ints2).ToArray();
ints3 = ints3.Concat(ints.Skip(k)).ToArray();
foreach (int i in ints3)
    Console.Write(i+" ");