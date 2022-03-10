using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class EventNaviCommentCondition
    {
        public long CommentId { get; set; }
        public long ConditionType1 { get; set; }
        public long ConditionValue1 { get; set; }
        public long ConditionType2 { get; set; }
        public long ConditionValue2 { get; set; }
        public long ConditionType3 { get; set; }
        public long ConditionValue3 { get; set; }
    }
}
