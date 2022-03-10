using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class UnitMypagePo
    {
        public long Id { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }
        public double Scale { get; set; }
    }
}
