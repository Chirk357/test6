// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3 символа.



string[] Array = new string[5] {"window", "89", "1", "846352", "764"};

string[] CountAndResultArray(string[] Array, int countOfSymbols) 
{
    int[] defineQuantityOfSymbols = new int[Array.Length];
    int count = 0;
    for(int i = 0; i < Array.Length; i++)
    {
        if(Array[i].Length <= countOfSymbols)
        {
            defineQuantityOfSymbols[count] = i;
            count++;
        }
    }
    string[] newArray = new string[count];
    for(int i = 0; i < count; i++)
    {
        newArray[i] = Array[defineQuantityOfSymbols[i]];
    }
    return newArray;
}


Console.WriteLine($"[{string.Join(", " ,Array)}]->[{string.Join(", " , CountAndResultArray(Array, 3))}]");
Console.WriteLine($"[{string.Join(", " ,Array)}]->[{string.Join(", " , CountAndResultArray(Array, 2))}]");
Console.WriteLine($"[{string.Join(", " ,Array)}]->[{string.Join(", " , CountAndResultArray(Array, 1))}]");

// string str = "abcdefg";
// Console.WriteLine("The length of '{0}' is {1}", str, str.Length);
// Console.WriteLine("The length of '{0}' is {1}", "xyz", "xyz".Length);

// int length = str.Length;
// Console.WriteLine("The length of '{0}' is {1}", str, length);

// // This example displays the following output:
// //    1) The length of 'abcdefg' is 7
// //    2) The length of 'xyz' is 3
// //    3) The length of 'abcdefg' is 7
