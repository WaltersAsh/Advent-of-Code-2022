using System.Collections.Generic;
using System.Linq;
using System.IO;

class Day1
{
    static void Main(string[] args)
    {
        var sums = new List<int>();
        var sum = 0;

        foreach (string line in File.ReadLines("..\\..\\..\\..\\..\\..\\day1-input.txt"))
        {
            if (string.IsNullOrEmpty(line))
            {
                sums.Add(sum);
                sum = 0;
                continue;
            }

            sum += int.Parse(line);
        }

        var orderedSums = sums.OrderByDescending(x => x);
        Console.WriteLine("Part 1 - Max calories an elf carried: " + orderedSums.First());
        Console.WriteLine("Part 2 - Total calories carried by top three elves: " + orderedSums.Take(3).Sum());
    }
}