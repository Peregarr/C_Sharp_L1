int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//             0   1   2   3   4   5   6   7   8
int[] arr = { 15, 21, 39, 12, 23, 33, 13, 23, 313 }; //массив
//arr[0] = 16;
//Console.WriteLine(arr[0]);

int result = Max(
    Max(arr[0], arr[1], arr[2]),
    Max(arr[3], arr[4], arr[5]),
    Max(arr[6], arr[7], arr[8])
);
Console.WriteLine(result);

/*  теперь эти значения занесли в массив!
int a1 = 15; 
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;
*/

/*
int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2);
int max3 = Max(a3,b3,c3);
int max = Max(max1, max2, max3);
*/
/*
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); // Таким образом внутри аргумента можно передать функцию

Console.WriteLine(max);
*/