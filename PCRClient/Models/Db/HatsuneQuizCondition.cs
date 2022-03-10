using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneQuizCondition
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public long QuizId { get; set; }
        public long ConditionQuestId { get; set; }
        public long ConditionQuizId { get; set; }
        public long ConditionUnitId { get; set; }
        public long ConditionMissionId { get; set; }
        public long ConditionTimeFrom { get; set; }
    }
}
