using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public abstract class Mobile
    {
        public abstract Screen Screen { get; }
        public abstract Battery Battery { get; }
        public abstract Camera Camera { get; }
        public abstract Speaker Speaker { get; }
        public string MobileDescription() {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Battery type: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Camera type: {Camera.ToString()}");
            descriptionBuilder.AppendLine($"Speaker description: {Speaker.ToString()}");
            return descriptionBuilder.ToString();
        }
    }
}
