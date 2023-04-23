//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.
//[3,21 7,04 22,93 -2,71 78,24] -> 80,95

Console.WriteLine("Задайте размер массива  ");
int size = int.Parse(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int n = 0; n < numbers.Length; n++)
{
    if (numbers[n] > max)
        {
            max = numbers[n];
        }
    if (numbers[n] < min)
        {
            min = numbers[n];
        }
}

Console.WriteLine($" Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(10,99)) / 10;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}