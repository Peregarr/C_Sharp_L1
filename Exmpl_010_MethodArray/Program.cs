int[] arr = { 15, 21, 39, 12, 23, 33, 13, 23, 313 };

int n = arr.Length;
int find = 33;

int index = 0;
while(index < n)
{
    if(arr[index] == find)
    {
        Console.WriteLine(index);
        break; // прервать в случае нахождения искомого, в ином случае цикл будет повторяться пока не пройдет весь массив
                // и будет выводить все одинаковые элементы которые указаны в переменной find
    }
    index++;
}