﻿namespace WorkWithInterfaces.Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(new Logger());
            calculator.Sum();
        }
    }
}