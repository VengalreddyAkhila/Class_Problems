using System;
using System.Collections.Generic;
using System.Text;

namespace GarbageCollections
{
    abstract class Calculator
    {
        public abstract void Mul(int X, int Y);
    }
    class Multiplication : Calculator
    {
        public override void Mul(int X, int Y)
        {
            int result = X * Y;
            Console.WriteLine($"Multiplication of {X} * {Y} = {result}");
        }
    }
    class Division : Multiplication
    {
        public void Div(int X, int Y)
        {
            int result = X / Y;
            Console.WriteLine($"Division of {X} / {Y} = {result}");
        }

    }
}
