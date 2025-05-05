using System.Collections.Generic;
using System.Linq;
public class Plate
{
    public List<PlateNumber> rowOne = new List<PlateNumber>();
    public List<PlateNumber> rowTwo = new List<PlateNumber>();
    public List<PlateNumber> rowThr = new List<PlateNumber>();

    public bool IsBanko()
    {
        return rowOne.All(x => x.IsCrossedOut()) ||
               rowTwo.All(x => x.IsCrossedOut()) ||
               rowThr.All(x => x.IsCrossedOut());
    }

    public void CrossNumberOut(int number)
    {
        List<PlateNumber> allNumbers = new List<PlateNumber>();
        allNumbers.AddRange(rowOne);
        allNumbers.AddRange(rowTwo);
        allNumbers.AddRange(rowThr);

        foreach (var plateNumber in allNumbers)
        {
            if (plateNumber.Value == number)
            {
                plateNumber.CrossOut();
                break;
            }
        }
    }

    // factory
    public static Plate CreatePlate() 
    {
        var rnd = new Random();// а single Random to generate all random values
        Plate plate;

        while (true) // cycle, which keep trying until we produce a valid plate layout
        {
            
            plate = new Plate();// a new empty object "Plate"
            bool[,] layout = new bool[3, 9];// 2D array

            //method Linq, using to generate numbers
            var cells = Enumerable.Range(0, 27)// takes numbers from 0, takes first 27 numbers
                                  .OrderBy(_ => rnd.Next())//"_" shows, that items´ value does not matter; rnd.Next returns random num and suffles numbers
                                  .Take(15);//takes the first 15 of those shuffled numbers

            foreach (int idx in cells)
            {
                int row = idx / 9;
                int column = idx % 9;
                layout[row, column] = true;
            }

            
            bool valid = true;
            for (int r = 0; r < 3; r++)
            {
                int cnt = 0;
                for (int c = 0; c < 9; c++)
                    if (layout[r, c]) cnt++;
                if (cnt != 5) { valid = false; break; }
            }
            if (!valid) continue;

            for (int c = 0; c < 9; c++)
            {
                int cnt = 0;
                for (int r = 0; r < 3; r++)
                    if (layout[r, c]) cnt++;
                if (cnt < 1) { valid = false; break; }
            }
            if (!valid) continue;

            
            var used = new HashSet<int>();
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 9; c++)
                {
                    if (!layout[r, c]) continue;

                   
                    int min = (c == 0 ? 1 : c * 10);
                    int max = (c == 8 ? 90 : c * 10 + 9);

                    int val;
                    do
                    {
                        val = rnd.Next(min, max + 1);
                    } while (!used.Add(val));

                    var pn = new PlateNumber(val, c);
                    if (r == 0) plate.rowOne.Add(pn);
                    else if (r == 1) plate.rowTwo.Add(pn);
                    else plate.rowThr.Add(pn);
                }

            
            plate.rowOne.Sort((a, b) => a.Column.CompareTo(b.Column));
            plate.rowTwo.Sort((a, b) => a.Column.CompareTo(b.Column));
            plate.rowThr.Sort((a, b) => a.Column.CompareTo(b.Column));

            
            break;
        }

        return plate;
    }

    //public static Plate CreatePlate()
    //{
    //    Plate plate = new Plate();
    //    List<List<PlateNumber>> plateRows = new() {
    //        plate.rowOne,
    //        plate.rowTwo,
    //        plate.rowThr
    //    };

    // List<int> allNumbers = new List<int>();
    // List<int> rows = new List<int>();


    // for (int column = 0; column < 9; column++)
    // {
    //     int fistRow = CreateUniqueNumber(rows, 0, 2);
    //     int firstNumber = CreateUniqueNumber(allNumbers, 1, 90);
    //     rows.Add(fistRow);

    //     PlateNumber plateNumberOne = new PlateNumber(firstNumber, column);
    //     plateRows[fistRow].Add(plateNumberOne);

    //     allNumbers.Add(firstNumber);

    //     if (GetRandomNumber(0, 1) == 0)
    //     {
    //         int secondRow = CreateUniqueNumber(rows, 0, 2);
    //         int secondNumber = CreateUniqueNumber(allNumbers, 1, 90);
    //         PlateNumber plateNumberTwo = new PlateNumber(secondNumber, column);
    //         plateRows[secondRow].Add(plateNumberTwo);

    //         allNumbers.Add(secondNumber);
    //     }

    //     if (GetRandomNumber(0, 1) == 0)
    //     {
    //         int thirdRow = CreateUniqueNumber(rows, 0, 2);
    //         int thirdNumber = CreateUniqueNumber(allNumbers, 1, 90);
    //         PlateNumber plateNumberThr = new PlateNumber(thirdNumber, column);
    //         plateRows[thirdRow].Add(plateNumberThr);

    //         allNumbers.Add(thirdNumber);
    //     }

    //     rows.Clear();
    // }

    //    return plate;
    //}

    /// <summary>
    /// Generates a random integer between the specified minimum and maximum values (inclusive).
    /// </summary>
    /// <param //name="min">The inclusive lower bound of the random number returned.</param>
    /// <param //name="max">The inclusive upper bound of the random number returned.</param>
    /// <returns>A random integer between <paramref //name="min"/> and <paramref //name="max"/>.</returns>
    public static int GetRandomNumber(int min, int max)
    {
        Random random = new Random();
        int number = random.Next(min, max + 1);
        return number;
    }

    // public static bool IsNumberInList(List<int> list, int number)
    // {
    //     foreach (int plateNumber in list)
    //     {
    //         if (plateNumber == number)
    //         {
    //             return true;
    //         }
    //     }
    //     return false;
    // }

    // public static int CreateUniqueNumber(List<int> items, int min, int max)
    // {
    //     // Check if all numbers are already in the list
    //     if (items.Count == max)
    //     {
    //         throw new Exception("All numbers are already in the list.");
    //     }

    //     while (true)
    //     {
    //         int number = GetRandomNumber(min, max);
    //         if (!IsNumberInList(items, number))
    //         {
    //             return number;
    //         }
    //     }
    // }

    // render
    public void Show()
    {
        for (int number = 0; number < 9; number++)
        {
            var itemOne = rowOne.FirstOrDefault(x => x.Column == number);
            Console.Write($"{itemOne?.Value}\t");
        }
        Console.WriteLine();

        for (int number = 0; number < 9; number++)
        {
            var itemTwo = rowTwo.FirstOrDefault(x => x.Column == number);
            Console.Write($"{itemTwo?.Value}\t");
        }
        Console.WriteLine();

        for (int number = 0; number < 9; number++)
        {
            var itemThr = rowThr.FirstOrDefault(x => x.Column == number);
            Console.Write($"{itemThr?.Value}\t");
        }
        Console.WriteLine();
    }
}