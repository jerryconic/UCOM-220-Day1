/*
 * 輸入台幣(NT)
 * 輸入幣別(curr)
 * CASE curr
 * "U":
 * amt = nt / 30.05
 * "J":
 * amt = nt / 0.2758
 * "E":
 * amt = nt / 32.55
 * else
 * amt = 0
 * END CASE
 * 顯示台幣金額, 可兌換金額
*/
string s, curr;
int nt;
decimal amt;
Console.Write("輸入台幣(NT):");
s = Console.ReadLine();
nt = int.Parse(s);
Console.Write("輸入幣別(U=USD/J=JPY/E=EUR):");
curr = Console.ReadLine();
switch(curr)
{
    case "U":
    case "u":
        amt = nt / 30.05m;
        break;
    case "J":
    case "j":
        amt = nt / 0.2758m;
        break;
    case "E":
    case "e":
        amt = nt / 32.55m;
        break;
    default:
        amt = 0;
        break;
}
Console.WriteLine($"台幣金額{nt:#,##0}, 可兌換金額:{amt:#,##0.00}");
