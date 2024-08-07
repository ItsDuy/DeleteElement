namespace DeleteElement;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int N = int.Parse(Console.ReadLine());

        int[] array = new int[N];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Enter element {i}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the element to delete: ");
        int X = int.Parse(Console.ReadLine());

        int indexDel = -1;
        for (int i = 0; i < N; i++)
        {
            if (array[i] == X)
            {
                indexDel = i;
                break;
            }
        }

        if (indexDel == -1)
        {
            Console.WriteLine("Element not found.");
            return;
        }

        for (int i = indexDel; i < N - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[N - 1] = 0;

        Console.WriteLine("Array after deletion:");
        for (int i = 0; i < N; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
