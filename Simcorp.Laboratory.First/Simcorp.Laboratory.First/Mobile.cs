using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.First
{
    public abstract class Mobile
    {
        private Screen Screen { get; }
        private Battery Battery { get; }
        private Camera Camera { get; }
        private Speaker Speaker { get; }

        public Mobile(Screen screen, Battery battery, Camera camera, Speaker speaker)
        {
            Screen = screen;
            Battery = battery;
            Camera = camera;
            Speaker = speaker;
        }

        public string ToString()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Battery type: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Camera type: {Camera.ToString()}");
            descriptionBuilder.AppendLine($"Speaker description: {Speaker.ToString()}");
            return descriptionBuilder.ToString();
        }
    }
}
