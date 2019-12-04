using System;

namespace AdventOfCode.Puzzles.CalculateTotalAmoutOfRequiredFuel
{
    public class CalculateTotalAmountOfRequiredFuelInteractor 
    {
        public void Execute(CalculateTotalAmountOfRequiredFuelInput input,
            ICalculateTotalAmountORequiredFuelOutputPort outputPort)
        {
            var total = 0;

            foreach (int mass in input.ModuleMasses)
            {
                total += Convert.ToInt32(Math.Floor(mass / 3d) - 2);;
            }

            outputPort.DisplayTotalAmount(total);
        }
    }
}
