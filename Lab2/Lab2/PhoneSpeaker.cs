﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PhoneSpeaker : IPlayback
    {
        public void Play(object data) {
            Console.WriteLine($"{nameof(PhoneSpeaker)} sound");
        }
    }
}
