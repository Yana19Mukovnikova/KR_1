
string[] array1 = new string[5] {"qwer", "512", "hello", "world", "06"};
    string[] array2 = new string[array1.Length];
    ResultArray(array1, array2);
    PrintArray(array2);

    void ResultArray(string[] array1, string[] array2)
    {
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
    Console.WriteLine("Исходный массив: {0}", string.Join(", ", array1));
    }

void PrintArray(string[] array)
    {
    Console.Write("Массив, длина которого <= 3: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null)
            {
                Console.Write("{0} ", array[i]);
            }
        }
        Console.WriteLine();
    }
