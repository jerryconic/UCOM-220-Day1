/*
 * 稅率	所得	                累進差額
5％	            0~590,000	    –
12％	  590,001~1,330,000	     41,300
20％	1,330,001~2,660,000	    147,700
30％	2,660,001~4,980,000	    413,700
40％	4,980,001以上	        911,700
*/
string s;
int income, tax;
Console.Write("年所得收入:");
s = Console.ReadLine();
income = int.Parse(s);

if (income <= 590000)
    tax = (int)(income * 0.05 + 0.5);
else if (income <= 1330000)
    tax = (int)(income * 0.12 - 41300 + 0.5);
else if (income <= 2660000)
    tax = (int)(income * 0.2 - 147700 + 0.5);
else if (income <= 4980000)
    tax = (int)(income * 0.3 - 413700 + 0.5);
else
    tax = (int)(income * 0.4 - 911700 + 0.5);

//Console.WriteLine("年所得收入:{0:#,##0}, 應納所得稅:{1:#,##0}", income, tax);
Console.WriteLine($"年所得收入:{income:#,##0}, 應納所得稅:{tax:#,##0}");