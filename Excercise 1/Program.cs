﻿using System;


internal class exercise_1
{  public static void Main()
    {
        //Question_01();
        //Question_02();
        //Question_03();
        //Question_04();
        Question_010();
        Console.ReadKey();
    }
    public static void Question_01()
    {
        Console.Write("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Vay tong cua a va b la: ");
        int c = a + b;
        Console.WriteLine($"{a} + {b} = {c}");
    }
    public static void Question_02()

    {
        Console.Write("Nhap so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so b: ");
        int b = int.Parse(Console.ReadLine());

        // Display original values
        Console.WriteLine($"truoc khi doi: a = {a}, b = {b}");

        // Swapping using a third variable c
        int c = a;  // Store the value of a in c
        a = b;      // Assign the value of b to a
        b = c;      // Assign the value of c (original a) to b

        // Display swapped values
        Console.WriteLine($"Sau khi doi: a = {a}, b = {b}");
        Console.ReadLine();
    }
    public static void Question_03()
    {
        Console.WriteLine("nhap so a: ");
        //Console.Write("Enter first floating point number= ");
        float a = float.Parse(Console.ReadLine());
        //Console.Write("Enter second floating point number= ");
        Console.WriteLine("nhap so b: ");
        float b = float.Parse(Console.ReadLine());
        float product = a * b;
        //Console.WriteLine($" {a} + {b} = {a*b}");2
        Console.WriteLine($"product: {product}");

    }
    public static void Question_04()
    {
        Console.Write("Nhap so feet= ");
        float feet = float.Parse(Console.ReadLine());
        //double m = f * 0.3048;
        float meters = feet * 0.3048f;
        Console.WriteLine($"{feet} feet thi bang {meters} meters.");

    }
    public static void Question_05()
    {
        Console.WriteLine("nhap do C= ");
        double celcius = double.Parse(Console.ReadLine());
        double fahrenheit = celcius * 9 / 5 + 32;
        Console.WriteLine($"{celcius} do F bang voi {fahrenheit} do C");
        
        
    }
 
       public static void Question_06()
    {
        Console.WriteLine($"Size of int: " + sizeof(int) + "bytes");
        //Console.WriteLine($"Size of int: {sizeof (int)} bytes");
        Console.WriteLine($"Size of float: {sizeof(float)} bytes");
        Console.WriteLine($"Size of double: {sizeof(double)} bytes");
        Console.WriteLine($"Size of char: {sizeof(char)} bytes");
        Console.WriteLine($"Size of bool: {sizeof(bool)} bytes");
    }
    public static void Question_07()
    {
        Console.Write("Nhap character: ");
        char character = Console.ReadKey().KeyChar;
        Console.WriteLine($"Gia tri ASCII cua '{character}' la {(int)character}.");
    }
    public static void Question_08()
    {
        //Console.WriteLine("Nhap ban kinh cua duong tron: ");
        //float banKinh = float.Parse(Console.ReadLine());
        //float dienTich = (float)Math.PI * r * r;
        //Console.WriteLine($"Dien tich cua duong tron la: {dienTich}");
        const double PI = 3.14159;
        Console.WriteLine("Nhap ban kinh cua duong tron: ");
        float radius = float.Parse(Console.ReadLine());
        float area = (float)PI * radius * radius;
        Console.WriteLine($"Dien tich cua duong tron la: {area}");
    }

    public static void Question_09()
    {
        Console.WriteLine("Nhap canh cua hinh vuong: ");
        double canh = double.Parse(Console.ReadLine());
        double dienTich = double.Parse(Console.ReadLine());
        Console.WriteLine($"Dien tich cua hinh vuong la: " + dienTich);
        //Console.WriteLine($"Dien tich cua hinh vuong la: {dienTich}");
    }


    public static void Question_010()
    {
        //
        Console.WriteLine("Nhap so ngay: ");
        int days = int.Parse(Console.ReadLine());
        int year = days / 365;
        int weeks = (days - year * 365) / 7;
        int day = (days - year * 365) % 7;
        //Console.WriteLine($"{days} days = {year} year + {weeks} weeks {day} day");
        Console.WriteLine($"Voi so ngay la {days} days thi bang voi {year} years, {weeks} weeks va {day} day");
    }
}