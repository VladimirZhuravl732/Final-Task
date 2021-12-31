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


int[] CreateEvenArr(int[] Array)
{
    int count = 0;
    int[] EvenArray= new int[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0) 
        EvenArray[count] = Array[i];
        count++;
    }
    return EvenArray;
}

int[] Arr = CreateArray(10, -10, 15);
PrintArray(Arr);
System.Console.WriteLine();
int [] EvenArr = CreateEvenArr(Arr);
PrintArray(EvenArr);


