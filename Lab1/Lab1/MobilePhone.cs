using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class MobilePhone
    {
        public Screen Screen { get; }
        public Battery Battery { get; }
        public Camera Camera { get; }
        public Dynamic Dynamic { get; }
        public MobilePhone(Screen screen, Battery battery, Camera camera, Dynamic dynamic)
        {
            Screen = screen;
            Battery = battery;
            Camera = camera;
            Dynamic = dynamic;
        }
        public string GetDescription()
        {
            return Screen.GetDescription() + Battery.GetDescription() + Camera.GetDirection() + Dynamic.GetDescription();
        }
    }
}
