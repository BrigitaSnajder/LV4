using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int rowCount = data.Length;
            int columnCount = data[0].Length;
            double[] results = new double[columnCount];
            for(int i = 0; i < columnCount; i++)
            {
                double[] columns = new double[rowCount];
                for(int j = 0; j < rowCount; j++)
                {
                    columns[j] = data[j][i]; 
                }
                results[i] = columns.Average();
            }
            return results;
        }
    }
}
