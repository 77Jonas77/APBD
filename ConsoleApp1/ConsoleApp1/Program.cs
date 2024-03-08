// See https://aka.ms/new-console-template for more information

static float countMax(int[] array)
{
    int max = 0;
    if (array != null)
    {
        max = array[0];
        for (int inna_nazwa = 1; inna_nazwa < array.Length; inna_nazwa++)
        {
            if (max < array[inna_nazwa])
            {
                max = array[inna_nazwa];
            }
        }
    }

    return max;
} 

Console.WriteLine(countMax([0,2,3,2]));
