using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab1
{
    public abstract class Screen
    {
        public string ScreenSize { get; set; }
        public string ScreenResolution { get; set; }
        public Screen()
        {
            ScreenSize = "4.7\"";
            ScreenResolution = "1334x750(pixels)";
        }
        public abstract string GetDescription();
    }
    public abstract class TouchScreen : Screen
    {
        public override string GetDescription() {
            return $" touch screen which has screen diagonal {ScreenSize} with resolution {ScreenResolution}. ";
        }
    }
    public class SingleTouchScreen : TouchScreen
    {
        public override string GetDescription()
        {
            return "Single" + base.GetDescription();
        }
    }
    public class MultiTouchScreen : TouchScreen
    {
        public override string GetDescription()
        {
            return "Multi" + base.GetDescription();
        }
    }
}
