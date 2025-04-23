// int a = 10;
// string b = "Hello";
// bool = true // false;
// float d = 15.4f;
// double e = 15.4f;

// Тип данных  int важно
// даем на любом языке, жлательно на англ
// = значение
// string user_name = "Volodya"

// = присвоить
// == сравнить

// if (истина) {условие} 

while (true)
{
    Console.WriteLine("Run first number");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Run second number");
    int number2 = Convert.ToInt32(Console.ReadLine());
   

    Console.WriteLine("Run operator +/-/*/: are end for exit");

    string Operator = Console.ReadLine();

    if (Operator == "end")
    {
        break;
    }

    
    if (Operator == "+")
    {
        Console.WriteLine(number1 + number2);
    }
    else if (Operator == "-")
    {
        Console.WriteLine(number1 - number2);
    }
    else if (Operator == "*")
    {
        Console.WriteLine(number1 * number2);
    }
    else if (Operator == ":")
    {
        Console.WriteLine(number1 / number2);
    }
    else if (Operator == "end")
    {
        break;
    }

}

