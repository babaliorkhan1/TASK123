//Task (1,2,3)
// task-1

Console.WriteLine("imtahan qiymeti girin");
int qiymet = Convert.ToInt32(Console.ReadLine());
if (91 <= qiymet && qiymet <= 100)
{
    Console.WriteLine("Result:A");
}
else if (81 <= qiymet && qiymet <= 90)
{
    Console.WriteLine("Result:B");
}
else if (71 <= qiymet && qiymet <= 80)
{
    Console.WriteLine("Result:C");
}
else if (61 <= qiymet && 70 <= qiymet)
{
    Console.WriteLine("Result:D");
}
else if (51 <= qiymet && qiymet <= 60)
{
    Console.WriteLine("Result:E");
}
else if (qiymet < 51)
{
    Console.WriteLine("kesildiniz");
}
