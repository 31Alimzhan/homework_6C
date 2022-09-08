Console.WriteLine("введите количeство чисел");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
int count = 0;
for (int i=0; i<m; i++)
{
    Console.WriteLine($"Введите число {i+1}");
    array[i] = Convert.ToInt32(Console.ReadLine());    
    if (array[i]>0) count +=1;
   // Console.WriteLine($"число положительных {count}");
}
Console.Write("Массив [");
for (int i=0; i<m;i++)
{
    Console.Write(array[i]+" ");

}
Console.Write("]");
Console.WriteLine(" Количество положительных чисел - "+ count);
