﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Second.WinForms
{
    public class LightningCharger : ICharger
    {
        private IOutput Output;

        public LightningCharger(IOutput output) {
            Output = output;
        }

        public void Charge() {
            Output.Write($"Uses {nameof(LightningCharger)} charger");
        }
    }
}
