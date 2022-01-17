int[] array = { 3,5,6,7,2,9 }; 

void ArrayOfEvenNumbers (int[] array)

{
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] % 2 == 0) Console.Write($"{array[index]} ");
    }
}

ArrayOfEvenNumbers(array);