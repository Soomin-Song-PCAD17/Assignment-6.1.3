Demo([0,1,0,3,12]);
Demo([0]);
Demo([0,0,1,0,0,0,0,0,2,3,0,0,0,4,0,5]);

void Demo(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
    MoveZeroFixed(array);
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

void MoveZeroFixed(int[] array)
{
    // traverse right, making a "bubble" increasing in size that moves all the nonzero from right to left
    int left = 0;
    int right = 0;

    while (right <= array.Length - 1)
    {
        if (array[right] == 0) { right++; }
        else
        {
            SwapIntegers(array,left,right);
            left++;
            right++;
        }
    }
}
