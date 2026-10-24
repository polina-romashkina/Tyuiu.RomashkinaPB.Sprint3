using Tyuiu.RomashkinaPB.Sprint3.Task3.V15.Lib;
//Оператор используется для обхода коллекций, последовательно переходя от элемента к элементу в цикле
//В данном случае, под коллекцией понимается тип, который :
//реализует интерфейс System.Collections.IEnumerable или System.Collections.Generic.IEnumerable<T>
//реализует открытый метод GetEnumerator, возвращает интерфейс, класс или структуру, имеющие открытое свойство Current и метод MoveNext
//
//foreach (тип имя_переменной_цикла in коллекция)
//{
//   Тело цикла
//}

namespace Tyuiu.RomashkinaPB.Sprint3.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Ромашкина П. Б. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт # 3                                                              *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Ромашкина Полина Борисовна | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв m,        *");
            Console.WriteLine("* находящихся на соседних позициях в строке: Irmmse mg sermmmrt           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "Irmmse mg sermmmrt";
            char chr = 'm';
            
            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ  = " + chr);
            


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Минимальное количество символов = " + ds.GetMinCharCount(value, chr));
            Console.ReadKey();
        }
    }
}
