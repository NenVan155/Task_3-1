using System;

class OneDimention
{
    private int[] _myArr;

    public OneDimention(int length, bool userFill = false)
    {
        FillArr(length, userFill);
    }

    public int this[int index]
    {
        get
        {
            return _myArr[index];
        }
        set
        {
            _myArr[index] = value;
        }
    }

    public double Avg
    {
        get
        {
            int sum = 0;
            foreach (int num in _myArr)
            {
                sum += num;
            }
            return sum / (double) _myArr.Length;
        }
    }

    public int[] Uniq
    {
        get
        {
            int[] uniqArr = new int[_myArr.Length];
            int uniqAmount = 1;
            uniqArr[0] = _myArr[0];
            for (int i = 1; i < _myArr.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < i; j++)
                {
                    if (_myArr[i] == _myArr[j])
                    {
                        found = false;
                        break;

                    }
                }
                if (found)
                {
                    uniqArr[uniqAmount++] = _myArr[i];
                }
            }
            return uniqArr;
        }
    }

    public int[] ModLessThanHundred
    {
        get
        {
            int[] toRet = new int[_myArr.Length];
            int toRetIndex = 0;
            for (int i = 0; i < _myArr.Length; i++)
            {
                if (Math.Abs(_myArr[i]) <= 100)
                {
                    toRet[toRetIndex++] = _myArr[i];
                }
            }
            return toRet;
        }
    }

    public void PrintArr()
    {
        Console.WriteLine("Your array: ");
        foreach (int i in _myArr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public void FillArr(int length, bool userFill = false)
    {
        _myArr = new int[length];
        if (userFill)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter a value of {i + 1} element: ");
                _myArr[i] = int.Parse(Console.ReadLine());
            }
        }
        else
        {
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                _myArr[i] = rnd.Next(1, 10);
            }
        }
    }
}