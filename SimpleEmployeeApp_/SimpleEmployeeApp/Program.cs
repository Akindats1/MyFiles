﻿using SimpleEmployeeApp.Menus;
using System;
using System.IO;

namespace SimpleEmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================Welcome MGQS Employee App===============");
            Menu menu = new Menu();
            menu.MyMenu();

            
        }
    }
}
