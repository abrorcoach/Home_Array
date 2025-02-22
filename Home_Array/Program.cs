namespace Home_Array;

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

        //int[][] num = new int[3][]
        //{
        //   [12,32,5,76,],
        //   [4,3,9,65,],
        //   [12,32,19,65,]
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

        //int[] num = { 41, 21, 33, 4, 31, 43};
        //int left = 0;
        //int right = num.Length-1;

        //while (left < right)
        //{
        //    int temp = num[left];
        //    num[left] = num[right];
        //    num[right] = temp;

        //    left++;
        //    right--;
        //}

        //foreach (int i in num)
        //{
        //    Console.WriteLine(i);
        //}



        //int[][] num = new int[3][]
        //{
        //    [12,32,12,65,1],
        //    [32,12,12,32,12],
        //    [11,23,29,34,8]
        //};
        //int max = num[0][0];

        //for (int i = 0; i < num.Length; i++)
        //{
        //    for (int j = 0; j < num[i].Length; j++)
        //    {
        //        if (max < num[i][j])
        //        {
        //            max = num[i][j];
        //        }
        //    }
        //}
        //Console.WriteLine(max * 100);


        ////////////////////////////////////

        //Console.WriteLine("parol kiriting");
        //string parol = Console.ReadLine();
        //Console.WriteLine(PasswordIsValued(parol));

        ////////////////////////////////

        //    int[,] matrix = {
        //    { 10, 11, 22, 31, 41 },
        //    { 50, 60, 73, 81, 91 },
        //    { 10, 11, 12, 13, 14 },
        //    { 15, 16, 17, 18, 19 },
        //    { 20, 21, 22, 23, 24 }
        //};

        //    int N = matrix.GetLength(0);
        //    int middle = N / 2;
        //    int sum = 0;

        //    for (int i = 0; i < N; i++)
        //    {
        //        // Summing elements in the middle row and middle column
        //        sum += matrix[middle, i];  // middle row
        //        sum += matrix[i, middle];  // middle column

        //        // Summing elements on the main diagonals
        //        sum += matrix[i, i];           // top-left to bottom-right diagonal
        //        sum += matrix[i, N - i - 1];   // top-right to bottom-left diagonal
        //    }

        //    // Remove duplicates at the center if N is odd, as it will be counted multiple times
        //    sum -= 3 * matrix[middle, middle];

        //    Console.WriteLine("Sum of elements at marked positions: " + sum);

        ///////////////////////////////////////////

        //Console.WriteLine("Write your password");
        //string pass = Console.ReadLine();
        //Console.WriteLine(PassWord(pass));

        ////////////////////////////////


        //Console.WriteLine("write");
        //string res = Console.ReadLine();
        //number(res);

        ////////////////////////////

        //int[] k = { 2, 3, 4, 5, 9, 1, 2, 5, 6 };
        //int sum = 0;

        //sum = +k[0] + k[1] + k[k.Length - 1] + k[k.Length - 2] + k[k.Length - 3];
        //Console.WriteLine(sum);

        //////////////////////////////////////////

        //Console.WriteLine("write number");
        //int res = int.Parse(Console.ReadLine());
        //int[][] num = new int[3][]
        //{
        //    [12,23,43,56,32],
        //    [65,76,23,54,98],
        //    [7,10,47,23,87]
        //};


        //bool isFound = false;

        //for(int i = 0; i < num.Length; i++)
        //{
        //    for(int j = 0; j < num[i].Length; j++)
        //    {
        //        if(res == num[i][j])
        //        {
        //            Console.WriteLine(res + " bor");
        //            isFound = true;
        //            break;
        //        }
        //    } 
        //    if(isFound)
        //    {
        //        break;
        //    }
        //}
        //if (!isFound)
        //{
        //    Console.WriteLine("bu son yoq");
        //}

        ///////////////////////////////////

        //int[][] num = new int[3][]
        //{
        //    [12,43,67,23,9],
        //    [34,65,11,10,7],
        //    [15,19,65,34,3]
        //};
        //int max = num[0][0];

        //for (int i = 0; i < num.Length; i++)
        //{
        //    for (int j = 0; j < num[i].Length; j++)
        //    {
        //        if (max < num[i][j])
        //        {
        //            max = num[i][j];
        //        }
        //    }

        //}
        //Console.WriteLine(max);


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
    static bool PassWord(string s)
    {
        bool SmallLetters = false;
        bool Numbers = false;
        bool Dogs = false;
        bool Dotcom = false;

        if (s.Length <= 8)
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] > 97 && s[i] < 122)
            {
                SmallLetters = true;
            }
            if (s[i] > 48 && s[i] < 57)
            {
                Numbers = true;
            }
            if (s[i] == 64)
            {
                Dogs = true;
            }
            if (s[i] == 46)
            {
                Dotcom = true;
            }

        }
        if (SmallLetters == true && Numbers == true && Dogs == true && Dotcom == true)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    static void number(string s2)
    {
        int count = 0;
        for (int i = 0; i < s2.Length; i++)
        {

            if (s2[i] >= 48 && s2[i] <= 57)
            {
                count++;
            }
        }
        Console.WriteLine(count);

    }

}
