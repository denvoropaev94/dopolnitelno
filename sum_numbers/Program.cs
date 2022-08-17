/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите число: ");
string? number = Console.ReadLine();

bool isNum = int.TryParse(number, out int result);
if (isNum == false)
{
    Console.WriteLine("Введите число, а не символы какие-то!!! ");
    return;
}
int ReturnsSumNumbers(string num)
{
    int summ = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (char.IsDigit(num[i]))
        {
            summ += Convert.ToInt32(num[i].ToString());
        }
    }
return summ;
}

int res = ReturnsSumNumbers(number);
Console.WriteLine(res);