string[] inputarray = { "Hi,", "my ", "name is", "Sia", "Amazon"};       //имеющийся массив строк

string PrintToString(string[] array)                                    // Функция записывает массив строк в одну строку, возвращает результат в виде одной строки
{
    string output = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        output += $"{array[i]} ";
    }

    return output;
}


string[] LookingForTarget(string[] givenarray, int targetlength)    //Функция проходит по заданному массиву, 
{                                                                   //находит элементы подходящие по условию (длиной <= targetsize) 
    int count = 0;                                                  //и записыает его элементы в новый массив
    for (int i = 0; i < givenarray.Length; i++)
    {
        if (givenarray[i].Length <= targetlength) count++;
    }

    string[] resultarray = new string[count];
    int outputindex = 0;

    for (int j = 0; j < givenarray.Length; j++)
    {

        if (givenarray[j].Length <= targetlength)
        {
            resultarray[outputindex] = givenarray[j];
            outputindex++;
        }
    }
    return resultarray;
}

int sizelimit = 3;  //Длина элеметов массива, которые нужно записать в новый массив

string[] outpurarray = LookingForTarget(inputarray, sizelimit);

Console.WriteLine("Input: " + PrintToString(inputarray));
Console.WriteLine("Output: " + PrintToString(outpurarray));
