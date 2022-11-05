int numberA = -9;
int numberB = -3;

int max = numberA;
int min =numberB;

if(numberA > numberB) max = numberA; min = numberB;
if(numberA < numberB) max = numberB; min = numberA;

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);