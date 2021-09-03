﻿namespace _08.CarSalesman
{
    class Engine
    {
        private string model;
        private int power;
        private string displacement;
        private string efficiency;

        public Engine()
        {
            Displacement = "n/a";
            Efficiency = "n/a";
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public string Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }
        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

    }
}
