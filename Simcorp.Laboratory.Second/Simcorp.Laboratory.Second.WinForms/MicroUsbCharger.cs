﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simcorp.Laboratory.Second.WinForms
{
    public class MicroUsbCharger : ICharger
    {
        private IOutput Output;

        public MicroUsbCharger(IOutput output) {
            Output = output;
        }

        public void Charge() {
            Output.Write($"Uses {nameof(MicroUsbCharger)} charger");
        }
    }
}
