// int n = 10;
int[] array = { 1, 20, 23, 85, 12, 1, 2, 6, 9, 8 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        System.Console.WriteLine($"{array[i]} ");
    }
    i = i + 1;
}