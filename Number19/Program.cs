// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num < 100000)
{
    int Metod(int n1)
    {
        int num1 = n1 % 10;
        int num2 = n1 / 10000;
        if (num1 == num2) return 1;
        else return -1;
    }
    int result = Metod(num);
    if (result > 0)
    {
        int numnum = num / 10000;
        int numnum0 = num - numnum * 10000;
        int numnum2 = numnum0 / 10;

        int Metod2(int n2)
        {
            int num3 = n2 % 10;
            int num4 = n2 / 100;
            if (num3 == num4) return 1;
            else return -1;
        }
        int result2 = Metod2(numnum2);
        if (result2 > 0) Console.Write($"Число {num} -> палиндром");
        else Console.Write($"Число {num} -> не палиндром");
    }
    else Console.Write($"Число {num} -> не палиндром");
}
else Console.Write($"Число {num} не пятизначное");
