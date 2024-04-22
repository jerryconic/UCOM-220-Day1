int[] ar = { 17, 31, 42, 21, 5 };
int total = 0;

Array.Sort(ar);

for (int i = 0; i < ar.Length; i++)
{
    total += ar[i];
    Console.WriteLine(ar[i]);
}

Console.WriteLine($"Total={total}");