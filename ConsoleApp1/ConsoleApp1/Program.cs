// See https://aka.ms/new-console-template for more information

static float countAvg(int[] array)
{
    int max = 0;
    if (array != null)
    {
        max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
    }

    return max;
} 

Console.WriteLine(countAvg([0,2,3,2]));