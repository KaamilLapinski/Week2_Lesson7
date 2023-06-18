using System;
using System.Diagnostics;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        
        //Lesson 5,6,7

        //Task 1
        int a1 = 5, b1 = 5;
        if (a1 == b1)
            Console.WriteLine($"{a1} i {b1} są równe");

        //Task 2
        int number = Int32.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"Liczba {number} jest parzysta");
        }
        else
        {
            Console.WriteLine($"Liczba {number} jest nieparzysta");
        }

        //Task 3
        int number2 = Int32.Parse(Console.ReadLine());
        if (number2 >= 0)
        {
            Console.WriteLine($"Liczba {number2} jest dodatnia");
        }
        else
        {
            Console.WriteLine($"Liczba {number2} jest ujemna");
        }

        //Task 4

        int year = Int32.Parse(Console.ReadLine());

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine($"Rok {year} jest przestępny");
                }
            }
            else
            {
                Console.WriteLine($"Rok {year} jest przestępny");
            }
        }
        else
        {
            Console.WriteLine($"Rok {year} nie jest rokiem przestępny");
        }


        //Task 5
        int age2 = Int32.Parse(Console.ReadLine());
        if (age2 >= 30)
        {
            Console.WriteLine("Mozesz zostac posłem, senatorem lub premierem.");
        }
        else if (age2 >= 21)
        {
            Console.WriteLine("Mozesz zostac posłem lub premierem");
        }
        else
        {
            Console.WriteLine("Masz za mało lat na stanowisko posłą, sentaora lub premiera");
        }

        //Task 6
        int height2 = Int32.Parse(Console.ReadLine());

        if (height2 > 200)
        {
            Console.WriteLine("Jestes wielkoludem");
        }
        else if (height2 > 160 && height2 < 190)
        {
            Console.WriteLine("Masz standardowy wzorst");
        }
        else
        {
            Console.WriteLine(" Jestes krasnoludem");
        }

        //Task 7
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        int c = Int32.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine($"Liczba {a} jest najwieksza");
        }
        else if (b > c && b > a)
        {
            Console.WriteLine($"Liczba {b} jest najwieksza");
        }
        else if (c > a && c > b)
        {
            Console.WriteLine($"Liczba {c} jest najwieksza");
        }

        //Task 8
        int math = 80, physics = 71, chemistry = 0;

        if ((math > 70 && physics > 55 && chemistry > 45) || (math + physics + chemistry > 180) || ((math + physics > 150) || (math + chemistry > 150)))
        {
            Console.WriteLine("Kandydat dopuszczony do rekrutacji");
        }
        else
        {
            Console.WriteLine("Kandydat nie jest dopuszczony do rekrutacji");
        }

        //Task 9
        int temp = 41;

        if (temp < 0)
        {
            Console.WriteLine(" cholernie piździ");
        }
        else if (temp >= 0 && temp <= 10)
        {
            Console.WriteLine("zimno");
        }
        else if (temp >= 10 && temp <= 20)
        {
            Console.WriteLine("chłodno");
        }
        else if (temp >= 20 && temp <= 30)
        {
            Console.WriteLine("w sam raz");
        }
        else if (temp >= 30 && temp <= 40)
        {
            Console.WriteLine(" zaczyna być słabo, bo gorąco\r\n");
        }
        else
        {
            Console.WriteLine(" a weź wyprowadzam się na Alaskę.");
        }


        //Task 10

        //Aby z trzech odcinków zbudować trójkąt, najdłuższy z nich musi być krótszy niż suma długość dwóch pozostałych
        double x = 40, y = 55, z = 65;

        if (x < z && y < z && x + y > z)
        {
            Console.WriteLine("Można zbudować trójkąt");
        }
        else if (x < y && z < y && x + z > y)
        {
            Console.WriteLine("Można zbudować trójkąt");
        }
        else if (y < x && z < x && y + z > x)
        {
            Console.WriteLine("Można zbudować trójkąt");
        }
        else
        {
            Console.WriteLine("Nie można zbudować trójkąta");
        }


        //Task 11

        int grade = 3;

        switch (grade)
        {
            case 1:
                Console.WriteLine("Niedostateczny");
                break;
            case 2:
                Console.WriteLine("dostateczny");
                break;
            case 3:
                Console.WriteLine("Dopuszczający");
                break;
            case 4:
                Console.WriteLine("Dobry");
                break;
            case 5:
                Console.WriteLine("Bardzo dobry");
                break;
            case 6:
                Console.WriteLine("Celujący");
                break;
        }

        //Task 12
        int day = Int32.Parse(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Poniedziałek");
                break;
            case 2:
                Console.WriteLine("Wtorek");
                break;
            case 3:
                Console.WriteLine("Środa");
                break;
            case 4:
                Console.WriteLine("Czwartek");
                break;
            case 5:
                Console.WriteLine("Piątek");
                break;
            case 6:
                Console.WriteLine("Sobota");
                break;
            case 7:
                Console.WriteLine("Niedziela");
                break;
        }


        //Task 13

        Console.WriteLine("Podaj pierwszą liczbe:");
        int num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Podaj drugą liczbe:");
        int num2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Podaj numer operacji do wykonania:");
        Console.WriteLine("1.Dodawanie");
        Console.WriteLine("2.Odejmowanie");
        Console.WriteLine("3.Mnożenie");
        Console.WriteLine("4.Dzielenie");
        int choice = Int32.Parse(Console.ReadLine()); switch (choice)
        {
            case 1:
                Console.WriteLine($" Wynik dodawania: {num1 + num2}");
                break;
            case 2:
                Console.WriteLine($" Wynik odejmowania: {num1 - num2}");
                break;
            case 3:
                Console.WriteLine($" Wynik mnożenia: {num1 * num2}");
                break;
            case 4:
                if (num2 != 0)
                    Console.WriteLine($" Wynik dodawania: {num1 / num2}");
                else
                    Console.WriteLine("Niemożna dzielić przez zero!!!");
                break;
            default:
                Console.WriteLine($" Niepoprawny wybór");
                break;

        }

    }
}