using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class KaiserSpecialBattle
    {
        public long Mode { get; set; }
        public long RecommendedLevel { get; set; }
        public long PurposeType { get; set; }
        public long PurposeCount { get; set; }
        public long TriggerHp { get; set; }
        public long StoryIdModeStart { get; set; }
        public long StoryIdModeEnd { get; set; }
        public long WaveGroupId { get; set; }
        public long UnnecessaryDefeatChara { get; set; }
        public double StoryStartSecond { get; set; }
        public double ActionStartSecond { get; set; }
        public long HpGaugeColorFlag { get; set; }
        public long StartIdleTrigger { get; set; }
        public double AppearTime { get; set; }
    }
}
