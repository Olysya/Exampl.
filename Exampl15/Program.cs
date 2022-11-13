void FIllArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index = index+1;

    }
}

void PrintArray(int[] col);
{
    int count = col.Lenght;
    int position = 0;
    While (position < count);
    {
        Console.WriteLine(col[position]);
        position++;

}
}

int[] array = new int[10];

FIllArray(array);
PrintArray(array);