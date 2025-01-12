﻿using System;

namespace CocktailParty
{
    public class Ingredient
    {
        public Ingredient(string name, int alcohol, int quantity)
        {
            this.Name = name;
            this.Alcohol = alcohol;
            this.Quantity = quantity;
        }

        public string Name { get; set; }
        public int Alcohol { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Ingredient: {Name}{Environment.NewLine}Quantity: {Quantity}{Environment.NewLine}Alcohol: {Alcohol}";
        }
    }
}
