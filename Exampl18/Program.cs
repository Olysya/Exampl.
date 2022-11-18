Console.Write ("Введите число, для которого нужно найти третью по счету цифру: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >99)
{
    while (a>999)
    {
        a=a/10;
    }
  Console.Write ("Третья по счету цифра: {0}", a%10);
  }
else Console.Write ("Третьей  цифры нет");