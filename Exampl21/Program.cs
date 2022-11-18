int number = 3;
int i;

for (int i = 1; i <= number; i++);
{ 
 Console.Write($"{i*i*i} ");
}
int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}
