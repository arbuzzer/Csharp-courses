namespace Simcorp.Laboratory.MobileFeatures {
    public abstract class Screen {
        public string ScreenSize { get; }

        public string ScreenResolution { get; }

        public Screen() {
            ScreenSize = "4.7\"";
            ScreenResolution = "1334x750(pixels)";
        }

        public override string ToString()
        {
            return $" touch screen which has screen diagonal {ScreenSize} with resolution {ScreenResolution}. ";
        }
    }

    public class SingleTouchScreen : Screen
    {
        public override string ToString() {
            return "Single" + base.ToString();
        }
    }

    public class MultiTouchScreen : Screen
    {
        public override string ToString() {
            return "Multi" + base.ToString();
        }
    }
}
