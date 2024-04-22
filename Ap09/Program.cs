int score; //<=加入這一行
string s;

Console.Write("成績:");
s = Console.ReadLine();
score = int.Parse(s);

if(score < 60)
    Console.WriteLine("不及格");
else
    Console.WriteLine("及格");