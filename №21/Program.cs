Console.Write("Введите натуральное пятизначное число = ");
int a = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(a);
if ( b[0] ==  b[4] |  b[1] ==  b[3] ) Console.Write("Ваше число является палиндромом");
else Console.Write("Ваше число не является палиндромом");
