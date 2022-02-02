using System;
using System.IO;

namespace OOP_hoc
{
    class Program
    {
        static void Main(string[] args)
        {
            var duong_dan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        }
    }
}

