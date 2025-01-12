﻿using System;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        public T Value { get; set; }

        public override string ToString()
        {
            Type valueType = Value.GetType();
            return $"{valueType.FullName}: {Value}";
        }
    }
}
