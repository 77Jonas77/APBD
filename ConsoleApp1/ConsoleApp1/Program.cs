// See https://aka.ms/new-console-template for more information

static float countAvg(int[] array)
{
    float suma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        suma += array[i];
    }
    
    return suma / array.Length;
} 

Console.WriteLine(countAvg([0,2,3,2]));
  