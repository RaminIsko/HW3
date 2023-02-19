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