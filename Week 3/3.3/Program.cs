using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1TwoDarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] temperatures;// size: row*col=4*4=16
                                  // datatype [,] name=new datatype[rows,cols] , rows*cols
                                  //temperatures = new float[20, 30];

            // int[,,] ints=new int[2,2,2]  3d array

            Console.WriteLine("2D array demo");
            Console.WriteLine("Enter the number of cities (rows)");
            int rows=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the temperatures received per city (cols)");
            int cols=int.Parse(Console.ReadLine());
            temperatures=new float[rows, cols];



            //这里是输入数据，游历一遍
            Console.WriteLine($"Please enter {rows * cols} readings of temperature"); // {rows * cols} 是计算总共需要输入的温度数据数量， 比如2x3=6个readings
            for (int i=0; i<rows; i++) // outer loop 第i个城市开始，然后row是用户输入的所有城市数量
            {
                for(int j=0; j<cols; j++)// inner loop 当前城市的第 j 条温度记录, cols 是用户输入的 每个城市的温度记录数量。
                {
                    Console.Write($"City[{i},{j}]");// 这个会显示为 City[0,0]: City[0, 1]: City[0, 2]: 让用户知道自己输入的是哪个城市的哪个温度记录
                    temperatures[i,j]=float.Parse(Console.ReadLine());

                }
            }


            //这里是输出数据，游历一遍
            //GetLength(n) 是为了 获取数组大小，让代码适用于 任何行列数，而不需要硬编码
            Console.WriteLine("Your entered temperatures are:");
            for(int i=0;i<temperatures.GetLength(0);i++)//rows 获取 二维数组的row数量，不是它里面的数值， 
            {
                for(int j=0;j<temperatures.GetLength(1);j++)//cols  获取 二维数组的cols数量，不是它里面的数值
                {
                    Console.Write($"{temperatures[i, j]},\t");

                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
