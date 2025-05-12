Demo([0,1,0,3,12]);
Demo([0]);
Demo([0,12,654,12,0,3,60,0,89,0,0,0,3,1,1,3,6,8,53,2,15]);

void Demo(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
    MoveZero(array);
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

void MoveZero(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        if (array[i] == 0)
        {
            for (int j = i; j < array.Length - 1; j++)
            {
                SwapIntegers(array, j, j+1);
            }
        }
    }
}

void SwapIntegers(int[] array, int index1, int index2)
{
    // i.e. a=3, b=8
    //a = b - a; // a= 5, b= 8
    //b = b - a; // a= 5, b= 3
    //a = b + a; // a= 8, b= 3

    array[index1] = array[index2] - array[index1];
    array[index2] = array[index2] - array[index1];
    array[index1] = array[index1] + array[index2];
}
