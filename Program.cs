//Задание 1
//1)Ничего
//2)voidShowWelcomMessage()
//3)Метод вызовет ошибку компиляции 
//4)void PrintNumber(int number)
//5)PrintMessage("Hello,World")

//Задание 2
//void GreetUser() {
//    string name = Console.ReadLine();
//    Console.WriteLine($"Привет, {name}!Добро пожаловать в программу!");
//}
//GreetUser();

//Задание 3
//int Sum(int a,int b) {
//    int c = a + b;
//    Console.WriteLine($"{c}");
//    return c;
//}
//Sum(1, 2);

//Задание 4 
//bool Isven(int a)
//{
//    ;
//    if (a % 2 == 0)
//    {
//        bool c = true;
//        Console.WriteLine($"{c}");
//        return c;
//    }
//    else
//    {
//        bool c = false;
//        Console.WriteLine($"{c}");
//        return c;

//    }


//}
//Isven(3);

//задание 5
//double FindMax(double[] nums)
//{
//    if (nums == null || nums.Length == 0)
//        return 0;

//    double max = nums[0];
//    for (int i = 1; i < nums.Length; i++)
//    {
//        if (nums[i] > max)
//            max = nums[i];
//    }
//    Console.WriteLine(max);
//    return max;

//}
//double[] A = {1,2,3,4,5};
//FindMax(A);

//Задание 6
//double ConvertCelsiusToFahrenheit(double celsius)
//{
//    return celsius * 9 / 5 + 32;
//}
//Console.WriteLine(ConvertCelsiusToFahrenheit(30));

//Задание 7
//int CountVowels(string text)
//{
//    int count = 0;
//    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

//    foreach (char c in text)
//    {
//        foreach (char vowel in vowels)
//        {
//            if (c == vowel)
//            {
//                count++;
//                break;
//            }
//        }
//    }

//    return count;

//}
//Console.WriteLine(CountVowels("ae7ou"));

//Задание 8
//string GeneratePassword(int length)
//{
//    if (length < 2) return "Длина должна быть не менее 2";

//    Random random = new Random();
//    string let = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
//    string dig = "0123456789";
//    string vse = let + dig;

//    string password = "";
//    password += let[random.Next(let.Length)];
//    password += dig[random.Next(dig.Length)];
//    for (int i = 2; i < length; i++)
//    {
//        password += vse[random.Next(vse.Length)];
//    }

//    return password;

//}

//Console.WriteLine(GeneratePassword(2));

//Задание 9
//bool IsPalindrome(string text)
//{
//    string a = text.ToLower();

//    int left = 0;
//    int right = a.Length - 1;

//    while (left < right)
//    {
//        if (a[left] != a[right])
//            return false;

//        left++;
//        right--;
//    }

//    return true;
//}
//Console.WriteLine(IsPalindrome("Шалаш "));

//Задание 10
//int[] ReverseArray(int[] array)
//{
//    if (array == null)
//        return new int[0];

//    int[] reversed = new int[array.Length];

//    for (int i = 0; i < array.Length; i++)
//    {
//        reversed[i] = array[array.Length - 1 - i];
//    }
//    Console.WriteLine("Перевернутый: {" + string.Join(", ", reversed) + "}");
//    return reversed;
//}
//int[] numbers = { 1, 2, 3, 4, 5 };
//ReverseArray(numbers);

//Задание 11
//static double Add(double a, double b)
//{
//    return a + b;
//}

//static double Subtract(double a, double b)
//{
//    return a - b;
//}

//static double Multiply(double a, double b)
//{
//    return a * b;
//}

//static double Divide(double a, double b)
//{
//    if (b == 0)
//    {
//        Console.WriteLine("Ошибка: деление на ноль!");
//        return 0;
//    }
//    return a / b;
//}

//while (true)
//{
//    Console.WriteLine("\n=== КАЛЬКУЛЯТОР ===");
//    Console.WriteLine("1. Сложение");
//    Console.WriteLine("2. Вычитание");
//    Console.WriteLine("3. Умножение");
//    Console.WriteLine("4. Деление");
//    Console.WriteLine("0. Выход");
//    Console.Write("Выберите операцию: ");

//    string choice = Console.ReadLine();

//    if (choice == "0")
//    {
//        Console.WriteLine("До свидания!");
//        break;
//    }

//    if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
//    {
//        Console.WriteLine("Неверный выбор! Попробуйте снова.");
//        continue;
//    }

//    Console.Write("Введите первое число: ");
//    double num1 = Convert.ToDouble(Console.ReadLine());

//    Console.Write("Введите второе число: ");
//    double num2 = Convert.ToDouble(Console.ReadLine());

//    double result = 0;
//    string operation = "";

//    switch (choice)
//    {
//        case "1":
//            result = Add(num1, num2);
//            operation = "+";
//            break;
//        case "2":
//            result = Subtract(num1, num2);
//            operation = "-";
//            break;
//        case "3":
//            result = Multiply(num1, num2);
//            operation = "*";
//            break;
//        case "4":
//            result = Divide(num1, num2);
//            operation = "/";
//            break;
//    }

//    Console.WriteLine($"Результат: {num1} {operation} {num2} = {result}");
//}

//задание 12
//bool IsPrime(int number)
//{
//    if (number < 2) return false;

//    for (int i = 2; i < number; i++)
//    {
//        if (number % i == 0)
//            return false;
//    }

//    return true;
//}
//void PrintPrimesUpTo(int n)
//{
//    Console.WriteLine($"Простые числа до {n}:");

//    for (int i = 2; i <= n; i++)
//    {
//        if (IsPrime(i))
//            Console.Write(i + " ");
//    }
//    Console.WriteLine();
//}
//PrintPrimesUpTo(30);
