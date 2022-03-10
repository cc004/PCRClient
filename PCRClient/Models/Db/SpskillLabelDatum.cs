using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SpskillLabelDatum
    {
        public long UnitId { get; set; }
        public string NormalLabelText { get; set; } = null!;
        public string SpLabelText { get; set; } = null!;
    }
}
