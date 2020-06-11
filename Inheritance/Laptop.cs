using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        public double ScreenSize { get; }
        public string KeyboardSize { get; }



        public Laptop(double screenSize, string keyboardSize, int memory, double processor, int ram, string manufacturer, string model, double weight) : base(memory, processor, ram, manufacturer, model, weight)
        {
            ScreenSize = screenSize;
            KeyboardSize = keyboardSize;
        }

        public Laptop(double screenSize, string keyboardSize)
        {
           ScreenSize = screenSize;
            KeyboardSize = keyboardSize;
        }

        public Laptop()
        {
            ScreenSize = 15.4;
            KeyboardSize = "normal";
        }

        public override string ToString()
        {
            return base.ToString() + " The Screen Size is " + ScreenSize + " in and has a " + KeyboardSize + " keyboard";
        }


    }
}
