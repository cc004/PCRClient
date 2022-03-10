using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class LoginBonusDetail
    {
        public long Id { get; set; }
        public long LoginBonusId { get; set; }
        public long Count { get; set; }
        public long RewardType { get; set; }
        public long RewardId { get; set; }
        public long RewardNum { get; set; }
        public long CharacterId { get; set; }
        public string CharacterName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long VoiceId { get; set; }
        public long BgId { get; set; }
    }
}
