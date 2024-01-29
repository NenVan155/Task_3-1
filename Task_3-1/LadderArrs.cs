using System;

class LadderArrs
{
    private int[][] _myArr;

    public LadderArrs(int depth, bool userFill = false)
    {
        FillArr(depth, userFill);
    }

    public int this[int index1, int index2]
    {
        get { return _myArr[index1][index2]; }
        set { _myArr[index1][index2] = value; }
    }

    public double Avg
    {
        get
        {
            double sum = 0;
            foreach (int[] line in _myArr)
            {
                foreach (int num in line)
                {
                    sum += num;
                }
            }
            return sum / _myArr.Length;
        }
    }

    public double[] AvgForEveryNested
    {
        get
        {
            double[] toRet = new double[_myArr.GetLength(0)];
            double sum = 0;
            for (int i = 0; i < _myArr.GetLength(0); i++)
            {
                for (int j = 0; j < _myArr[i].Length; j++)
                {
                    sum += _myArr[i][j];
                }
                toRet[i] = sum / _myArr[i].Length;
                sum = 0;
            }
            return toRet;
        }
    }

    public int[][] WithEveryEvenToIndexProduct
    {
        get
        {
            int[][] toRet = new int[_myArr.GetLength(0)][];
            for (int i = 0; i < _myArr.GetLength(0); i++)
            {
                toRet[i] = new int[_myArr[i].Length];
                for (int j = 0; j < _myArr[i].Length; j++)
                {
                    if (_myArr[i][j] % 2 == 0)
                    {
                        toRet[i][j] = i * j;
                    }
                    else
                    {
                        toRet[i][j] = _myArr[i][j];
                    }
                }
            }
            return toRet;
        }
    }

    public void PrintArr()
    {
        Console.WriteLine("Your ladder array: ");
        foreach (int[] line in _myArr)
        {
            foreach (int num in line)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

    public void FillArr(int depth, bool userFill = false)
    {
        _myArr = new int[depth][];
        if (userFill)
        {
            for (int i = 0; i < depth; i++)
            {
                Console.Write($"Enter the length of {i + 1} line: ");
                _myArr[i] = new int[int.Parse(Console.ReadLine())];
                for (int j = 0; j < _myArr[i].Length; j++)
                {
                    Console.Write($"Enter a value of {j + 1} element of {i + 1} line: ");
                    _myArr[i][j] = int.Parse(Console.ReadLine());
                }
            }

        }
        else
        {
            Random rnd = new Random();
            for (int i = 0; i < depth; i++)
            {
                _myArr[i] = new int[rnd.Next(1, 10)];
                for (int j = 0; j < _myArr[i].Length; j++)
                {
                    _myArr[i][j] = rnd.Next(1, 10);
                }
            }
        }
    }
}