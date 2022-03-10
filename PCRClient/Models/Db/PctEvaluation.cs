using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class PctEvaluation
    {
        public long EvaluationId { get; set; }
        public long EvaluationPoint { get; set; }
        public long FeverPoint { get; set; }
        public long MeetWidth { get; set; }
    }
}
