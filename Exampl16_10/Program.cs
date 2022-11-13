int n = 456; // 456 / 10  укорачиваем число ; 45 % 10 получаем крайнюю правую цифру 
int a = 0;
int d = 0; 

while (n > 0)
{
    a = n /10;
    d= a % 10;
}
Console.Write("Вторая цифра числа =  ");
Console.WriteLine(d);




