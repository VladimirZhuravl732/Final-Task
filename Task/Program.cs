//Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 

int[] CreateArray(int Length, int LeftBound, int RigthBound)
{
    int[] Array = new int[Length];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(LeftBound, RigthBound);
    }
    return Array;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.WriteLine(Array[i]);
    }
}

int[] Arr = CreateArray(5, -10, 15);
PrintArray(Arr);


