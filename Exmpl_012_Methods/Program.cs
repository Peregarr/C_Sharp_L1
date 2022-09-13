// Вид 1 Это метод который ничего не принимает и ничего возвращает

// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// //Method1();





//Вид 2 Это методы которые принимают какието аргументы но ничего возвращают
// void Method2(string msg) //именованнй аргумент msg
// {
//     Console.WriteLine(msg);
// }
// //Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;  // Увеличение на единицу Инкримент, уменьшение на единицу Декримент
//     }
// }
// //Method21("Текст", 4); //Вывод текста 4 раза
// //Method21(count: 4, msg: "Текст"); //Можно указать какому аргументу какое значение присвоить

// Вид 3 Это методы которые что то возвращают но ничего не принимают

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// Вид 4 // Методы которые что то принимают и что то возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // String.Empty - это пустая строка, для удобства чтения кода
//                                     // можно и так = ""; это тоже пустая строка
//         while(i < count)
//         {
//             result = result + text;
//             i++;
//         }
//         return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);


// for - это тоже цикл который собирает всё в одном месте в скобках
// Например: for(int i = 0; i < count; i++) (инициализация счетчика; условие; счетчик)

// string Method4(int count, string text)
// {
//     //int i = 0; инициализацию счетчика переносим в цикл for

//     string result = String.Empty;    // String.Empty - это пустая строка, для удобства чтения кода
//                                      // можно и так = ""; это тоже пустая строка

//     for (int i = 0; i < count; i++)
//     //while(i < count) теперь for вместо while
//     {
//         result = result + text;
//         //i++; счетчик переносим в цил for
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);



// Цикл внутри цикла


// Таблица умножения

// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine("");
// }


// Работа с текстом

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)  // Символьный тип (Сhar) — тип данных, предназначенный для хранения одного символа
//                                                             // (управляющего или печатного) в определённой кодировке.
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'о', 'О');
// Console.WriteLine(newText);

// Сортировка массива от мин до макс

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);