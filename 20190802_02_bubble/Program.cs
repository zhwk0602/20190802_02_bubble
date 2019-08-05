using System;

namespace _20190802_02_bubble
{
    internal class Program
    {
        public static void BubbleSort(int[] RanArray)
        {
            int len = RanArray.Length;
            for (int i = 1; i <= len - 1; i++)//執行的回數
                for (int j = 1; j <= len - i; j++)//執行的次數
                {
                    if (RanArray[j] < RanArray[j - 1])
                    {
                        //二數交換
                        int temp = RanArray[j];
                        RanArray[j] = RanArray[j - 1];
                        RanArray[j - 1] = temp;
                    }
                }
        }

        public static void Main(string[] args)
        {
            int[] RanArray = new int[30];
            Random crandom = new Random();
            Console.WriteLine("排序前");

            for (int i = 0; i < RanArray.Length; i++)
            {
                RanArray[i] = crandom.Next(0, 101);

                for (int j = 0; j < i; j++)
                {
                    while (RanArray[j] == RanArray[i])    //檢查是否與前面產生的數值發生重複，如果有就重新產生
                    {
                        j = 0;  //如有重複，將變數j設為0，再次檢查 (因為還是有重複的可能)
                        RanArray[i] = crandom.Next(0, 101);   //重新產生，存回陣列，亂數產生的範圍是1~9
                    }
                }

                Console.Write($"{RanArray[i]}  ");
            }
            BubbleSort(RanArray);//使用泡沫排法的方法

            Console.WriteLine("\n排序後");
            for (int i = 0; i < RanArray.Length; i++)
                Console.Write($"{RanArray[i]}  ");

        }
    }
}