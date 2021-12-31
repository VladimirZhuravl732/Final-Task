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
        System.Console.Write(Array[i] + " ");
    }
}

int GetCountEvenNumbers(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0) count++;
    }
    return count;
}

int[] CreateEvenArr(int[] Array, int Length)
{
    int index = 0;
    int[] EvenArray = new int[Length];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        {
            EvenArray[index] = Array[i];
            index++;
        }
    }
    return EvenArray;
}

int[] Arr = CreateArray(10, -10, 15);
PrintArray(Arr);
System.Console.WriteLine();
int size = GetCountEvenNumbers(Arr);
System.Console.WriteLine();
int[] EvenArr = CreateEvenArr(Arr, size);
PrintArray(EvenArr);


