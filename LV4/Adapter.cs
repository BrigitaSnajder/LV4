using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        public double[][] ConvertData(Dataset dataset)
        {
            IList<List<double>> convertedList = dataset.GetData();
            int matrixRow = convertedList.Count();
            double[][] convertedData = new double[matrixRow][];
            for (int i = 0; i < matrixRow; i++)
            {
                convertedData[i] = new double[convertedList[i].Count];
            }
            for(int i=0; i<matrixRow; i++)
            {
                for(int j = 0; j < convertedList[i].Count; j++)
                {
                    convertedData[i][j] = convertedList[i][j];
                }
            }
            return convertedData;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}
