namespace Home_Array
{
    public class Array
    {
        public void ShowOnTheWindowArray(string[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

        public int SumOfArray(int[][] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
            }
            return sum;
        }

        public void FindMax(int[][] array)
        {
            int max = array[0][0];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] > max)
                    {
                        max = array[i][j];

                    }
                }
            }
            Console.WriteLine(max);
        }

        public void FindMin(int[][] array)
        {
            int min = array[0][0];

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] < min)
                    {
                        min = array[i][j];

                    }
                }
            }
            Console.WriteLine(min);
        }

        public void FindSumEachOfThem(int[][] array)
        {

            
            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }

                Console.WriteLine(sum);

            }
            


        }

        public void FindEven(int[][] array)
        {
            

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        Console.WriteLine(array[i][j]);
                    }
                }
            }


        }

        public void FindOdd(int[][] array)
        {


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 1)
                    {
                        Console.WriteLine(array[i][j]);
                    }
                }
            }


        }

        public void FindLengh(int[][] array)
        {
            for(int i = 0;i < array.Length; i++)
            {
                    Console.WriteLine($" {i+1}: {array[i].Length}");
            }
        }

        public bool FindNUmber(int[][] array,int num)
        {
            for(int i = 0; i < array.Length ; i++)
            {
                for(int j = 0; j < array[i].Length ; j++)
                {
                    if(array[i][j] == num)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void ReverseNumber(int[] num)
        {
            
            for(int i = 0; i < num.Length ; i++)
            {
                
                Console.WriteLine(num[i]);
 
            }

          
        }
    }
}
