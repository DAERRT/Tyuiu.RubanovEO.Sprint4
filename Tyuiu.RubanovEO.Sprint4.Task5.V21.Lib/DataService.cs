﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RubanovEO.Sprint4.Task5.V21.Lib
{
    public class DataService : ISprint4Task5V21
    {
        public int[,] Calculate(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j]  > 0)
                    {
                        array[i, j] = 1;
                    }
                }
            }
            return array;
        }
    }
}