using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Puzzles.CalculateTotalAmoutOfRequiredFuel
{
    public class CalculateTotalAmountOfRequiredFuelInput
    {
        public readonly IReadOnlyList<int> ModuleMasses;

        public CalculateTotalAmountOfRequiredFuelInput(IReadOnlyList<int> moduleMasses)
        {
            ModuleMasses = moduleMasses;
        }
    }
}
