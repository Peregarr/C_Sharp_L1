using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "") // .Replace - метод который позволяет заменить символ
                .Replace(")", "") // в данном случае скобки на пробелы "(" --> " "
                ;                 // таким оюразом получаем в выводе 1,2 2,3 4,5 6,7
                                  // вместо (1,2) (2,3) (4,5) (6,7)
Console.WriteLine(text);
var data = text.Split(" ") // var - это неявный тип данных.
                           // Split - метод позволяющий сделать разбивку
                           // с учетом символа разделителя, на данный момент пробел " "

                .Select(item => item.Split(',')) // Select - выборка элементов. Взять элементы и разделить запятой
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e => e.x % 2 == 0)
                .Select(e => (point.x * 10, point.y + 10))
                .ToArray(); // Превращает полученный набор данных в массив

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}