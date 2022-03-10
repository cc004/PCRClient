using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class LoginBonusMessageDatum
    {
        public long Id { get; set; }
        public long LoginBonusId { get; set; }
        public long Type { get; set; }
        public long DayCount { get; set; }
        public long LuckPattern { get; set; }
        public long Rate { get; set; }
        public long CharacterId { get; set; }
        public string CharacterName { get; set; } = null!;
        public string Message { get; set; } = null!;
        public long VoiceId { get; set; }
        public long AdditionalType { get; set; }
        public string AdditionalParam { get; set; } = null!;
    }
}
