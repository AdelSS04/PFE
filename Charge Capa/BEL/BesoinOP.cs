﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BesoinOP : Besoin
    {
        public int WeekWork { get; set; }
        public double AcutalCapa { get; set; }
        public double ActualCharge { get; set; }
        public double BesoinH { get; set; }
        public int NbrOp { get; set; }
        public double OpNeed { get; set; }
    }
}
