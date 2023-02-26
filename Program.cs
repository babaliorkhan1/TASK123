
//Task - 3
int[] array = { 23, 34, 56, 89, 23, 45 };
int enboyuk = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > enboyuk)
    {
        enboyuk = array[i];
    }


}
Console.WriteLine(enboyuk);