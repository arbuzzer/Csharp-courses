using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public abstract class Dynamic
    {
        public string DynamicFeature { get; set; }
        public string DynamicFrequency { get; set; }
        public Dynamic()
        {
            DynamicFeature = "active noise cancellation with dedicated mic";
            DynamicFrequency = "from 20 Hz to 20,000 Hz";
        }
        public abstract string GetDescription();
    }
    public abstract class DynamicType : Dynamic
    {
        public override string GetDescription()
        {
            return $" who work on frequency {DynamicFrequency} and have one feature: {DynamicFeature}. ";
        }
    }
    public class Stereo : DynamicType
    {
        public override string GetDescription()
        {
            return "Stereo" + base.GetDescription();
        }
    }
    public class Mono : DynamicType
    {
        public override string GetDescription()
        {
            return "Mono" + base.GetDescription();
        }
    }
}
