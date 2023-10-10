namespace WebShop4;

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class register
{
    string UserName;
    string PassWord;
    public register(string username, string password)
    {
        UserName = username;
        PassWord = password;
    }

    public static void startCustom()
    {
        Console.WriteLine("Do you want to register, log in as a customer or login as an admin?:");
        Console.Write("| L = Login | R = Register | A = Admin | ");
        Console.WriteLine(" ");
        string A = Console.ReadLine();

        switch (A.ToString().ToLower())
        {
            case "l":
                register.LoginUser();
                break;
            case "r":
                register.reg();
                break;
            case "a":
                register.LoginAdmin();
                break;
        }
    }

    public static void LoginUser()
    {
        Console.WriteLine("Skriv användarnamn: ");
        string Usname = Console.ReadLine();

        Console.WriteLine("Skriv Lösenord: ");
        string Paword = Console.ReadLine();

        string[] lines = File.ReadAllLines(@"../../../customers.txt");

        List<string> newwords = new List<string>();
        foreach (var item in lines)
        {
            newwords = new List<string>(item.Split("-"));
            if (Usname == newwords[0] && Paword == newwords[1])
            {

                Console.WriteLine("Välkommen tillbaka!");

                Console.WriteLine("Correct");

                break;
            }
        }
        if (Usname != newwords[0] || Paword != newwords[1])
        {

            Console.WriteLine("Fel, försök igen.");
        }
    }

    public static void LoginAdmin()
    {
        Console.WriteLine("Skriv användarnamn: ");
        string Usname = Console.ReadLine();

        Console.WriteLine("Skriv Lösenord: ");
        string Paword = Console.ReadLine();

        string[] lines = File.ReadAllLines(@"../../../admins.txt");

        List<string> newwords = new List<string>();
        foreach (var item in lines)
        {
            newwords = new List<string>(item.Split("-"));
            if (Usname == newwords[0] && Paword == newwords[1])
            {
                Console.WriteLine("Correct, you are logged in as Admin.");
                Console.WriteLine("| C = Customer Info | E = Exit |");
                string A = Console.ReadLine();

                switch (A.ToString().ToLower())
                {
                    case "c":
                        //NewAdmin.CustomerInfo();
                        break;
                    case "e":
                        register.startCustom();
                        break;
                }

            }
        }
        if (Usname != newwords[0] || Paword != newwords[1])
        {
            Console.WriteLine("Not Correct");
        }
    }

    public static void reg()
    {
        Console.WriteLine("Skriv användarnamn: ");
        string Uname = Console.ReadLine();
        Console.WriteLine("Skriv Lösenord: ");
        string Pword = Console.ReadLine();

        customer custom = new customer(username: Uname, password: Pword);

        string UP = Uname + "-" + Pword;

        string loca = @"../../../customers.txt";
        File.AppendAllText(loca, UP + Environment.NewLine);
    }

}