﻿namespace Calculator
{
    public class SubtractOperator : IOperator
    {
        public decimal DoOperation(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
    }
}
