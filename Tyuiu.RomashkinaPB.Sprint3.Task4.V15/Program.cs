using Tyuiu.RomashkinaPB.Sprint3.Task4.V15.Lib;

// continue - прерывает текущую интерацию цикла и переходит к следующей
// break - полностью прерывает выполнение цикла
// int[] nums = { 3,6,6,8,9,12,4,88,66,67}
// for ( int i = 0; i < nums.Length; i++)
// {
//       if (nums[i] > 10)
//       {
//             Console.WriteLine($"{nums[i]} > 10");
//             continue;
//       }
//       if (i > 7)
//       {
//            Console.WriteLine("Цикл прерван");
//            break;
//       }
// }


namespace Tyuiu.RomashkinaPB.Sprint3.Task4.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Ромашкина П. Б. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт # 3                                                              *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Ромашкина Полина Борисовна | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y = ((sin(x) + x/ x) + 0,75)                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;


            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага  = " + stopValue);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
