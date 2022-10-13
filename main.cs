// Created by: Mikey Gloriani
// Created on: Oct 2022
//
// This program displays, "Hello, World!"


using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        string streetName;
        int streetNumber;

        Console.WriteLine("This program gets shows the address you put in");
        Console.WriteLine("");

        Console.Write("Enter your street name: ");
        streetName = Console.ReadLine();
        Console.Write("Enter your street number: ");
        streetNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Your address is: " + streetNumber + " " + streetName + ".");

        Console.WriteLine("\nDone.");
    }
}