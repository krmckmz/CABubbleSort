class Program
{

    static void Main(string[] args)
    {
        BubbleSort(new int[] { 2, 8, 5, 3, 9, 4, 1 });
        Console.ReadLine();
    }

    static void BubbleSort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }

    }
}
