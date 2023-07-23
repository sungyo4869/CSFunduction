// 整数型と小数型
int a = 5;
double b = 5.5;

Console.WriteLine(a);
Console.WriteLine(b);

// キャスト
long a = 5;
int b = (int)a;  // int b = a; >> error
Console.WriteLine(b);

// パース
string a = "10";
int b = int.Parse(a);
Console.WriteLine(b);

// varと型推論
var aisatsu = "ohayou";  //このあとにaisatsu = 100;とかくとエラー
var tensu = 100;
Console.WriteLine(aisatsu);
Console.WriteLine(tetsu);