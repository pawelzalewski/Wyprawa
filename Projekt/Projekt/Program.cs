﻿using System;
using System.Net.Mime;

namespace Projekt
{
    public class Program
    {
        public static Postac postac = new Postac();

        static void Main(string[] args)
        {
            // Start();
            // Introduction.Intro();
            // Chapter_1.PierwszaAkcja();
            // Chapter_2.Rozdzial2();
            //
            // Chapter_4.Deszcz();
            Chapter_5.Sesja();
        }

        static void Start()
        {
            string title = @" $$$$$$\    $$\                     $$\                      $$\  $$\               $$\       $$\  $$$$$$\           
$$  __$$\   $$ |                    $$ |                     $$ | $  |              $$ |      \__|$$  __$$\          
$$ /  \__|$$$$$$\   $$\   $$\  $$$$$$$ | $$$$$$\  $$$$$$$\ $$$$$$\\_/$$$$$$$\       $$ |      $$\ $$ /  \__|$$$$$$\  
\$$$$$$\  \_$$  _|  $$ |  $$ |$$  __$$ |$$  __$$\ $$  __$$\\_$$  _| $$  _____|      $$ |      $$ |$$$$\    $$  __$$\ 
 \____$$\   $$ |    $$ |  $$ |$$ /  $$ |$$$$$$$$ |$$ |  $$ | $$ |   \$$$$$$\        $$ |      $$ |$$  _|   $$$$$$$$ |
$$\   $$ |  $$ |$$\ $$ |  $$ |$$ |  $$ |$$   ____|$$ |  $$ | $$ |$$\ \____$$\       $$ |      $$ |$$ |     $$   ____|
\$$$$$$  |  \$$$$  |\$$$$$$  |\$$$$$$$ |\$$$$$$$\ $$ |  $$ | \$$$$  |$$$$$$  |      $$$$$$$$\ $$ |$$ |     \$$$$$$$\ 
 \______/    \____/  \______/  \_______| \_______|\__|  \__|  \____/\_______/       \________|\__|\__|      \_______|";
            poczatek:
            Console.WriteLine(title);
            Console.WriteLine("=======================================");
            Console.WriteLine("Aby wejść do świata gry, nacisnij G");
            Console.WriteLine("=======================================");
            string g = Console.ReadLine();
            Console.Clear();
            if (g.ToLower() == "g")
                Print("Witam gracza", 60);
            else
                goto poczatek;
            //Wstęp oraz imie naszej postaci
            Print("Podaj swoje imię:", 60);
            imie:
            postac.name = Console.ReadLine();
            Console.Clear();
            if (postac.name == "")
            {
                Print("Musisz podac swoje imie");
                goto imie;
            }

            Console.WriteLine("A więc twoje imie to {0}, grubo", postac.name);
            Console.ReadKey();
            Console.Clear();
        }

        public static void Print(string text, int speed = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }

            Console.WriteLine();
        }
        
    }
}