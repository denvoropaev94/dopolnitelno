int[] array = new int[5];

int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива под индексом {i} ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++) {
        int MaxPos = i;

    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[j] > arr[MaxPos])
        {
            MaxPos = j;
            }

    }
    int temp = arr[i];
    arr[i] = arr[MaxPos];
    arr[MaxPos] = temp;
}
}   

int[] n = FillArray(array);
PrintArray(n);

SelectionSort(array);

PrintArray(array);