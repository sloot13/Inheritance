using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer : AbstractEntity
    {
        public int Memory { get; set; }
        public double Processor { get; set; }
        public int Ram { get; set; }
        public string Manufacturer { get; }
        public string Model { get; }
        public double Weight { get; set; }


        public Computer()
        {
            Memory = 1024;
            Processor = 3.4;
            Ram = 2048;
            Manufacturer = "Dell";
            Model = "XPS";
            Weight = 9.4;
        }

        public Computer(int memory, double processor, int ram, string manufacturer, string model, double weight)
        {
            Memory = memory;
            Processor = processor;
            Ram = ram;
            Manufacturer = manufacturer;
            Model = model;
            Weight = weight;
        }

        public void AddRam(int add)
        {
            Ram += add;
        }

        public void AddMemory(int add)
        {
            Memory += add;
        }
        public void AddWeight(double add)
        {
            Weight += add;
        }

        public override string ToString()
        {
            return "This Device has " + Memory + " memory, " + Ram + " RAM, made by " + Manufacturer + " model is " + Model;
        }

    }
}
