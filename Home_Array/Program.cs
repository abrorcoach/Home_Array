﻿namespace Home_Array;

internal class Program
{
    static void Main(string[] args)
    {
        var GetClass = new Array();

        /////////////////////////////////////// 1)

        //string[][] task1 = new string[3][]
        //   {
        //    ["car","home","table"],
        //    ["phone","mouse","bottle"],
        //    ["handphone","keeyboard","hat"],
        //   };

        //GetClass.ShowOnTheWindowArray(task1);

        /////////////////////////////////////////////// 2)

        //int[][] num = new int[2][]
        //{
        //   [12,32,5,76,],
        //   [4,3,9,65,]
        //};


        //Console.WriteLine($" Sum: {GetClass.SumOfArray(num)}"); 

        ///////////////////////////////////////////////////////////////////// 3)

        //int[][] num = new int[3][]
        //{
        //   [912,32,5,761,],
        //   [4,3,9,65,],
        //   [4,33,91,65,]
        //};

        //GetClass.FindMax(num);

        //////////////////////////////////////////// 4)

        //int[][] num = new int[3][]
        //{
        //   [912,32,5,761,],
        //   [4,3,9,65,],
        //   [4,33,91,65,]
        //};

        //GetClass.FindMin(num);

        /////////////////////////////////////////// 5)

        //int[][] num = new int[3][]
        //{
        //   [1,2,5,1,],
        //   [4,3,9,5,],
        //   [4,3,9,6,]
        //};

        //GetClass.FindSumEachOfThem(num);

        /////////////////////////////////////////// 6)

        //int[][] num = new int[3][]
        //{
        //   [11,52,51,11,],
        //   [4,73,93,53,],
        //   [4,31,9,65,]
        //};

        //GetClass.FindEven(num);

        ////////////////////////////////////////// 7)

        //int[][] num = new int[3][]
        //{
        //   [1,2,5,1,],
        //   [4,3,9,5,],
        //   [4,3,9,6,]
        //};

        //GetClass.FindOdd(num);

        //////////////////////////////////////////// 8)

        //int[][] num = new int[3][]
        //{
        //   [11,5,61,17,],
        //   [4,83,49,93,],
        //   [4,32,59,65,]
        //};

        //GetClass.FindLengh(num);

        ////////////////////////////////////////////////// 9)

        //Console.WriteLine("Enter number");
        //int num = int.Parse(Console.ReadLine());

        //int[][] digits = new int[][]
        //{
        //    [12,32,54,65],
        //    [87,5,74,35],
        //    [81,22,4,65]
        //};

        //Console.WriteLine(GetClass.FindNUmber(digits, num)); 

        //////////////////////////////////////// 10)

        int[] num = { 41, 21, 33, 4, 31, 43};
        int left = 0;
        int right = num.Length-1;

        while (left < right)
        {
            int temp = num[left];
            num[left] = num[right];
            num[right] = temp;

            left++;
            right--;
        }
        
        foreach (int i in num)
        {
            Console.WriteLine(i);
        }
    }

    public void Examples()
    {
        //int[] numbers = { 11, 2, 1, 32, 12, 93, 54 };
        //int[] res = new int[6];

        //var num = numbers.OrderBy(x => x).ToList();
        //foreach (int x in num)
        //{
        //    Console.Write($"{x},");
        //}
        //Console.WriteLine();
        //var number = numbers.OrderByDescending(x => x).ToList();
        //foreach (int x in number)
        //{
        //    Console.Write($"{x},");
        //}

        //////////////////////////////////////////////////

        //string[] num = {"Abror","Ulmas","Axror"};


        //for (int i = 0; i < num.Length; i++){

        //    Console.WriteLine(num[i] + $" {i+1}00");

        //}

        ////////////////////////////////////////////////////
        ///

        //string[][] name = new string[3][]
        //{
        //    ["Abror","Axror","Ulmas"],

        //    ["Ulug","Ziyod","Maha"],

        //    ["Ali","Bektemir","Abdurashid"],
        //};
        //string[][] shops = new string[3][]
        //{
        //    ["shop 1","shop 2","shop 3"],

        //    ["shop 4","shop 5","shop 6"],

        //    ["shop 7","shop 8","shop 9"],
        //};



        //for (int i = 0; i < shops.Length; i++)
        //{


        //    for (int j = 0; j < shops[i].Length; j++)
        //    {
        //        Console.Write($"{shops[i][j]} - {name[i][j]},");
        //    }
        //    Console.WriteLine();
        //}

        ////////////////////////////////////////////////////////////////////

        //for (int i = 0; i < num.Length; i++)
        //{
        //    Array.Sort(num);
        //    Console.Write($"{num[i]},");
        //}

        //Console.WriteLine();

        //for (int i = 0; i < num.Length; i++)
        //{
        //    Array.Reverse(num);
        //    Console.Write($"{num[i]},");
        //}
    }

}
