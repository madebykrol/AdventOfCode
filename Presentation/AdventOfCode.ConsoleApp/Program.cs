using System;
using System.IO;
using System.Linq;
using AdventOfCode.Presentation;
using AdventOfCode.Puzzles.CalculateTotalAmoutOfRequiredFuel;

namespace AdventOfCode.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new CalculateTotalAmountOfRequiredFuelInteractor().Execute(new CalculateTotalAmountOfRequiredFuelInput(
                System.IO.File.ReadAllLines(@"..\..\..\..\PuzzleInput\ModuleMasses.txt")
                    .Select(x => Convert.ToInt32(x)).ToList()), 
                new CalculateTotalAmountOfRequiredFuelPresenter());

            Console.ReadLine();
        }
    }
}
