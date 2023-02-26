
//task - 2
int[] array = { 1, 3, 56, 34, -32, -78, -12 };
int count = 0;
int count1 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
    if (array[i] < 0)
    {
        count1++;
    }
}
Console.WriteLine(count);
Console.WriteLine(count1);