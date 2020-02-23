﻿using System;
namespace DataStructures.Arrays
{
    public class ArraysDS
    {
        public ArraysDS()
        {
        }

        public static void Run()
        {
            ArraysDS.reverseArray(new int[] { 1, 4, 3, 2 });
        }
        static int[] reverseArray(int[] a)
        {
            int[] reversedArray = new int[a.Length];

            for (int i = a.Length; i >= 0; i--)
            {
                reversedArray[a.Length - i] = a[i];
            }

            return reversedArray;
        }
    }
}
