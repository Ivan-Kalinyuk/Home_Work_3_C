Console.Write("Введите любое натуральное число = ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
string Method4 (int a)
{
    string result = String.Empty;
    while (a >= i)
    {
        int b = i*i*i;
        string q = Convert.ToString(b);
        result = result + q;
        result = result + " ";
        i++;
    }
    return result;
}
string res = Method4 (a);
Console.Write("Таблица кубов от 1 до Вашего числа: ");
Console.WriteLine(res);