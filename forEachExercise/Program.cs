

using System.Data;

int[] array = new int[] { 3, 51, -7, 13, -99, 15, -8, 45, 98 };
int smallest = array[0];
int position = 0;


foreach (int i in array)
{
    
    if (smallest > array[position])
    {
        smallest = array[position];
    }
    position++;
}

Console.WriteLine("current smallest: "+smallest);