// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("введите количeство чисел");                 // запрос количества чисел
int m = Convert.ToInt32(Console.ReadLine());                   // присваиваем значение переменной m 
int[] array = new int[m];                                      // обозначаем массив  
int count = 0;                                                 // определяем переменную для подсчета количества положительных чисел 

for (int i=0; i<m; i++)                                        // организовываем цикл по заполнению масиива. 
{
    Console.WriteLine($"Введите число {i+1}");                 // сообщение о выводе i+1 числа, здесь прибавлена 1 для удобства 
    array[i] = Convert.ToInt32(Console.ReadLine());            // присвоение значения с клавиватуры элементу массива с конвертацией в int32
    if (array[i]>0) count +=1;                                 // проверка на положительность если да то инкремент переменной count.
}
Console.Write("Массив [");                                          // вывод на экран
for (int i=0; i<m;i++) Console.Write(array[i]+" ");                 // в цикле всех элементов массива для удобства
Console.Write("]");                                                 //
Console.WriteLine(" Количество положительных чисел - "+ count);     // вывод результата
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями

Console.WriteLine("Введите значение b1");                    // ввод данных
double b1 = Convert.ToDouble(Console.ReadLine());            // присваиваем и конвертируем в double
Console.WriteLine("Введите значение к1");
double  k1 = Convert.ToDouble(Console.ReadLine());           // присваиваем и конвертируем в double  
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());            // присваиваем и конвертируем в double
Console.WriteLine("Введите значение к2");
double k2 = Convert.ToDouble(Console.ReadLine());            // присваиваем и конвертируем в double

//--------------------логический блок--------------------------
double x = ((-(b1-b2)) / (k1-k2));                           // Решив систему уравнений вычислена координата X 
// Console.WriteLine("X равен "+x);
double y = k2 * x + b2;                                      // Затем найдена координата Y
// Console.WriteLine("Y равен "+y);

Console.WriteLine($"Координаты пересечения - {x}, {y} ");    // вывод на экран результата 
