﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Second.WinForms
{
    public class WirelessCharger : ICharger
    {
        private IOutput Output;

        public WirelessCharger(IOutput output) {
            Output = output;
        }

        public void Charge() {
            Output.Write($"Using {nameof(WirelessCharger)} charger");
        }
    }
}
