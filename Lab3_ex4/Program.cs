int t = 0;
int count = 1;
int x;
Console.WriteLine("Введите размер массива: ");
int n = Console.Read();
int[] a = new int[n];
Console.WriteLine("Введите элементы массива: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"A = {i + 1}");
    a[i] = Console.Read();
}
for (int i = 1; i <= a.Length; i++)
{
    if (a[i] != a[i - 1])
    {
        n += 1;
        for (int j = n; j >= i; j--)
        {
            a[j] = a[j - 1];
            i++;
        }
    }
}
Console.WriteLine("Преобразованный массив: ");
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]);
}
