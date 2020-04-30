using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset data = new Dataset(@"C:\csvdat.csv");
            Adapter adapt = new Adapter(new Analyzer3rdParty());
            double[][] convertingData = adapt.ConvertData(data);
            Console.WriteLine("Matrix:");
            for (int i = 0; i < convertingData.Length; i++)
            {
                for (int j = 0; j < convertingData[i].Length; j++)
                {
                    Console.Write(convertingData[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Row average:");
            double[] rowsAverage=adapt.CalculateAveragePerRow(data);
            double[] columnsAverage=adapt.CalculateAveragePerColumn(data);
            for(int i = 0; i < rowsAverage.Length; i++)
            {
                Console.Write(rowsAverage[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("Column average:");
            for (int i = 0; i < columnsAverage.Length; i++)
            {
                Console.Write(columnsAverage[i] + "\t");
            }
        }
    }
}
