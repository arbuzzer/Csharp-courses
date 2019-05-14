using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public abstract class Camera
    {
        public string CameraPixels { get; set; }
        public string CameraDiaphragm { get; set; }
        public Camera()
        {
            CameraPixels = "12 MP";
            CameraDiaphragm = "f/1.8";
        }
        public abstract string GetDirection();
    }
    public abstract class CameraModule : Camera
    {
        public override string GetDirection()
        {
            return $" camera module, {CameraPixels} and diaphragm {CameraDiaphragm}.";
        }
    }
    public class DualModule : CameraModule
    {
        public override string GetDirection()
        {
            return "Dual" + base.GetDirection();
        }
    }
    public class SingleModule : CameraModule
    {
        public override string GetDirection()
        {
            return "Single" + base.GetDirection();
        }
    }
}
