using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class TtkScore
    {
        public long DifficultyLevel { get; set; }
        public long CoefficientDifficulty { get; set; }
        public long CoefficientCoinScore { get; set; }
        public long Life { get; set; }
        public long CoefficientWrongNum { get; set; }
    }
}
