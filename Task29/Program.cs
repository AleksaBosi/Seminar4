int[] array = new int[8];

FillArray(array);
PrintArray(array);
SortAbsArray(array);
PrintArray(array);

static void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.Next(-100, 100);
    }
}
static void SortAbsArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minIndex = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            int currentValue = (int)Math.Abs(array[minIndex]);
            int currValue = (int)Math.Abs(array[j]);
            if (currValue < currentValue)
            {
                minIndex = j;
            }
        }

        int temp = array[i];
        array[i] = array[minIndex];
        array[minIndex] = temp;
    }
}
static void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "\t");
    }
    Console.WriteLine();
}

