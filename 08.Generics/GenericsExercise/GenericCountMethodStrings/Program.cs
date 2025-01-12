﻿using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    class Program
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

            Box<string> evaluationBox = new Box<string>();
            evaluationBox.Value = Console.ReadLine();

            Console.WriteLine(CountOfGreaterElements(boxes,evaluationBox));
        }

        public static int CountOfGreaterElements<T>(List<Box<T>> elements, Box<T> compareElement)
            where T : IComparable
        {
            int count = 0;

            foreach (Box<T> box in elements)
            {
                if (box.Value.CompareTo(compareElement.Value) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
