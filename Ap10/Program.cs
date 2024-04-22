int score; 
string s;

Console.Write("成績:");
s = Console.ReadLine();
score = int.Parse(s);

if (score < 60)
    Console.WriteLine("C-Class");
else if (score < 80)
    Console.WriteLine("B-Class");
else
    Console.WriteLine("A-Class");