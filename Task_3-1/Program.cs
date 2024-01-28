using System;

class Program
{
    static void Main(string[] args)
    {
        OneDimention odTest1 = new OneDimention(5);
        odTest1.PrintArr();
        OneDimention odTest2 = new OneDimention(3, true);
        odTest2.PrintArr();

        odTest1[0] = -111;
        odTest1.PrintArr();
        odTest2.FillArr(5);
        odTest2.PrintArr();
        int[] uniq = odTest2.Uniq;
        int[] modLessThanHundred = odTest1.ModLessThanHundred;
        double avg = odTest1.Avg;

        Console.WriteLine("Unique values: ");
        foreach(int i in uniq)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        odTest1.PrintArr();
        Console.WriteLine("Values with module less then hundred: ");
        foreach (int i in modLessThanHundred)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Average value: " + avg);

        Console.WriteLine("---------------");

        TwoDimention tdTest1 = new TwoDimention(5, 5);
        tdTest1.PrintArr();
        TwoDimention tdTest2 = new TwoDimention(3, 3, true);
        tdTest2.PrintArr();

        avg = tdTest2.Avg;
        Console.WriteLine("Average value: " + avg);

        tdTest1[2, 1] = 69;
        tdTest1.DoublePrint();

        tdTest2.FillArr(4, 4);
        tdTest2.PrintArr();

        Console.WriteLine("---------------");

        LadderArrs ldTest1 = new LadderArrs(5);
        ldTest1.PrintArr();
        LadderArrs ldTest2 = new LadderArrs(3, true);
        ldTest2.PrintArr();

        ldTest2[0, 0] = 69;
        ldTest2.PrintArr();
        
        avg = ldTest2.Avg;
        Console.WriteLine("Average value: " + avg);

        ldTest1.FillArr(4);
        ldTest1.PrintArr();

        double[] avgs = ldTest1.AvgForEveryNested;
        Console.WriteLine("Avgs for every nested array: ");
        foreach(double i in avgs)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        int[][] productionsOfIndexes = ldTest1.WithEveryEvenToIndexProduct;
        Console.WriteLine("Your ladder array with indexes products: ");
        foreach(int[] line in productionsOfIndexes)
        {
            foreach(int num in line)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
