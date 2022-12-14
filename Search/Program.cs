// See https://aka.ms/new-console-template for more information

using Search.Algo;
using Sort.Algo;
using System;

int[] arr = new int[10];
int lookingValue;
int rl;
int steps = 0;
DateTime tstart;
DateTime tstop;
Random rnd = new Random();

for (int i = 0; i<arr.Length;i++)
{
    int v = rnd.Next(1, 1_000_0);
    if (Array.IndexOf(arr, v) <= 0)
        arr[i] = v;
    else
        i--;
}
lookingValue = arr[(new Random()).Next(0, arr.Length-1)];
/*
#region Алгоритмы поиска
#region Линейный поиск
Console.WriteLine("Линейный поиск");
    tstart = DateTime.Now;
    steps++;

    rl = LineSearch.Search(arr, lookingValue);
tstop = DateTime.Now;
Console.WriteLine("index:{0} Ticks:{1}", rl, (tstop.Ticks - tstart.Ticks));
steps = 0;
#endregion
#region Бинарый поиск
Console.WriteLine("\n\nБинарый поиск");

    tstart = DateTime.Now;
    steps++;

    rl = BinarySearch.Search(arr, lookingValue);
tstop = DateTime.Now;
Console.WriteLine("index:{0} Ticks:{1}", rl, (tstop.Ticks - tstart.Ticks));
steps = 0;


Console.WriteLine("\n\nБинарый поиск(Рекурсивный)");

tstart = DateTime.Now;
steps++;

rl = BinarySearch.RecursiveSearch(arr, lookingValue,0,arr.Length-1);
tstop = DateTime.Now;
Console.WriteLine("index:{0} Ticks:{1}", rl, (tstop.Ticks - tstart.Ticks));
steps = 0;
#endregion
#region Поиск Прыжками
Console.WriteLine("\n\nПоиск Прыжками");

    tstart = DateTime.Now;
    steps++;

    rl = JumpedSearch.Search(arr, lookingValue);
tstop = DateTime.Now;
Console.WriteLine("index:{0} Ticks:{1}", rl, (tstop.Ticks - tstart.Ticks));
steps = 0;
#endregion
#region Поиск интерполяционный
//На большом количестве не работает.
Console.WriteLine("\n\nПоиск интерполяционный");

    tstart = DateTime.Now;
    steps++;

    rl = InterpolatingSearch.Search(arr, lookingValue);
tstop = DateTime.Now;
Console.WriteLine("index:{0} Ticks:{1}", rl, (tstop.Ticks - tstart.Ticks));
steps = 0;
#endregion
#region Экспоненциальный поиск
Console.WriteLine("\n\nЭкспоненциальный поиск");

tstart = DateTime.Now;
steps++;

rl = ExponentialSearch.Search(arr, lookingValue);
tstop = DateTime.Now;
Console.WriteLine("index:{0} Ticks:{1}", rl, (tstop.Ticks - tstart.Ticks));
steps = 0;
#endregion
#endregion

*/
#region Лгоритмы сортировки
#region Сортировка пузырьком
Console.WriteLine("\n\nДо сортировки:");
foreach (var item in arr)
{
    Console.Write(" {0} ",item);
}
var bubleArr = BubleSort.Sort(arr);
Console.WriteLine("\n\nПосле сортировки:");
foreach (var item in bubleArr)
{
    Console.Write(" {0} ", item);
}
#endregion

#region Лгоритмы сортировки
#endregion

#region Лгоритмы сортировки
#endregion

#region Лгоритмы сортировки
#endregion

#region Лгоритмы сортировки
#endregion

#region Лгоритмы сортировки
#endregion

#region Лгоритмы сортировки
#endregion

#endregion

Console.ReadLine();
