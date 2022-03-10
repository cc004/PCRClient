using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class DodgeTpRecovery
    {
        public long SystemId { get; set; }
        public double RecoveryRatio { get; set; }
    }
}
