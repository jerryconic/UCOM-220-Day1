
for ( ; ; )
{
    Exchange();
    Console.Write("繼續(Y/N)?");
    string s;
    s = Console.ReadLine();
    if (s == "N" || s == "n")
        break;
    else
        Console.Clear();
}
void Exchange()
{
    string s, curr;
    int nt;
    decimal amt;
    Console.Write("輸入台幣(NT):");
    s = Console.ReadLine();
    nt = int.Parse(s);
    Console.Write("輸入幣別(U=USD/J=JPY/E=EUR):");
    curr = Console.ReadLine();
    switch (curr)
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

}
