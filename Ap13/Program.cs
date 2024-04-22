string s;
int mn;
Console.Write("月份:");
s = Console.ReadLine();
mn = int.Parse(s);
switch(mn)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("大月31天");
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("小月30天");
        break;
    case 2:
        Console.WriteLine("二月28或29天");
        break;
    default:
        Console.WriteLine("僅接受1~12");
        break;

}