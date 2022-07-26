void Zadacha25()
{   
    //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
    //a^b=a*a...a*a //умножаем в зависимости от числа b
    Random random = new Random();
    int number = random.Next(4, 8);
    int exponent = random.Next(2, 5);
    int result = number; //так как данная переменная накопительная можно использовать число "1" //число number умножится на 1, а далее часо на себя

    for (int i = 0; i < exponent; i++)
    {
        result *= number;
    } 

    Console.WriteLine($"Число {number} в степени {exponent} равно {result}");
}   


void Zadacha27()
{   
    //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    Random random = new Random();
    int number = random.Next(333, 777);

    SumOfDigit(number);

}

void SumOfDigit(int number)
{
    int sum = 0;

    Console.Write("В числе " + number);

    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }

    Console.WriteLine(" сумма цифр равна: " + sum);

}

void Zadacha29()
{
    //Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит 
    //отсортированный по модулю массив
    
}
//Zadacha25();
//Zadacha27();
