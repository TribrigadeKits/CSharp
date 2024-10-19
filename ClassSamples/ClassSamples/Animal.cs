using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSamples
{
    internal class Animal
    {
        public String Name { get; set; }
        public String Color { get; set; }
        public Animal(String name, String color)
        {
            Name = name;
            Color = color;
        }
        public String sing()
        {
            switch(Name)
            {
                case "ネコ":
                    return "にゃー！";
                case "犬":
                    return "わんわん！";
                default:
                    return "?";
            }
        }
    }
}
