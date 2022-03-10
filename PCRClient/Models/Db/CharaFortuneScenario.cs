using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CharaFortuneScenario
    {
        public long ScenarioId { get; set; }
        public long Rail1 { get; set; }
        public long Rail2 { get; set; }
        public long Rail3 { get; set; }
        public long Rail4 { get; set; }
    }
}
