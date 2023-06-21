using System;
using System.Diagnostics;
using System.Net;

class Program
{
    static void Main(string[] args)
    {

        //Lesson 5,6,7

        //Task 1 --- Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są  one równe czy nie.
        Console.WriteLine($"---Zadanie 1---");
        int a1 = 5, b1 = 5;
        if (a1 == b1)
            Console.WriteLine($"{a1} i {b1} są równe");

        //Task 2 --- Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
        Console.WriteLine($"---Zadanie 2---");
        Console.WriteLine($"Podaj liczbe");
        int number = Int32.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"Liczba {number} jest parzysta");
        }
        else
        {
            Console.WriteLine($"Liczba {number} jest nieparzysta");
        }

        //Task 3 --- Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
        Console.WriteLine($"---Zadanie 3---");
        Console.WriteLine($"Podaj liczbe");
        int number2 = Int32.Parse(Console.ReadLine());
        if (number2 > 0)
        {
            Console.WriteLine($"Liczba {number2} jest dodatnia");
        }
        else if(number2 == 0)
        {
            Console.WriteLine($"Liczba {number2}  nie jest ani dodatnia, ani ujemna.");
        }
        else
        {
            Console.WriteLine($"Liczba {number2} jest ujemna");
        }

        //Task 4 --- Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
        Console.WriteLine($"---Zadanie 4---");
        Console.WriteLine("POdaj rok do sprawdzenia");
        int year = Int32.Parse(Console.ReadLine());

        if((year % 4 == 0) && (year % 400 == 0 || year % 100 != 0)) 
        {
            Console.WriteLine($"Rok {year} jest przestępny");
        }
        else
        {
            Console.WriteLine($"Rok {year} nie jest rokiem przestępny");
        }

        //Task 5 --- Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,prezydenta.
        Console.WriteLine($"---Zadanie 5---");
        Console.WriteLine("Podaj ile masz lat");
        int age2 = Int32.Parse(Console.ReadLine());
        if (age2 >= 35)
        {
            Console.WriteLine("Mozesz zostac posłem, senatorem, premierem lub prezydentem.");
        }
        else if (age2 >= 30)
        {
            Console.WriteLine("Mozesz zostac posłem, senatorem lub premierem.");
        }
        else if (age2 >= 21)
        {
            Console.WriteLine("Mozesz zostac posłem lub premierem");
        }
        else
        {
            Console.WriteLine("Masz za mało lat na stanowisko posłą, sentaora, premiera lub prezydenta");
        }

        //Task 6 --- Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
        Console.WriteLine($"---Zadanie 6---");
        Console.WriteLine("Podaj wzrost");
        int height2 = Int32.Parse(Console.ReadLine());

        if (height2 >= 200)
        {
            Console.WriteLine("Jestes wielkoludem");
        }
        else if (height2 >= 160 && height2 < 200)
        {
            Console.WriteLine("Masz standardowy wzorst");
        }
        else
        {
            Console.WriteLine(" Jestes krasnoludem");
        }

        //Task 7 --- Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa
        Console.WriteLine($"---Zadanie 7---");
        Console.WriteLine("Podaj 3 liczby");
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        int c = Int32.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine($"Liczba {a} jest najwieksza");
        }
        else if (b >= c && b >= a)
        {
            Console.WriteLine($"Liczba {b} jest najwieksza");
        }
        else if (c >= a && c >= b)
        {
            Console.WriteLine($"Liczba {c} jest najwieksza");
        }

        //Task 8 --- Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg.Następujących kryteriów:
        //Wynik z Matury z matematyki powyżej 70
        //Wynik z fizyki powyżej 55
        //Wynik z chemii powyżej 45
        //Łączny wynik z 3 przedmiotów powyżej 180
        //Albo
        //Wynik z matematyki i jednego przedmiotu powyżej 150
        Console.WriteLine($"---Zadanie 8---");
        int math = 80, physics = 71, chemistry = 0;

        if ( (math > 70 && physics > 55 && chemistry > 45 && (math + physics + chemistry > 180)) || (math + physics > 150) || (math + chemistry > 150))
        {
            Console.WriteLine("Kandydat dopuszczony do rekrutacji");
        }
        else
        {
            Console.WriteLine("Kandydat nie jest dopuszczony do rekrutacji");
        }

        //Task 9 --- Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach
        /*
        Temp < 0 – cholernie piździ
        Temp 0 – 10 – zimno
        Temp 10 – 20 – chłodno
        Temp 20 – 30 – w sam raz
        Temp 30 – 40 – zaczyna być słabo, bo gorąco
        Temp >= 40 – a weź wyprowadzam się na Alaskę
        */
        Console.WriteLine($"---Zadanie 9---");
        int temp = 41;

        if (temp < 0)
        {
            Console.WriteLine(" cholernie piździ");
        }
        else if (temp >= 0 && temp <= 10)
        {
            Console.WriteLine("zimno");
        }
        else if (temp > 10 && temp <= 20)
        {
            Console.WriteLine("chłodno");
        }
        else if (temp > 20 && temp <= 30)
        {
            Console.WriteLine("w sam raz");
        }
        else if (temp > 30 && temp < 40)
        {
            Console.WriteLine(" zaczyna być słabo, bo gorąco\r\n");
        }
        else
        {
            Console.WriteLine(" a weź wyprowadzam się na Alaskę.");
        }


        //Task 10 --- Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt.

        //Aby z trzech odcinków zbudować trójkąt, najdłuższy z nich musi być krótszy niż suma długość dwóch pozostałych
        Console.WriteLine($"---Zadanie 10---");
        double x = 1, y = 2, z = 2;

        if (x <= z && y <= z && x + y > z)
        {
            Console.WriteLine("Można zbudować trójkąt");
        }
        else if (x <= y && z <= y && x + z > y)
        {
            Console.WriteLine("Można zbudować trójkąt");
        }
        else if (y <= x && z <=x && y + z > x)
        {
            Console.WriteLine("Można zbudować trójkąt");
        }
        else
        {
            Console.WriteLine("Nie można zbudować trójkąta");
        }


        //Task 11 --- Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
        Console.WriteLine($"---Zadanie 11---");
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
            default:
                Console.WriteLine("Niema takiej oceny");
                break;
        }

        //Task 12 --- Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę
        Console.WriteLine($"---Zadanie 12---");
        Console.WriteLine("Podaj dzien tygodnia");
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
            default:
                Console.WriteLine("Niema takiego dnia");
                break;
        }


        //Task 13 ---  Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem
        Console.WriteLine($"---Zadanie 13---");

        Console.WriteLine("Podaj pierwszą liczbe:");
        decimal num1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Podaj drugą liczbe:");
        decimal num2 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Podaj numer operacji do wykonania:");
        Console.WriteLine("1.Dodawanie");
        Console.WriteLine("2.Odejmowanie");
        Console.WriteLine("3.Mnożenie");
        Console.WriteLine("4.Dzielenie");
        int choice = Int32.Parse(Console.ReadLine()); switch (choice)
        {
            case 1:
                Console.WriteLine($" Wynik dodawania: { num1 + num2}");
                break;
            case 2:
                Console.WriteLine($" Wynik odejmowania: {num1 - num2}");
                break;
            case 3:
                Console.WriteLine($" Wynik mnożenia: {num1 * num2}");
                break;
            case 4:
                if (num2 != 0)
                    Console.WriteLine($" Wynik dzielenia: {num1 / num2}");
                else
                    Console.WriteLine("Niemożna dzielić przez zero!!!");
                break;
            default:
                Console.WriteLine($" Niepoprawny wybór");
                break;

        }

    }
}