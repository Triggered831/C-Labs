void Initialize(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next() % 100 + 1;
}
int[] Sum(int[] array, int[] array2)
{
    int[] array3 = new int[Math.Max(array.Length,array2.Length)];
        for (int i = 0; i < Math.Max(array.Length, array2.Length); i++)
        {
            if (i < array.Length) array3[i] += array[i];
            if (i < array2.Length) array3[i] += array2[i];
        }
    return array3;
}
int[] Multiply(int[] array, int num)
{
    int[] array2 = array;
    for (int i = 0; i < array2.Length; i++) { 
        array2[i] *= num;
    }
    return array2;
}
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] Common(int[] array1, int[] array2)
{
    List<int> list = new List<int>();
    for (int i = 0;i<array1.Length; i++)
    {
        for (int j = 0; j < array2.Length; j++)
        {
            if (array1[i] == array2[j]) list.Add(array1[i]);
        }
    }
    return list.ToArray();
}
int[] Sort(int[] array)
{
    int[] array1 = array;
    int temp;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array1;
}
int Min(int[] array)
{
    int num = 100000;
    foreach (int i in array)
    {
        if (i < num) num = i;
    }
    return num;
}
int Max(int[] array)
{
    int num = 0;
    foreach (int i in array)
    {
        if (i > num) num = i;
    }
    return num;
}
int Mid(int[] array)
{
    int num = 0;
    foreach (int i in array)
    {
        num += i;
    }
    num /= array.Length;
    return num;
}

Console.WriteLine("Введите размеры 2 массивов:"); 
int[] array1 = new int[Convert.ToInt32(Console.ReadLine())];
Initialize(array1);
int[] array2 = new int[Convert.ToInt32(Console.ReadLine())];
Initialize(array2);
while (true)
{
    int input = 0;
    Console.WriteLine("Функции: \n1.Сложение двух массивов\n2.Умножение на число\n3.Поиск общих значений\n4.Упорядочивание значений по убыванию\n5.поиск Min,Max, среднего значений в массиве\n6.Вывод значений массивов");
    input = Convert.ToInt32(Console.ReadLine());
    if (input == 1)
    {
        Print(Sum(array1, array2));
    }
    else if (input == 2)
    {
        Console.Write("Введите число:");
        int k = Convert.ToInt32(Console.ReadLine());
        Print(Multiply(array1, k));
    }
    else if (input == 3)
    {
        Print(Common(array1, array2));
    }
    else if (input == 4)
    {
        Print(Sort(array1));
    }
    else if (input == 5)
    {
        Console.WriteLine("Min:" + Min(array1) + " Max:" + Max(array1) + " Mid:" + Mid(array1));
    }
    else if (input == 6)
    {
        Print(array1);
        Print(array2);
    }
}
Initialize(array2);
Initialize(array1);
int[] sum = Sum(array1, array2);
int[] common = Common(array1, array2);
int min = Min(array1);
int max = Max(array1);
int mid = Mid(array1);