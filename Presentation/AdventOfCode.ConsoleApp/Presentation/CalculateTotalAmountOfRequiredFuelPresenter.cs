using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode.Puzzles.CalculateTotalAmoutOfRequiredFuel;

namespace AdventOfCode.Presentation
{
    class CalculateTotalAmountOfRequiredFuelPresenter : ICalculateTotalAmountORequiredFuelOutputPort
    {
        public void DisplayTotalAmount(int amount)
        {
            Console.WriteLine($"Total Amount of fuel needed: {amount}");
        }
    }
}
