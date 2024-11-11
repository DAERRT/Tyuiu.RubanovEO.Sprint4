
using System.Windows.Markup;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RubanovEO.Sprint4.Task7.V2.Lib
{
    public class DataService : ISprint4Task7V2
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int s = 0;
            int g = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (s < value.Length)
                    {
                        matrix[i, j] = Convert.ToInt32(Convert.ToString(value[s]));
                        s++;
                    }
                    else 
                    { 
                        break; 
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        g += matrix[i, j];
                    }
                }
            }
            return g;
        }
    }
}
