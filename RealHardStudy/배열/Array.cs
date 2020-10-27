using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHardStudy.배열
{
    class Array
    {
        void Main()
        {
            //1차원
            int[] a = { 1, 2, 3, 4 };
            string[] s = { "1번", "2번", "3번" };
            Console.WriteLine(s[1]);
            //2차원
            int[,] a2 = { { 1, 2, 3 },{ 4, 5, 6 } };
            //가변배열
            int[][] arr = new int[3][];
            arr[0] = new int[4];
            arr[1] = new int[4];
            arr[2] = new int[4];

            arr[2][3] = 4;
            Console.WriteLine("길이는? : " + arr.Length);
        }
    }
}
