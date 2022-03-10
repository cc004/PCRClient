using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class EventReminderCondition
    {
        public long Id { get; set; }
        public long ReminderId { get; set; }
        public long ConditionType { get; set; }
        public long ConditionId { get; set; }
    }
}
