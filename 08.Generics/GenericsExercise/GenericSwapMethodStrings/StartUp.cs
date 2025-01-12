﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int numberOfBoxes = int.Parse(Console.ReadLine());

            List<Box<string>> boxes = new List<Box<string>>();

            for (int i = 0; i < numberOfBoxes; i++)
            {
                string input = Console.ReadLine();
                Box<string> currentBox = new Box<string>();

                currentBox.Value = input;
                boxes.Add(currentBox);
            }

            int[] indices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int firstIndex = indices[0];
            int secondIndex = indices[1];

            SwapElements<string>(boxes, firstIndex, secondIndex);

            foreach (Box<string> box in boxes)
            {
                Console.WriteLine(box);
            }
        }
        public static void SwapElements<T>(List<Box<T>> elements, int firstIndex, int seconIndex)
        {
            Box<T> temp = elements[firstIndex];
            elements[firstIndex] = elements[seconIndex];
            elements[seconIndex] = temp;
        }
    }
}
