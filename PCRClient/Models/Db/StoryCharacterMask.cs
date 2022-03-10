using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class StoryCharacterMask
    {
        public long CharaId { get; set; }
        public double Offset { get; set; }
        public double Size { get; set; }
        public double Softness { get; set; }
    }
}
