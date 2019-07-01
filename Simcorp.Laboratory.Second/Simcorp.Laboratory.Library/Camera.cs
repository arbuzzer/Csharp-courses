using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Library
{
    public abstract class Camera
    {
        public string CameraPixels { get; }
        public string CameraDiaphragm { get; }
        public Camera() {
            CameraPixels = "12 MP";
            CameraDiaphragm = "f/1.8";
        }
        public abstract string ToString();
    }
    public abstract class CameraModule : Camera
    {
        public override string ToString() {
            return $" camera module, {CameraPixels} and diaphragm {CameraDiaphragm}.";
        }
    }
    public class DualModule : CameraModule
    {
        public override string ToString() {
            return "Dual" + base.ToString();
        }
    }
    public class SingleModule : CameraModule
    {
        public override string ToString() {
            return "Single" + base.ToString();
        }
    }
}
