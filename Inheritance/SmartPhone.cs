using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public double ScreenSize { get; }
        public string PhoneNumber { get; set; }



        public SmartPhone(double screenSize, string phoneNumber, int memory, double processor, int ram, string manufacturer, string model, double weight) : base(memory, processor, ram, manufacturer, model, weight)
        {
            ScreenSize = screenSize;
            PhoneNumber = phoneNumber;
        }

        public SmartPhone(double screenSize, string phoneNumber)
        {
            ScreenSize = screenSize;
            PhoneNumber = phoneNumber;
        }

        public SmartPhone()
        {
            ScreenSize = 4.5;
            PhoneNumber = "none";
        }

        public override string ToString()
        {
            return base.ToString() + " The Screen Size is " + ScreenSize + " in";
        }
    }
}
