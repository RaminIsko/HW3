Console.WriteLine("ЗАДАЧА, проверяющая является ли число палиндромом");
Console.WriteLine("");
void Palindrom(int el){
    if((el % 10 == el / 10000) && (el / 10 % 10 == el / 1000 % 10)){
        Console.WriteLine($"Число {el} - Палиндром");
    }else{
        Console.WriteLine($"Число {el} - не Палиндром");
    };
}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if(number > 10000 && number < 100000){
    Palindrom(number);
}

Console.WriteLine("ЗАДАЧА находящая расстояние между двумя точками в 3D пространстве");
Console.WriteLine("");
void Distance(double x1, double x2, double y1, double y2, double z1, double z2){
    double S = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    Console.WriteLine($"Расстояние между двумя точками в 3D пространстве: {S}");
}
Distance(1,2,3,4,5,6);

Console.WriteLine("ЗАДАЧА, выводящая ряд кубов чисел от 1 до N");
Console.WriteLine("");
void Cube(int num){
    Console.Write("Ряд кубов чисел: ");
    for(int i = 0; i < num; i++){
        Console.Write($"{Convert.ToInt32(Math.Pow(i, 3))} ");
    }
}
Console.Write("Введите число: ");
int num4 = int.Parse(Console.ReadLine()!);
Cube(num4);