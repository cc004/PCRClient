using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class PkbPitcherBallType
    {
        public long PitcherId { get; set; }
        public long BallType { get; set; }
        public string BallTypeName { get; set; } = null!;
    }
}
