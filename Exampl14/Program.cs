int[] array = {1,2,3,34,87,54,6,79,87,9};

int n = array.Length;
int find = 87;

int index = 0;
while (index < n )
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
  index = index+1;  
}

