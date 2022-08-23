void arrFill(int[] coll) //void это аргумент который ничего не возвращает
{
    int length1 = coll.Length;
    int index1 = 0;
    while (index1 < length1)
    {
        coll[index1] = new Random().Next(1, 10);
        index1++;
    }
}

void arrPrint(int[] col)
{
    int length2 = col.Length;
    int index2 = 0;
    while(index2 < length2)
    {
        Console.WriteLine(col[index2]);
        index2++;
    }
}

int IndexOf(int[] coll, int find)
{
    int index2 = coll.Length;
    int index1 = 0;
    int pos = -1;   // переменная pos в которую запишем индекс найденного элемента,
                    // индекс массива всегда начинается с 0, но позицию по умолчанию меняем на -1 вместо 0,
                    // такого индекса не существует таким образом когда в выводе будет -1
                    // мы понймем что нужный нам элемент не найден

    while (index1 < index2)
    {
        if(coll[index1] == find)
        {
            pos = index1;
            break;
        }
        index1++;
    }
    return pos;
}

int[] arr = new int[10];

arrFill(arr); // этот метод заоплняет массив рандомно от 1 до 10 каждый элемент
arrPrint(arr); // этот метод выводит в консоль все элементы которые были сгенерированы в первом методе
Console.WriteLine();

int pos = IndexOf(arr, 4); // элемент который ищем 4
Console.WriteLine(pos);