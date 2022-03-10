using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SeasonPack
    {
        public long Id { get; set; }
        public long MissionId { get; set; }
        public long DispOrder { get; set; }
        public long CategoryIcon { get; set; }
        public string ReceiveText { get; set; } = null!;
        public string AfterText { get; set; } = null!;
        public long GiftMessageId { get; set; }
        public long Term { get; set; }
        public long RepurchaseDay { get; set; }
        public long GroupId { get; set; }
        public long SystemId1 { get; set; }
        public long AddNum1 { get; set; }
        public long ItemRecordId { get; set; }
        public long ConditionFlg { get; set; }
        public long RewardRate1 { get; set; }
    }
}
