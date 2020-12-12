﻿using System;

namespace Singleton
{
/*
 * Intent
    Ensure a class has only one instance, and provide a global point of access to it.
    Encapsulated "just-in-time initialization" or "initialization on first use".

    Problem
    Application needs one, and only one, instance of an object. Additionally, lazy initialization and global access are necessary.
*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
