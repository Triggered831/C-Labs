int len = 10;
int[] array = new int[len];
Random random = new Random();
array.Append(len / 2);
for (int i = 0; i < len; i++) { 
    array[i] = random.Next()%100+1;
    Console.WriteLine(i+1 + " " + array[i]);
}

Array.Reverse(array);
Array.Reverse(array, 0, len/2);
Array.Reverse(array, len / 2,len/2);

Console.WriteLine();
for (int i = 0; i < len; i++)
{
    Console.WriteLine(i+1+ " " + array[i] );
}