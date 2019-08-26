namespace Simcorp.Laboratory.Fourth.MobileFeatures {
    public abstract class Camera {
        public string CameraPixels { get; }

        public string CameraDiaphragm { get; }

        public Camera() {
            CameraPixels = "12 MP";
            CameraDiaphragm = "f/1.8";
        }

        public override string ToString()
        {
            return $" camera module, {CameraPixels} and diaphragm {CameraDiaphragm}.";
        }
    }

    public class DualModule : Camera
    {
        public override string ToString() {
            return "Dual" + base.ToString();
        }
    }

    public class SingleModule : Camera
    {
        public override string ToString() {
            return "Single" + base.ToString();
        }
    }
}
