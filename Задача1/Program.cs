// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3 символа.


string[] array = new string[3] {"913", "window", "Street"};

for(int i = 0; i < array.Length; i++)
{
    if(i > )
}



// string[] array = new string[3] {"12354", "432", "as"};

// string[] ArrayItemNumDegree(string[] array, int countOfDigits)
// {
//     int[] itemNumDegreeId = new int[array.Length];
//     int countOfItems = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i].Length <= countOfDigits)
//         {
//             itemNumDegreeId[countOfItems] = i;
//             countOfItems++;
//         }
//     }
//     string[] resultArray = new string[countOfItems];
//     for(int i = 0; i < countOfItems; i++)
//     {
//         resultArray[i] = array[itemNumDegreeId[i]];
//     }
//     return resultArray;
// }


// Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegreeLinq(array, 3))}]");
// Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegreeLinq(array, 2))}]");
// Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegreeLinq(array, 1))}]");

// Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegree(array, 3))}]");
// Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegree(array, 2))}]");
// Console.WriteLine($"[{string.Join(",",array)}]->[{string.Join(",", ArrayItemNumDegree(array, 1))}]");

string str = "abcdefg";
Console.WriteLine("The length of '{0}' is {1}", str, str.Length);
Console.WriteLine("The length of '{0}' is {1}", "xyz", "xyz".Length);

int length = str.Length;
Console.WriteLine("The length of '{0}' is {1}", str, length);

// This example displays the following output:
//    1) The length of 'abcdefg' is 7
//    2) The length of 'xyz' is 3
//    3) The length of 'abcdefg' is 7
