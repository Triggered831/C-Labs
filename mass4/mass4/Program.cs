using System.Xml;

Console.WriteLine("Введите количество рядов, мест и соседних мест в одном ряду:");
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = arr[0];
int m = arr[1];
int k = arr[2];
int[,] array = new int[n, m];
int c = 0;
Random Random = new Random();
int[] seats = new int[n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = Random.Next()%2;
    }
}
for (int i = 0;i<m;i++)
{
    for (int j = 0;j<m;j++)
    {
        Console.Write(array[i, j]);
        Console.Write(" ");
    }
    Console.Write("\n");
}
for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < m-k; j++)
    {
        c = 0;
        for (int d = 0; d < k; d++) 
        {
            if (array[i, j + d] == 0) 
            {
                c++;
            }
            if (c >= k ) 
            { 
                Console.WriteLine(i+1);
                System.Environment.Exit(0);
            }
        }
    }
}
Console.WriteLine("0");
